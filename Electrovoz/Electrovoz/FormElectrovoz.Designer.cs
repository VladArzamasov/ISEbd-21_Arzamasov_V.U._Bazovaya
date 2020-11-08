namespace Electrovoz
{
    partial class FormElectrovoz
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.pictureBoxElektrovoz = new System.Windows.Forms.PictureBox();
            this.buttonCreateLocomotive = new System.Windows.Forms.Button();
            this.buttonCreateElectrovoz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxElektrovoz)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::Electrovoz.Properties.Resources.стрелка_вектор_png_11;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(774, 371);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 5;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::Electrovoz.Properties.Resources.стрелка_вектор_png_1;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(810, 344);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::Electrovoz.Properties.Resources.стрелка_вектор_png_12;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(738, 344);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::Electrovoz.Properties.Resources.стрелка_вектор_png_13;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(774, 317);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // pictureBoxElektrovoz
            // 
            this.pictureBoxElektrovoz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxElektrovoz.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxElektrovoz.Name = "pictureBoxElektrovoz";
            this.pictureBoxElektrovoz.Size = new System.Drawing.Size(878, 444);
            this.pictureBoxElektrovoz.TabIndex = 0;
            this.pictureBoxElektrovoz.TabStop = false;
            // 
            // buttonCreateLocomotive
            // 
            this.buttonCreateLocomotive.Location = new System.Drawing.Point(12, 12);
            this.buttonCreateLocomotive.Name = "buttonCreateLocomotive";
            this.buttonCreateLocomotive.Size = new System.Drawing.Size(192, 32);
            this.buttonCreateLocomotive.TabIndex = 6;
            this.buttonCreateLocomotive.Text = "Создать локомотив";
            this.buttonCreateLocomotive.UseVisualStyleBackColor = true;
            this.buttonCreateLocomotive.Click += new System.EventHandler(this.buttonCreateLocomotive_Click);
            // 
            // buttonCreateElectrovoz
            // 
            this.buttonCreateElectrovoz.Location = new System.Drawing.Point(210, 12);
            this.buttonCreateElectrovoz.Name = "buttonCreateElectrovoz";
            this.buttonCreateElectrovoz.Size = new System.Drawing.Size(192, 32);
            this.buttonCreateElectrovoz.TabIndex = 7;
            this.buttonCreateElectrovoz.Text = "Создать электровоз";
            this.buttonCreateElectrovoz.UseVisualStyleBackColor = true;
            this.buttonCreateElectrovoz.Click += new System.EventHandler(this.buttonCreateElectrovoz_Click);
            // 
            // FormElectrovoz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 444);
            this.Controls.Add(this.buttonCreateElectrovoz);
            this.Controls.Add(this.buttonCreateLocomotive);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.pictureBoxElektrovoz);
            this.Name = "FormElectrovoz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Електровоз";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxElektrovoz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxElektrovoz;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonCreateLocomotive;
        private System.Windows.Forms.Button buttonCreateElectrovoz;
    }
}

