using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Electrovoz
{
    public class Locomotive : Train
    {
        // Ширина отрисовки локомотива
        protected readonly int carWidth = 95;
        // Высота отрисовки локомотива
        protected readonly int carHeight = 68;
        // Конструктор
        public Locomotive(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        protected Locomotive(int maxSpeed, float weight, Color mainColor, int carWidth, int carHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.carWidth = carWidth;
            this.carHeight = carHeight;
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            int leftPosX = 5;  // левая граница
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > leftPosX)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            //передняя фара
            Brush brYellow = new SolidBrush(Color.Yellow);
            g.FillEllipse(brYellow, _startPosX + 85, _startPosY + 43, 10, 10);

            //задняя фара
            Brush brRed = new SolidBrush(Color.Red);
            g.FillEllipse(brRed, _startPosX - 5, _startPosY + 43, 10, 10);


            //границы электровоза
            g.DrawRectangle(pen, _startPosX, _startPosY + 18, 90, 30); // верх. часть
            g.DrawRectangle(pen, _startPosX, _startPosY + 48, 90, 10); // ниж.часть
            g.DrawEllipse(pen, _startPosX + 85, _startPosY + 43, 10, 10); // пер. фара
            g.DrawEllipse(pen, _startPosX - 5, _startPosY + 43, 10, 10); // зад. фара
            //окна
            g.DrawRectangle(pen, _startPosX + 5, _startPosY + 23, 7, 7);
            g.DrawRectangle(pen, _startPosX + 20, _startPosY + 23, 7, 7);
            g.DrawRectangle(pen, _startPosX + 70, _startPosY + 18, 20, 15);
            // дверь
            g.DrawRectangle(pen, _startPosX + 45, _startPosY + 28, 15, 20);
            //колеса
            g.DrawEllipse(pen, _startPosX + 4, _startPosY + 58, 10, 10);
            g.DrawEllipse(pen, _startPosX + 19, _startPosY + 58, 10, 10);
            g.DrawEllipse(pen, _startPosX + 34, _startPosY + 58, 10, 10);
            g.DrawEllipse(pen, _startPosX + 49, _startPosY + 58, 10, 10);
            g.DrawEllipse(pen, _startPosX + 64, _startPosY + 58, 10, 10);
            g.DrawEllipse(pen, _startPosX + 79, _startPosY + 58, 10, 10);

            //кузов
            Brush br = new SolidBrush(MainColor);
            g.FillRectangle(br, _startPosX + 1, _startPosY + 19, 89, 29);
            g.FillRectangle(br, _startPosX + 1, _startPosY + 49, 89, 9);

            //стекла
            Brush brBlue = new SolidBrush(Color.LightBlue);
            g.FillRectangle(brBlue, _startPosX + 5, _startPosY + 23, 7, 7);
            g.FillRectangle(brBlue, _startPosX + 20, _startPosY + 23, 7, 7);
            g.FillRectangle(brBlue, _startPosX + 70, _startPosY + 18, 21, 15);

            //колеса
            Brush kolesa = new SolidBrush(Color.Gray);
            g.FillEllipse(kolesa, _startPosX + 4, _startPosY + 58, 10, 10);
            g.FillEllipse(kolesa, _startPosX + 19, _startPosY + 58, 10, 10);
            g.FillEllipse(kolesa, _startPosX + 34, _startPosY + 58, 10, 10);
            g.FillEllipse(kolesa, _startPosX + 49, _startPosY + 58, 10, 10);
            g.FillEllipse(kolesa, _startPosX + 64, _startPosY + 58, 10, 10);
            g.FillEllipse(kolesa, _startPosX + 79, _startPosY + 58, 10, 10);

            //выделяем рамкой дверь
            g.DrawRectangle(pen, _startPosX + 45, _startPosY + 28, 15, 20);
        }
    }
}
