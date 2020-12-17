using System;
using System.Drawing;

namespace Electrovoz
{
    public class Electrovoz : Locomotive, IEquatable<Electrovoz>
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
        // Конструктор для загрузки с файла
        public Electrovoz(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                FrontRoga = Convert.ToBoolean(strs[4]);
                FrontLightning = Convert.ToBoolean(strs[5]);
            }
        }

        // Отрисовка електровоза
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
        // Смена дополнительного цвета
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return
           $"{base.ToString()}{separator}{DopColor.Name}{separator}{FrontRoga}{separator}{FrontLightning}";
        }
        // Метод интерфейса IEquatable для класса Electrovoz
        public bool Equals(Electrovoz other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }
        // Перегрузка метода от object
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Electrovoz elecObj))
            {
                return false;
            }
            else
            {
                return Equals(elecObj);
            }
        }
    }
}
