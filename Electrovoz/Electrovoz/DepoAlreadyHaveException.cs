using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrovoz
{
    /// Класс-ошибка "Если в депо уже есть поезд с такими же характеристиками"

    public class DepoAlreadyHaveException : Exception
    {
        public DepoAlreadyHaveException() : base("В депо уже есть такой поезд")
        { }
    }
}
