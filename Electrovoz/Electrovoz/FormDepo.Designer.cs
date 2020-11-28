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
            this.groupBoxZabor = new System.Windows.Forms.GroupBox();
            this.buttonZobr = new System.Windows.Forms.Button();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.pictureBoxDepo = new System.Windows.Forms.PictureBox();
            this.listBoxDepo = new System.Windows.Forms.ListBox();
            this.buttonUdalDepo = new System.Windows.Forms.Button();
            this.buttonDobavlDepo = new System.Windows.Forms.Button();
            this.textBoxNameDepo = new System.Windows.Forms.TextBox();
            this.labelDepo = new System.Windows.Forms.Label();
            this.buttonAddTrain = new System.Windows.Forms.Button();
            this.groupBoxZabor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxZabor
            // 
            this.groupBoxZabor.Controls.Add(this.buttonZobr);
            this.groupBoxZabor.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxZabor.Controls.Add(this.labelPlace);
            this.groupBoxZabor.Location = new System.Drawing.Point(679, 380);
            this.groupBoxZabor.Name = "groupBoxZabor";
            this.groupBoxZabor.Size = new System.Drawing.Size(145, 143);
            this.groupBoxZabor.TabIndex = 3;
            this.groupBoxZabor.TabStop = false;
            this.groupBoxZabor.Text = "Забрать поезд";
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
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(77, 45);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(41, 26);
            this.maskedTextBoxPlace.TabIndex = 1;
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
            // pictureBoxDepo
            // 
            this.pictureBoxDepo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxDepo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDepo.Name = "pictureBoxDepo";
            this.pictureBoxDepo.Size = new System.Drawing.Size(672, 523);
            this.pictureBoxDepo.TabIndex = 0;
            this.pictureBoxDepo.TabStop = false;
            // 
            // listBoxDepo
            // 
            this.listBoxDepo.FormattingEnabled = true;
            this.listBoxDepo.ItemHeight = 20;
            this.listBoxDepo.Location = new System.Drawing.Point(679, 96);
            this.listBoxDepo.Name = "listBoxDepo";
            this.listBoxDepo.Size = new System.Drawing.Size(136, 104);
            this.listBoxDepo.TabIndex = 4;
            this.listBoxDepo.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // buttonUdalDepo
            // 
            this.buttonUdalDepo.Location = new System.Drawing.Point(678, 206);
            this.buttonUdalDepo.Name = "buttonUdalDepo";
            this.buttonUdalDepo.Size = new System.Drawing.Size(135, 34);
            this.buttonUdalDepo.TabIndex = 5;
            this.buttonUdalDepo.Text = "Удалить депо";
            this.buttonUdalDepo.UseVisualStyleBackColor = true;
            this.buttonUdalDepo.Click += new System.EventHandler(this.buttonUdalDepo_Click);
            // 
            // buttonDobavlDepo
            // 
            this.buttonDobavlDepo.Location = new System.Drawing.Point(679, 59);
            this.buttonDobavlDepo.Name = "buttonDobavlDepo";
            this.buttonDobavlDepo.Size = new System.Drawing.Size(136, 31);
            this.buttonDobavlDepo.TabIndex = 6;
            this.buttonDobavlDepo.Text = "Добавить депо";
            this.buttonDobavlDepo.UseVisualStyleBackColor = true;
            this.buttonDobavlDepo.Click += new System.EventHandler(this.buttonDobavlDepo_Click);
            // 
            // textBoxNameDepo
            // 
            this.textBoxNameDepo.Location = new System.Drawing.Point(679, 27);
            this.textBoxNameDepo.Name = "textBoxNameDepo";
            this.textBoxNameDepo.Size = new System.Drawing.Size(136, 26);
            this.textBoxNameDepo.TabIndex = 7;
            // 
            // labelDepo
            // 
            this.labelDepo.AutoSize = true;
            this.labelDepo.Location = new System.Drawing.Point(679, 0);
            this.labelDepo.Name = "labelDepo";
            this.labelDepo.Size = new System.Drawing.Size(52, 20);
            this.labelDepo.TabIndex = 8;
            this.labelDepo.Text = "Депо:";
            // 
            // buttonAddTrain
            // 
            this.buttonAddTrain.Location = new System.Drawing.Point(678, 278);
            this.buttonAddTrain.Name = "buttonAddTrain";
            this.buttonAddTrain.Size = new System.Drawing.Size(144, 56);
            this.buttonAddTrain.TabIndex = 9;
            this.buttonAddTrain.Text = "Добавить поезд";
            this.buttonAddTrain.UseVisualStyleBackColor = true;
            this.buttonAddTrain.Click += new System.EventHandler(this.buttonAddTrain_Click);
            // 
            // FormDepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 523);
            this.Controls.Add(this.buttonAddTrain);
            this.Controls.Add(this.labelDepo);
            this.Controls.Add(this.textBoxNameDepo);
            this.Controls.Add(this.buttonDobavlDepo);
            this.Controls.Add(this.buttonUdalDepo);
            this.Controls.Add(this.listBoxDepo);
            this.Controls.Add(this.groupBoxZabor);
            this.Controls.Add(this.pictureBoxDepo);
            this.Name = "FormDepo";
            this.Text = "Депо";
            this.groupBoxZabor.ResumeLayout(false);
            this.groupBoxZabor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDepo;
        private System.Windows.Forms.GroupBox groupBoxZabor;
        private System.Windows.Forms.Button buttonZobr;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.ListBox listBoxDepo;
        private System.Windows.Forms.Button buttonUdalDepo;
        private System.Windows.Forms.Button buttonDobavlDepo;
        private System.Windows.Forms.TextBox textBoxNameDepo;
        private System.Windows.Forms.Label labelDepo;
        private System.Windows.Forms.Button buttonAddTrain;
    }
}