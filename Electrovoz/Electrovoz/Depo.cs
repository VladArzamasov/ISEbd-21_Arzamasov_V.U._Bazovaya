using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Electrovoz
{
    public class Depo<T> : IEnumerator<T>, IEnumerable<T>
        where T : class, ITransport
    {
        // Массив объектов, которые храним
        private readonly List<T> _places;
        // Максимальное кол-во мест в депо
        private readonly int _maxCount;
        // Ширина окна отрисовки
        private readonly int pictureWidth;
        // Высота окна отрисовки
        private readonly int pictureHeight;
        // Размер депо (ширина)
        private readonly int _placeSizeWidth = 200;
        // Размер депо (высота)
        private readonly int _placeSizeHeight = 80;
        private int _currentIndex;
        public T Current => _places[_currentIndex];
        object IEnumerator.Current => _places[_currentIndex];
        // Конструктор
        public Depo(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
            _currentIndex = -1;
        }
        // Перегрузка оператора сложения
        // Логика действия: в депо добавляется поезд
        public static bool operator +(Depo<T> p, T train)
        {
            if (p._places.Count >= p._maxCount)
            {
                throw new DepoOverflowException();
            }
            if (p._places.Contains(train))
            {
                throw new DepoAlreadyHaveException();
            }
            p._places.Add(train);
            return true;
        }
        // Перегрузка оператора вычитания
        // Логика действия: из депо забираем поезд
        public static T operator -(Depo<T> p, int index)
        {
            if (index < -1 || index >= p._places.Count)
            {
                throw new DepoNotFoundException(index);
            }
            T train = p._places[index];
            p._places.RemoveAt(index);
            return train;
        }
        // Метод отрисовки депо
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; i++)
            {
                _places[i].SetPosition(2 + i / 4 * _placeSizeWidth + 5, i % 4 *
                    _placeSizeHeight + 4, pictureWidth, pictureHeight);
                _places[i].DrawTransport(g);
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
        // Функция получения элементы из списка
        public T GetNext(int index)
        {
            if (index < 0 || index >= _places.Count)
            {
                return null;
            }
            return _places[index];
        }
        // Сортировка поездов в депо
        public void Sort() => _places.Sort((IComparer<T>)new TrainComparer());
        // Метод интерфейса IEnumerator, вызываемый при удалении объекта
        public void Dispose()
        {
        }
        // Метод интерфейса IEnumerator для перехода к следующему элементу или началу коллекции
        public bool MoveNext()
        {
            _currentIndex++;
            return (_currentIndex < _places.Count);
        }
        // Метод интерфейса IEnumerator для сброса и возрата к началу коллекции
        public void Reset()
        {
            _currentIndex = -1;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        // Метод интерфейса IEnumerable 
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}
