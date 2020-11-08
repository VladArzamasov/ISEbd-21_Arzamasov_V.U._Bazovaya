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
    public partial class FormDepo : Form
    {
        // Объект от класса-депо
        private readonly Depo<Locomotive> depo;
        public FormDepo()
        {
            InitializeComponent();
            depo = new Depo<Locomotive>(pictureBoxDepo.Width, pictureBoxDepo.Height);
            Draw();
        }
        // Метод отрисовки депо
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxDepo.Width, pictureBoxDepo.Height);
            Graphics gr = Graphics.FromImage(bmp);
            depo.Draw(gr);
            pictureBoxDepo.Image = bmp;
        }
        // Обработка нажатия кнопки "Припарковать локомотив"
        private void buttonParkingLocomotive_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var locomotiv = new Locomotive(100, 1000, dialog.Color);
                if (depo + locomotiv)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Депо переполнено");
                }
            }
        }
        // Обработка нажатия кнопки "Припарковать електровоз"
        private void buttonParkingElectrovoz_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var train = new Electrovoz(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    if (depo + train)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Депо переполнено");
                    }
                }
            }
        }
        // Обработка нажатия кнопки "Забрать"
        private void buttonZobr_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPlace.Text != "")
            {
                var train = depo - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (train != null)
                {
                    FormElectrovoz form = new FormElectrovoz();
                    form.SetTrain(train);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
