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
    public partial class FormElectrovoz : Form
    {
        private ITransport electrvoz;
        public FormElectrovoz()
        {
            InitializeComponent();
        }
        // Передача поезда на форму
        public void SetTrain(ITransport electrvoz)
        {
            this.electrvoz = electrvoz;
            Draw();
        }
        // Метод отрисовки электровоза
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxElektrovoz.Width, pictureBoxElektrovoz.Height);
            Graphics gr = Graphics.FromImage(bmp);
            electrvoz.DrawTransport(gr);
            pictureBoxElektrovoz.Image = bmp;
        }
        // Обработка нажатия кнопок управления
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    electrvoz?.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    electrvoz?.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    electrvoz?.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    electrvoz?.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
