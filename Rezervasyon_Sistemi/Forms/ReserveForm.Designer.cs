namespace Rezervasyon_Sistemi.Forms
{
    partial class ReserveForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buySeats = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.choosedSeatsText = new System.Windows.Forms.Label();
            this.wantedSeatCountText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(2, 2);
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(134, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(545, 366);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buySeats
            // 
            this.buySeats.BackColor = System.Drawing.Color.LightGreen;
            this.buySeats.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buySeats.Location = new System.Drawing.Point(693, 407);
            this.buySeats.Name = "buySeats";
            this.buySeats.Size = new System.Drawing.Size(95, 31);
            this.buySeats.TabIndex = 1;
            this.buySeats.Text = "Satın AL";
            this.buySeats.UseVisualStyleBackColor = false;
            this.buySeats.Click += new System.EventHandler(this.buySeats_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yeşil : Boş. Kırmızı : Dolu  Seçilen : Gri";
            // 
            // choosedSeatsText
            // 
            this.choosedSeatsText.AutoSize = true;
            this.choosedSeatsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.choosedSeatsText.Location = new System.Drawing.Point(424, 425);
            this.choosedSeatsText.Name = "choosedSeatsText";
            this.choosedSeatsText.Size = new System.Drawing.Size(79, 13);
            this.choosedSeatsText.TabIndex = 4;
            this.choosedSeatsText.Text = "Seçili Koltuklar:";
            // 
            // wantedSeatCountText
            // 
            this.wantedSeatCountText.AutoSize = true;
            this.wantedSeatCountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.wantedSeatCountText.Location = new System.Drawing.Point(12, 33);
            this.wantedSeatCountText.Name = "wantedSeatCountText";
            this.wantedSeatCountText.Size = new System.Drawing.Size(60, 13);
            this.wantedSeatCountText.TabIndex = 5;
            this.wantedSeatCountText.Text = "Bilet Sayısı:";
            // 
            // ReserveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wantedSeatCountText);
            this.Controls.Add(this.choosedSeatsText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buySeats);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReserveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Koltuk Seçimi";
            this.Load += new System.EventHandler(this.ReserveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buySeats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label choosedSeatsText;
        private System.Windows.Forms.Label wantedSeatCountText;
    }
}