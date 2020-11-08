using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Electrovoz
{
    public class Depo<T> where T : class, ITransport
    {
        // Массив объектов, которые храним
        private readonly T[] _places;
        // Ширина окна отрисовки
        private readonly int pictureWidth;
        // Высота окна отрисовки
        private readonly int pictureHeight;
        // Размер депо (ширина)
        private readonly int _placeSizeWidth = 200;
        // Размер депо (высота)
        private readonly int _placeSizeHeight = 80;
        // Конструктор
        public Depo(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }
        // Перегрузка оператора сложения
        // Логика действия: в депо добавляется поезд
        public static bool operator +(Depo<T> p, T train)
        {
            for (int i = 0; i < p._places.Length; i++)
            {
                if (p._places[i] == null)
                {
                    p._places[i] = train;
                    p._places[i].SetPosition(i / 4 * p._placeSizeWidth + 7,
                        i % 4 * p._placeSizeHeight + 4, p.pictureWidth, p.pictureHeight);
                    return true;
                }
            }
            return false;
        }
        // Перегрузка оператора вычитания
        // Логика действия: из депо забираем поезд
        public static T operator - (Depo<T> p, int index)
        {
            if (index < 0 || index >= p._places.Length)
            {
                return null;
            }
            T train = p._places[index];
            p._places[index] = null;
            return train;
        }
        // Метод отрисовки депо
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawTransport(g);
            }
        }
        // Метод отрисовки разметки парковочных мест
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                   _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
               (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}
