using System;

namespace Electrovoz
{
    [Serializable]
    internal class DepogOccupiedPlaceException : Exception
    {
        public DepogOccupiedPlaceException() : base("Не удалось припарковать")
        {

        }
    }
}