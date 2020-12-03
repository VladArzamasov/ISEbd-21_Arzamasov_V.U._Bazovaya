using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrovoz
{
    // Класс-ошибка "Если не найден поезд по определенному месту"
    class DepoNotFoundException : Exception
    {
        public DepoNotFoundException(int i) : base("Не найден поезд по месту " + i)
        { }
    }
}
