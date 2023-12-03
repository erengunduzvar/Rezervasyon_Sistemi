using Rezervasyon_Sistemi.Models;
using Rezervasyon_Sistemi.Models.Econ;
using Rezervasyon_Sistemi.Models.Infrastructure;
using Rezervasyon_Sistemi.Models.Vehicles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervasyon_Sistemi.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            
            InitializeComponent();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void kullanıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user_panel.Visible = true;
            admin_panel.Visible = false;
            firma_panel.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            firma_panel.Visible = false;
            admin_panel.Visible = true;
            user_panel.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user_panel.Visible = false;
            admin_panel.Visible = false;
            firma_panel.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        { //admin_ticket_click
            user_panel.Visible = true;
            admin_panel.Visible = false;
            firma_panel.Visible = false;
        }

        private void firma_ticket_Click(object sender, EventArgs e)
        {
            user_panel.Visible = true;
            admin_panel.Visible = false;
            firma_panel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(admin_username_text.Text,admin_password_text.Text);
            if(admin.Login(admin.username, admin.password))
            {
                new AdminForm().ShowDialog();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var company = new Company(textBox4.Text,textBox3.Text);
          
                if(company.Login(company.username, company.password))
                {
                    new CompanyForm().ShowDialog();
                }
            
        }

        private void testButton_Click(object sender, EventArgs e)
        {


        }
    }
}
