using Rezervasyon_Sistemi.Identification;
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
            Admin admin = new Admin(admin_username_text.Text, admin_password_text.Text);
            if (admin.Login(admin.username, admin.password))
            {
                new AdminForm().ShowDialog();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var company in Data_Storage.companies)
            {
                if (company.Login(textBox4.Text, textBox3.Text))
                {
                    new CompanyForm(company.CompanyId).ShowDialog();
                    break;
                }
                    
            }

        }

        private void testButton_Click(object sender, EventArgs e)
        {
            int debugg = 4;

            //Data_Storage.openTransports[7].transferPoints.First.Value.reservedChairs[0] = new Reservation(new Passenger("is", "koc", Data_Storage.openTransports[7].transportId, "samet", "kayık"), 0, Data_Storage.openTransports[7].transportId);
            //Data_Storage.openTransports[7].transferPoints.First.Value.reservedChairs[3] = new Reservation(new Passenger("is", "koc", Data_Storage.openTransports[7].transportId, "eren", "gündüzvar"), 3, Data_Storage.openTransports[7].transportId);
            //var x = Data_Storage.openTransports[7].AnyTransportValid("is", "es", new DateTime(2023, 12, 4));
            int y = 3;

        }

        private void tripSearchButton_Click(object sender, EventArgs e)
        {
            int passangerNum = Convert.ToInt32(passangerCounterNum.Value);
            //new ChooseTrip(Data_Storage.openTransports,passangerNum ).Show();
            if (dateComboBox.SelectedIndex != -1 && endPosComboBox.SelectedIndex != -1 && startPosComboBox.SelectedIndex != -1 && vehicleTypeComboBox.SelectedIndex != -1)
            {
                string startPos = "", endPos = "";
                DateTime? date = null;
                switch (startPosComboBox.SelectedIndex)
                {
                    case 0:
                        startPos = "is";
                        break;
                    case 1:
                        startPos = "koc";
                        break;
                    case 2:
                        startPos = "bi";
                        break;
                    case 3:
                        startPos = "an";
                        break;
                    case 4:
                        startPos = "es";
                        break;
                    case 5:
                        startPos = "kon";
                        break;
                }
                switch (endPosComboBox.SelectedIndex)
                {
                    case 0:
                        endPos = "is";
                        break;
                    case 1:
                        endPos = "koc";
                        break;
                    case 2:
                        endPos = "bi";
                        break;
                    case 3:
                        endPos = "an";
                        break;
                    case 4:
                        endPos = "es";
                        break;
                    case 5:
                        endPos = "kon";
                        break;
                }
                switch (dateComboBox.SelectedIndex)
                {
                    case 0:
                        date = new DateTime(2023, 12, 4);
                        break;
                    case 1:
                        date = new DateTime(2023, 12, 5);
                        break;
                    case 2:
                        date = new DateTime(2023, 12, 6);
                        break;
                    case 3:
                        date = new DateTime(2023, 12, 7);
                        break;
                    case 4:
                        date = new DateTime(2023, 12, 8);
                        break;
                    case 5:
                        date = new DateTime(2023, 12, 9);
                        break;
                    case 6:
                        date = new DateTime(2023, 12, 10);
                        break;
                }


                var tempTranposrts = Data_Storage.openTransports.Where(t => t.route.cities.Contains(startPos)
                && t.route.cities.Contains(endPos) && t.trip.date.CompareTo(date.Value) == 0).ToList();


                List <Transport> choosedTransports = Data_Storage.openTransports.Where(t => t.route.cities.Contains(startPos) 
                && t.route.cities.Contains(endPos)&& t.trip.date.CompareTo(date.Value) == 0
                && t.AnyTransportValid(startPos,endPos,date.Value).Count >= passangerNum)
                    .ToList();

                switch (vehicleTypeComboBox.SelectedIndex)
                {
                    case 0:
                        choosedTransports = choosedTransports.Where(t => t.trip.VehicleType == VehicleType.Airplane).ToList();
                        break;
                    case 1:
                        choosedTransports = choosedTransports.Where(t => t.trip.VehicleType == VehicleType.Bus).ToList();
                        break;
                    case 2:
                        choosedTransports = choosedTransports.Where(t => t.trip.VehicleType == VehicleType.Train).ToList();
                        break;
                    default:
                        //Tüm liste
                        break;
                }

                new ChooseTrip(choosedTransports,passangerNum,startPos,endPos,date.Value).Show();
            }

        }
    }
}
