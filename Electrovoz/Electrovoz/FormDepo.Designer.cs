namespace Electrovoz
{
    partial class FormDepo
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
            this.buttonParkingLocomotive = new System.Windows.Forms.Button();
            this.buttonParkingElectrovoz = new System.Windows.Forms.Button();
            this.groupBoxZabor = new System.Windows.Forms.GroupBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.buttonZobr = new System.Windows.Forms.Button();
            this.pictureBoxDepo = new System.Windows.Forms.PictureBox();
            this.groupBoxZabor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonParkingLocomotive
            // 
            this.buttonParkingLocomotive.Location = new System.Drawing.Point(678, 12);
            this.buttonParkingLocomotive.Name = "buttonParkingLocomotive";
            this.buttonParkingLocomotive.Size = new System.Drawing.Size(136, 55);
            this.buttonParkingLocomotive.TabIndex = 1;
            this.buttonParkingLocomotive.Text = "Припарковать локомотив";
            this.buttonParkingLocomotive.UseVisualStyleBackColor = true;
            this.buttonParkingLocomotive.Click += new System.EventHandler(this.buttonParkingLocomotive_Click);
            // 
            // buttonParkingElectrovoz
            // 
            this.buttonParkingElectrovoz.Location = new System.Drawing.Point(678, 73);
            this.buttonParkingElectrovoz.Name = "buttonParkingElectrovoz";
            this.buttonParkingElectrovoz.Size = new System.Drawing.Size(136, 58);
            this.buttonParkingElectrovoz.TabIndex = 2;
            this.buttonParkingElectrovoz.Text = "Припарковать электровоз";
            this.buttonParkingElectrovoz.UseVisualStyleBackColor = true;
            this.buttonParkingElectrovoz.Click += new System.EventHandler(this.buttonParkingElectrovoz_Click);
            // 
            // groupBoxZabor
            // 
            this.groupBoxZabor.Controls.Add(this.buttonZobr);
            this.groupBoxZabor.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxZabor.Controls.Add(this.labelPlace);
            this.groupBoxZabor.Location = new System.Drawing.Point(678, 158);
            this.groupBoxZabor.Name = "groupBoxZabor";
            this.groupBoxZabor.Size = new System.Drawing.Size(145, 143);
            this.groupBoxZabor.TabIndex = 3;
            this.groupBoxZabor.TabStop = false;
            this.groupBoxZabor.Text = "Забрать поезд";
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(14, 51);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(61, 20);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место:";
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(77, 45);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(41, 26);
            this.maskedTextBoxPlace.TabIndex = 1;
            // 
            // buttonZobr
            // 
            this.buttonZobr.Location = new System.Drawing.Point(18, 89);
            this.buttonZobr.Name = "buttonZobr";
            this.buttonZobr.Size = new System.Drawing.Size(100, 34);
            this.buttonZobr.TabIndex = 2;
            this.buttonZobr.Text = "Забрать";
            this.buttonZobr.UseVisualStyleBackColor = true;
            this.buttonZobr.Click += new System.EventHandler(this.buttonZobr_Click);
            // 
            // pictureBoxDepo
            // 
            this.pictureBoxDepo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxDepo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDepo.Name = "pictureBoxDepo";
            this.pictureBoxDepo.Size = new System.Drawing.Size(672, 510);
            this.pictureBoxDepo.TabIndex = 0;
            this.pictureBoxDepo.TabStop = false;
            // 
            // FormDepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 510);
            this.Controls.Add(this.groupBoxZabor);
            this.Controls.Add(this.buttonParkingElectrovoz);
            this.Controls.Add(this.buttonParkingLocomotive);
            this.Controls.Add(this.pictureBoxDepo);
            this.Name = "FormDepo";
            this.Text = "Депо";
            this.groupBoxZabor.ResumeLayout(false);
            this.groupBoxZabor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDepo;
        private System.Windows.Forms.Button buttonParkingLocomotive;
        private System.Windows.Forms.Button buttonParkingElectrovoz;
        private System.Windows.Forms.GroupBox groupBoxZabor;
        private System.Windows.Forms.Button buttonZobr;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Label labelPlace;
    }
}