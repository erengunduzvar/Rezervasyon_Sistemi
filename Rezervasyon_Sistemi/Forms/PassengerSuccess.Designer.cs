namespace Rezervasyon_Sistemi.Forms
{
    partial class PassengerSuccess
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
            this.successTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // successTextBox
            // 
            this.successTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.successTextBox.Location = new System.Drawing.Point(27, 8);
            this.successTextBox.Name = "successTextBox";
            this.successTextBox.ReadOnly = true;
            this.successTextBox.Size = new System.Drawing.Size(251, 96);
            this.successTextBox.TabIndex = 0;
            this.successTextBox.Text = "";
            // 
            // PassengerSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 116);
            this.Controls.Add(this.successTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PassengerSuccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biletleme Başarılı";
            this.Load += new System.EventHandler(this.PassengerSuccess_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox successTextBox;
    }
}