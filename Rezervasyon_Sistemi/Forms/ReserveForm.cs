using Rezervasyon_Sistemi.Identification;
using Rezervasyon_Sistemi.Models;
using Rezervasyon_Sistemi.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervasyon_Sistemi.Forms
{
    public partial class ReserveForm : Form
    {
        List<int> choosedButtons = new List<int>();
        int passengerCount;
        Transport transport;
        string startPos, endPos;
        DateTime date;
        
        public ReserveForm(Transport transport, string startPos, string endPos, DateTime dateTime,int passengerCount)
        {
            InitializeComponent();
            //Kişinin rotasındaki en dolu otobüs üzerinden randevu al
            //List<int> reservableSeats = transport.AnyTransportValid(startPos,endPos,dateTime);
            wantedSeatCountText.Text = "Bilet Sayısı: "+passengerCount.ToString();

            for (int i = 0; i < transport.seatCount; i++)
            {
                Button button = new Button();
                button.Text = $"{i}";
                button.Click += (sender, e) => Button_Click(i, button); // Düğmeye tıklandığında çağrılacak olayı belirle
                button.Anchor = System.Windows.Forms.AnchorStyles.None;
                button.AutoSize = true;
                button.BackgroundImage = global::Rezervasyon_Sistemi.Properties.Resources.seat;
                button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                button.Cursor = System.Windows.Forms.Cursors.Hand;
                button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                button.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
                button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                button.Location = new System.Drawing.Point(19, 5);
                button.Name = "button2";
                button.Padding = new System.Windows.Forms.Padding(3);
                button.Size = new System.Drawing.Size(71, 50);
                button.TabIndex = 1;
                button.UseVisualStyleBackColor = false;


                //closed seats
                
                var seatMatris =  transport.AnyTransportValid(startPos, endPos, dateTime);
                if(!seatMatris.Contains(i))
                {
                    button.BackColor = System.Drawing.Color.Coral;
                    button.Enabled = false;
                }
                else
                {
                    button.BackColor = System.Drawing.Color.Chartreuse;
                    button.Enabled = true;
                }


                tableLayoutPanel1.Controls.Add(button, (int)i % 5, (int)i / 5);
            }


            this.passengerCount = passengerCount;
            this.transport = transport;
            this.date = dateTime;
            this.startPos = startPos;
            this.endPos = endPos;

        }

        private void Button_Click(int i, Button button)
        {

            Console.WriteLine(i);
            if (button.BackColor == System.Drawing.Color.Chartreuse && choosedButtons.Count < passengerCount) //Acik butonu sec
            {
                button.BackColor = button.BackColor = System.Drawing.Color.LightSlateGray;
                choosedButtons.Add(int.Parse(button.Text));
                updateSeatText();

            }

            else
            {
                button.BackColor = System.Drawing.Color.Chartreuse;
                choosedButtons.Remove(int.Parse(button.Text));
                updateSeatText();
            }

        }

        private void updateSeatText()
        {
            choosedSeatsText.Text = "Seçili Koltuklar:";
            foreach (var buttonId in choosedButtons)
            {
                choosedSeatsText.Text = $"{choosedSeatsText.Text}-{buttonId}";
            }

        }

        private void ReserveForm_Load(object sender, EventArgs e)
        {

        }

        private void buySeats_Click(object sender, EventArgs e)
        {
            if (choosedButtons.Count == passengerCount)
            {
                string successText = "Seçili Koltuklar: ";
                foreach (var seatNum in choosedButtons)
                    successText = $"{successText}{seatNum}, ";
                //sonunu kırp
                successText = successText.Substring(0, successText.Length - 1) + "\n";
                successText = successText + "Seçilen Sefer Numarası: "+transport.trip.tripId + "\n";
                successText = successText + "Rota: " + ServiceClass.cityShortcutToFullName(startPos)+"-"+ServiceClass.cityShortcutToFullName(endPos);



                new PassengerRegister(startPos, endPos, choosedButtons, transport,successText).Show();
                this.Close();
            }
            
            
        }
    }
}
