using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrovoz
{
    public class TrainComparer : IComparer<Train>
    {
        public int Compare(Train x, Train y)
        {
            if (x is Electrovoz && y is Electrovoz)
            {
                return ComparerElectrovoz((Electrovoz)x, (Electrovoz)y);
            }
            if (x is Electrovoz && y is Locomotive)
            {
                return -1;
            }
            if (x is Locomotive && y is Electrovoz)
            {
                return 1;
            }
            if (x is Locomotive && y is Locomotive)
            {
                return ComparerTrain((Locomotive)x, (Locomotive)y);
            }
            return 0;
        }
        private int ComparerTrain(Locomotive x, Locomotive y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerElectrovoz(Electrovoz x, Electrovoz y)
        {
            var res = ComparerTrain(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.FrontRoga != y.FrontRoga)
            {
                return x.FrontRoga.CompareTo(y.FrontRoga);
            }
            if (x.FrontLightning != y.FrontLightning)
            {
                return x.FrontLightning.CompareTo(y.FrontLightning);
            }
            return 0;
        }
    }
}
