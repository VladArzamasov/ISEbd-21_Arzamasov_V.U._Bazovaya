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
                    electrvoz.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    electrvoz.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    electrvoz.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    electrvoz.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
        // Обработка нажатия кнопки "Создать локомотив"
        private void buttonCreateLocomotive_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            electrvoz = new Locomotive(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Green);
            electrvoz.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxElektrovoz.Width,
           pictureBoxElektrovoz.Height);
            Draw();
        }
        // Обработка нажатия кнопки "Создать электровоз"
        private void buttonCreateElectrovoz_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            electrvoz = new Electrovoz(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Green, Color.Yellow, true, true);
            electrvoz.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxElektrovoz.Width, pictureBoxElektrovoz.Height);
            Draw();
        }
    }
}
