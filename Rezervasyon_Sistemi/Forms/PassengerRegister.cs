using Rezervasyon_Sistemi.Identification;
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
    public partial class PassengerRegister : Form
    {
        public Transport transport { get; set; }
        public string startPos { get; set; }
        public string _text { get; set; }
        public string endPos { get; set; }
        public List<int> choosedButtons { get; set; }
        public int seatNum { get => choosedButtons[0]; }
        public PassengerRegister(string startPos, string endPos, List<int> choosedButtons,Transport _transport,string _text)
        {
            InitializeComponent();
            this.startPos = startPos;
            this.endPos = endPos;
            this.choosedButtons = choosedButtons;
            this.transport = _transport;
            this._text = _text;

            this.Text = "Kayıt Ol " + this.seatNum.ToString();
            this.seatNoText.Text = this.seatNum.ToString();

        }

        private void FinalizeTicketButton_Click(object sender, EventArgs e)
        {
            if (nameText.Text.Length != 0 && surnameText.Text.Length != 0 && tcNoText.Text.Length == 11)
            {
                transport.reserveSeat(new Passenger(this.startPos, this.endPos, this.transport.transportId, nameText.Text, surnameText.Text, tcNoText.Text, dateText.Value), this.startPos, this.endPos, seatNum);
                choosedButtons.Remove(seatNum);
                if (choosedButtons.Count != 0)
                {
                    new PassengerRegister(startPos, endPos, choosedButtons, transport,_text).Show();
                    this.Close();
                }
                else
                {
                    new PassengerSuccess(_text).Show();
                    this.Close();
                }
            }



        }

        private void PassengerRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
