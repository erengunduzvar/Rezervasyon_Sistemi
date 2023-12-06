namespace Rezervasyon_Sistemi.Forms
{
    partial class ChooseTrip
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.availableTripDataGrid = new System.Windows.Forms.DataGridView();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TripId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TripDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tripRoute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buySeat = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.availableTripDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // availableTripDataGrid
            // 
            this.availableTripDataGrid.AllowUserToDeleteRows = false;
            this.availableTripDataGrid.AllowUserToOrderColumns = true;
            this.availableTripDataGrid.AllowUserToResizeColumns = false;
            this.availableTripDataGrid.AllowUserToResizeRows = false;
            this.availableTripDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.availableTripDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.availableTripDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.availableTripDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyName,
            this.TripId,
            this.TripDate,
            this.AvailableSeats,
            this.tripRoute,
            this.VehicleType,
            this.buySeat});
            this.availableTripDataGrid.Location = new System.Drawing.Point(115, 38);
            this.availableTripDataGrid.Name = "availableTripDataGrid";
            this.availableTripDataGrid.ReadOnly = true;
            this.availableTripDataGrid.RowHeadersVisible = false;
            this.availableTripDataGrid.Size = new System.Drawing.Size(702, 487);
            this.availableTripDataGrid.TabIndex = 0;
            this.availableTripDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.availableTripDataGrid_CellClick);
            this.availableTripDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.availableTripDataGrid_CellContentClick);
            // 
            // companyName
            // 
            this.companyName.HeaderText = "Firma İsmi";
            this.companyName.Name = "companyName";
            this.companyName.ReadOnly = true;
            // 
            // TripId
            // 
            this.TripId.HeaderText = "Araç Numarası";
            this.TripId.Name = "TripId";
            this.TripId.ReadOnly = true;
            // 
            // TripDate
            // 
            this.TripDate.HeaderText = "Hareket Tarihi";
            this.TripDate.Name = "TripDate";
            this.TripDate.ReadOnly = true;
            // 
            // AvailableSeats
            // 
            this.AvailableSeats.HeaderText = "Müsait Koltuk Sayısı";
            this.AvailableSeats.Name = "AvailableSeats";
            this.AvailableSeats.ReadOnly = true;
            // 
            // tripRoute
            // 
            this.tripRoute.HeaderText = "Istikamet";
            this.tripRoute.Name = "tripRoute";
            this.tripRoute.ReadOnly = true;
            // 
            // VehicleType
            // 
            this.VehicleType.HeaderText = "Araç Tipi";
            this.VehicleType.Name = "VehicleType";
            this.VehicleType.ReadOnly = true;
            // 
            // buySeat
            // 
            this.buySeat.HeaderText = "Satın Al";
            this.buySeat.Name = "buySeat";
            this.buySeat.ReadOnly = true;
            // 
            // ChooseTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 587);
            this.Controls.Add(this.availableTripDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseTrip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseTrip";
            this.Load += new System.EventHandler(this.ChooseTrip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.availableTripDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView availableTripDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableSeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripRoute;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleType;
        private System.Windows.Forms.DataGridViewButtonColumn buySeat;
    }
}