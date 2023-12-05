using Rezervasyon_Sistemi.Identification;
using Rezervasyon_Sistemi.Models.Infrastructure;
using Rezervasyon_Sistemi.Services;
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
    public partial class ChooseTrip : Form
    {
        List<Transport> TransportList;
        int passengerCount;
        string startPos;
        string endPos;
        DateTime date;
        public ChooseTrip(List<Transport> Transports,int passengerCount,string startPos,string endPos,DateTime date)
        {
            this.TransportList = Transports;
            this.passengerCount = passengerCount;
            this.startPos = startPos;
            this.endPos = endPos;
            this.date = date;
            InitializeComponent();
        }

        private void ChooseTrip_Load(object sender, EventArgs e)
        {
            foreach (var transp in TransportList)
            { //Kalan koltuk sayısının dinamizmini hesaplamak
                availableTripDataGrid.Rows.Add(transp.transportId.ToString(), transp.trip.date.ToShortDateString(),transp.AnyTransportValid(startPos,endPos,date).Count, $"{Services.Services.cityShortcutToFullName(transp.route.startPosition)} - {Services.Services.cityShortcutToFullName(transp.route.endPosition)}",transp.trip.VehicleType.ToString(), "Satın Al");
            }
            availableTripDataGrid.Columns[5].DefaultCellStyle.BackColor = Color.Green;
        }

        private void availableTripDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                int tripId = int.Parse(availableTripDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }
    }
}
