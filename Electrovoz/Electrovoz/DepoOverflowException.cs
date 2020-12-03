using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrovoz
{
    // Класс-ошибка "Если в депо уже все места заняты"
    class DepoOverflowException : Exception
    {
        public DepoOverflowException() : base("В депо нет свободных мест")
        { }
    }
}
