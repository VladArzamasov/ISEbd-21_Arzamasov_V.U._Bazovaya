using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electrovoz
{
    public partial class FormElectrovozConfig : Form
    {
        Train train = null;
        private event Action<Train> eventAddTrain;
        public FormElectrovozConfig()
        {
            InitializeComponent();
            panelRed.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlack.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        private void DrawTrain()
        {
            if (train != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxElectrovoz.Width, pictureBoxElectrovoz.Height);
                Graphics gr = Graphics.FromImage(bmp);
                train.SetPosition(5, 5, pictureBoxElectrovoz.Width, pictureBoxElectrovoz.Height);
                train.DrawTransport(gr);
                pictureBoxElectrovoz.Image = bmp;
            }
        }
        public void AddEvent(Action<Train> ev)
        {
            if (eventAddTrain == null)
            {
                eventAddTrain = new Action<Train>(ev);
            }
            else
            {
                eventAddTrain += ev;
            }
        }
        private void LabelLocomotive_MuseDown(object sender, MouseEventArgs e)
        {
            labelLocomotive.DoDragDrop(labelLocomotive.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void panelPicture_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Локомотив":
                    train = new Locomotive((int)numericUpDownSpeed.Value,
                        (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "Электровоз":
                    train = new Electrovoz((int)numericUpDownSpeed.Value,
                        (int)numericUpDownWeight.Value, Color.White, Color.Black, checkBoxRoga.Checked, checkBoxLightning.Checked);
                    break;
            }
            DrawTrain();
        }

        private void panelPicture_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelElectrovoz_MouseDown(object sender, MouseEventArgs e)
        {
            labelElectrovoz.DoDragDrop(labelElectrovoz.Text, DragDropEffects.Move | DragDropEffects.Copy);

        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            ((Panel)sender).DoDragDrop(((Panel)sender).BackColor, DragDropEffects.Move | DragDropEffects.Copy);

        }
        private void labelOsnColor_DragDrop(object sender, DragEventArgs e)
        {
            train?.SetMainColor((Color)(e.Data.GetData(typeof(Color))));
            DrawTrain();
        }

        private void labelOsnColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (train is Electrovoz)
            {
                Electrovoz electrovoz = (Electrovoz)train;

                electrovoz.SetDopColor((Color)(e.Data.GetData(typeof(Color))));
                DrawTrain();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddTrain?.Invoke(train);
            Close();
        }
    }
}
