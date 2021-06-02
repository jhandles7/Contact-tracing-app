using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contact_tracing_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void detail_groupbox_Enter(object sender, EventArgs e)
        {

        }

       

        private void Save_btn_Click(object sender, EventArgs e)
        {
            
            StreamWriter ListFile;

            string date_today = DateTime.Now.ToLongDateString();
            ListFile = File.AppendText(date_today + ".txt");
            ListFile.WriteLine("=================================================");
            ListFile.WriteLine("First Name: " + Fname_txtbox.Text);
            ListFile.WriteLine("Last Name: " + Lname_txtbox.Text);
            ListFile.WriteLine("Age:" + age_txtbox.Text);
            ListFile.WriteLine("Adress: " + address_txtbox.Text);
            ListFile.WriteLine("Temperature: " + temp_txtbox.Text);

            ListFile.Close();

            Fname_txtbox.Text = "";
            Lname_txtbox.Text = "";

        }

        private void View_btn_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
