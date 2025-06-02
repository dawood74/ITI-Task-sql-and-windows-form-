using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class course : Form
    {

        public course()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = APP.Getdata();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = APP.Getdata();

        }

        private void course_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = APP.Getdata();

            label6.Text = "track " + APP.Trackname;
            label11.Text = APP.CurrentUserName; 
            tbtrack.Text=APP.Trackname;
            tbphone.Text = APP.Phone;

            tbaddress.Text = APP.Address;




            welcome.Text = "Welcome, " + APP.CurrentUserName;
            byte[] imageData = APP.GetImageByUsername(APP.CurrentUserName);
            if (imageData != null)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(tbid.Text) && !string.IsNullOrWhiteSpace(tbname.Text))
            {

                if (APP.update(int.Parse(tbid.Text), tbname.Text) > 0)
                {
                    MessageBox.Show("success");
                    dataGridView1.DataSource = APP.Getdata();
                }
                else
                {

                    MessageBox.Show("Failed");

                }
            }

            else

            {
                MessageBox.Show("please enter data");



            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbid.Text) && !string.IsNullOrWhiteSpace(tbname.Text))
            {

                if (APP.Add(int.Parse(tbid.Text), tbname.Text) > 0)
                {
                    MessageBox.Show("success");
                    dataGridView1.DataSource = APP.Getdata();
                }
                else
                {

                    MessageBox.Show("Failed");

                }
            }

            else 

            {
                MessageBox.Show("please enter data");



            }
        }

        private void tbname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbid.Text) ) { 
            if (APP.Delete(int.Parse(tbid.Text)) > 0)
            {
                MessageBox.Show("success");
                dataGridView1.DataSource = APP.Getdata();
            }
            else
            {

                MessageBox.Show("Failed");

            }
        }
            else
            {

                MessageBox.Show("Enter an id to delete ");

            }


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int phone = 0;
            int.TryParse(tbphone.Text, out phone);

            byte[] imageData;
            using (MemoryStream ms = new MemoryStream())
            {
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageData = ms.ToArray();
            }

            if (APP.edit(phone, tbaddress.Text, tbtrack.Text, APP.CurrentUserName, imageData) > 0)
            {
                MessageBox.Show("Success");
            }
            else 
            {
                MessageBox.Show("Failed");
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if ( openFileDialog.ShowDialog()==DialogResult.OK)
                
            {
                pictureBox1.Image=new Bitmap(openFileDialog.FileName);
            
            }
        }
    }
}