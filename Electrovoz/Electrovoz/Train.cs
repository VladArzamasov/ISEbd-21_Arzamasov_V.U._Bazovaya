using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Electrovoz
{
    public abstract class Train : ITransport
    {
        // Левая координата отрисовки поезда
        protected float _startPosX;
        // Правая кооридната отрисовки поезда
        protected float _startPosY;
        // Ширина окна отрисовки
        protected int _pictureWidth;
        // Высота окна отрисовки
        protected int _pictureHeight;
        // Максимальная скорость
        public int MaxSpeed { protected set; get; }
        // Вес
        public float Weight { protected set; get; }
        // Основной цвет
        public Color MainColor { protected set; get; }
        public void SetMainColor(Color color)
        {
            MainColor = color;
        }
        public void SetPosition(int x, int y, int width, int height)
        {
            _pictureWidth = width;
            _pictureHeight = height;
            _startPosX = x;
            _startPosY = y;
        }
        public abstract void DrawTransport(Graphics g);
        public abstract void MoveTransport(Direction direction);
    }
}
