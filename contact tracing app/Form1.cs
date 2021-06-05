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
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void detail_groupbox_Enter(object sender, EventArgs e)
        {

        }

       

        private void Save_btn_Click(object sender, EventArgs e)
        {
            
            StreamWriter ListFile;

            string date_today = DateTime.Now.ToLongDateString();
            string time_enter = DateTime.Now.ToString("h:mm tt");

            ListFile = File.AppendText(date_today + ".txt");
            ListFile.WriteLine("================" + time_enter + "===================");
            ListFile.WriteLine("First Name: " + Fname_txtbox.Text);
            ListFile.WriteLine("Last Name: " + Lname_txtbox.Text);
            ListFile.WriteLine("Age:" + age_num_up_down.Value.ToString());
            ListFile.WriteLine("Contact Number: " + number_txtbox.Text);
            ListFile.WriteLine("Adress: " + address_txtbox.Text);
            ListFile.WriteLine("Temperature: " + temp_txtbox.Text);

            ListFile.Close();

            Fname_txtbox.Text = "";
            Lname_txtbox.Text = "";
            age_num_up_down.Value = 0;
            number_txtbox.Text = "";
            address_txtbox.Text = "";
            temp_txtbox.Text = "";

        }

        private void View_btn_Click(object sender, EventArgs e)
        {
            Form2 listform = new Form2();
            listform.Show();

            string selected_date = select_calendar.Value.ToLongDateString();

            try
            {
                StreamReader inputfile;
                inputfile = File.OpenText(selected_date + ".txt");
                while (!inputfile.EndOfStream)
                {
                    Form2.instance.cust_listbx.Items.Add(inputfile.ReadLine());
                }
            }
            catch (Exception)
            {
                Form2.instance.cust_listbx.Items.Add("No Available Data for " + selected_date);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
