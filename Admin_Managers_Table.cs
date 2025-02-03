﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWin
{
    public partial class Admin_Managers_Table : Form
    {
        public Admin_Managers_Table()
        {
            InitializeComponent();
            Form2_Load();
        }
        SqlConnection con;
        public void dbcon()
        {
            try
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\new_project\database\Game_Mart.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True
");
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect to the database: {ex.Message}", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Admin_Managers_Table_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Admin_Homepage adminHomepage = new Admin_Homepage();
            adminHomepage.Show();
            this.Hide();

        }
        private void Form2_Load()
        {
            try
            {
                dbcon();
                SqlCommand sq1 = new SqlCommand("select ManagerID,Username,PhoneNumber,Email from Managers", con);
                SqlDataAdapter sda = new SqlDataAdapter(sq1);
                DataTable dt = new DataTable();

                sda.Fill(dt);
                dataGridView1.RowTemplate.Height = 50;
                dataGridView1.DataSource = dt;
                //DataGridViewImageColumn img = new DataGridViewImageColumn();
                //img = (DataGridViewImageColumn)dataGridView1.Columns[6];
                //img.ImageLayout = DataGridViewImageCellLayout.Stretch;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load Table " + ex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                personID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                personName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                personPhone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                personGmail.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid data " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_insert_manager admin_Insert_Manager = new Admin_insert_manager();
            admin_Insert_Manager.Show();
            this.Hide();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (updateBtn.Text == "Edit")
            {
                if (string.IsNullOrWhiteSpace(personID.Text))
                {
                    MessageBox.Show("Please Select a Product");
                    return;
                }
                else
                {
                    updateBtn.Text = "Update";
                    personName.ReadOnly = false;
                    personPhone.ReadOnly = false;
                    personGmail.ReadOnly = false;


                }
            }
            else if (updateBtn.Text == "Update")
            {
                updateBtn.Text = "Edit";
                personName.ReadOnly = true;
                personPhone.ReadOnly = true;
                personGmail.ReadOnly = true;


            }
            try
            {
                dbcon();
                SqlCommand sq2 = new SqlCommand("UPDATE Managers SET Name = @Name, Phone = @Phone, Gmail = @Gmail, ProfileImage = @Image WHERE ManagerID = @PersonID", con);

                sq2.Parameters.AddWithValue("@personID", personID.Text); // Assuming Phone is being used as an identifier
                sq2.Parameters.AddWithValue("@Name", personName.Text);
                sq2.Parameters.AddWithValue("@Phone", personPhone.Text);
                sq2.Parameters.AddWithValue("@Gmail", personGmail.Text);

                MemoryStream memstr = new MemoryStream();
                // gameImage.Image.Save(memstr, gameImage.Image.RawFormat);
                sq2.Parameters.AddWithValue("@Image", memstr.ToArray());

                sq2.ExecuteNonQuery();
                con.Close();

                personName.Text = "";
                personPhone.Text = "";
                personGmail.Text = "";

                MessageBox.Show("Updated Successfully");
                Form2_Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dbcon();
                SqlCommand sq1 = new SqlCommand("DELETE from Managers WHERE ManagerID = @PersonID ", con);
                sq1.Parameters.AddWithValue("@PersonID", int.Parse(personID.Text));
                sq1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Product DELETED");
                Form2_Load();
                personID.Text = string.Empty;
                personName.Text = string.Empty;
                personPhone.Text = string.Empty;
                personGmail.Text = string.Empty;

            }
            catch (Exception ex) { MessageBox.Show("No manager Found. " + ex.Message); }
        }
    }
}
