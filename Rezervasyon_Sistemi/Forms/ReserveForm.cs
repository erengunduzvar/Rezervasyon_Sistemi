using Rezervasyon_Sistemi.Identification;
using Rezervasyon_Sistemi.Models;
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
    public partial class ReserveForm : Form
    {
        List<System.Windows.Forms.Button> buttonList;
        public ReserveForm(Transport transport, string startPos, string endPos, DateTime dateTime)
        {
            //Kişinin rotasındaki en dolu otobüs üzerinden randevu al
            List<int> reservableSeats = transport.AnyTransportValid(startPos,endPos,dateTime);

            InitializeComponent();
        }
    }
}
