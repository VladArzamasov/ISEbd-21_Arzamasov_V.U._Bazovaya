using System;
using System.Drawing;

namespace Electrovoz
{
    public class Electrovoz : Locomotive
    {
        // Дополнительный цвет
        public Color DopColor { private set; get; }
        // Признак наличия рогов
        public bool FrontRoga { private set; get; }
        // Признак наличия молнии
        public bool FrontLightning { private set; get; }
        // Конструктор
        public Electrovoz(int maxSpeed, float weight, Color mainColor, Color dopColor,
       bool frontRoga, bool frontLightning) : base(maxSpeed, weight, mainColor, 95, 68)
        {
            DopColor = dopColor;
            FrontRoga = frontRoga;
            FrontLightning = frontLightning;
        }
        // Отрисовка автомобиля
        public override void DrawTransport(Graphics g)
        {
            //отрисуем локомотив
            base.DrawTransport(g);
            // рога
            if (FrontRoga)
            {
                Pen roga = new Pen(DopColor, 2);
                // рог №1
                g.DrawLine(roga, _startPosX + 5, _startPosY + 17, _startPosX + 10, _startPosY + 7);
                g.DrawLine(roga, _startPosX + 15, _startPosY + 17, _startPosX + 10, _startPosY + 7);
                g.DrawLine(roga, _startPosX + 5, _startPosY + 4, _startPosX + 10, _startPosY + 7);
                g.DrawLine(roga, _startPosX + 15, _startPosY + 4, _startPosX + 10, _startPosY + 7);
                g.DrawLine(roga, _startPosX + 5, _startPosY + 4, _startPosX + 10, _startPosY);
                g.DrawLine(roga, _startPosX + 15, _startPosY + 4, _startPosX + 10, _startPosY);
                // рог №2
                g.DrawLine(roga, _startPosX + 32, _startPosY + 17, _startPosX + 37, _startPosY + 7);
                g.DrawLine(roga, _startPosX + 42, _startPosY + 17, _startPosX + 37, _startPosY + 7);
                g.DrawLine(roga, _startPosX + 32, _startPosY + 4, _startPosX + 37, _startPosY + 7);
                g.DrawLine(roga, _startPosX + 42, _startPosY + 4, _startPosX + 37, _startPosY + 7);
                g.DrawLine(roga, _startPosX + 32, _startPosY + 4, _startPosX + 37, _startPosY);
                g.DrawLine(roga, _startPosX + 42, _startPosY + 4, _startPosX + 37, _startPosY);
                // рог №3
                g.DrawLine(roga, _startPosX + 55, _startPosY + 17, _startPosX + 60, _startPosY + 7);
                g.DrawLine(roga, _startPosX + 65, _startPosY + 17, _startPosX + 60, _startPosY + 7);
                g.DrawLine(roga, _startPosX + 55, _startPosY + 4, _startPosX + 60, _startPosY + 7);
                g.DrawLine(roga, _startPosX + 65, _startPosY + 4, _startPosX + 60, _startPosY + 7);
                g.DrawLine(roga, _startPosX + 55, _startPosY + 4, _startPosX + 60, _startPosY);
                g.DrawLine(roga, _startPosX + 65, _startPosY + 4, _startPosX + 60, _startPosY);
            }
            // молния
            if (FrontLightning)
            {
                Pen molniya = new Pen(DopColor, 2);
                g.DrawLine(molniya, _startPosX + 15, _startPosY + 30, _startPosX + 10, _startPosY + 43);
                g.DrawLine(molniya, _startPosX + 10, _startPosY + 43, _startPosX + 15, _startPosY + 40);
                g.DrawLine(molniya, _startPosX + 15, _startPosY + 40, _startPosX + 10, _startPosY + 53);
            }
        }
    }
}
