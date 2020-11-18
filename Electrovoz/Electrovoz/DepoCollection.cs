using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrovoz
{
    public class DepoCollection
    {
        // Словарь (хранилище) с депо
        readonly Dictionary<string, Depo<Train>> depoStages;
        // Возвращение списка названий депо
        public List<string> Keys => depoStages.Keys.ToList();
        // Ширина окна отрисовки
        private readonly int pictureWidth;
        // Высота окна отрисовки
        private readonly int pictureHeight;
        // Конструктор
        public DepoCollection(int pictureWidth, int pictureHeight)
        {
            depoStages = new Dictionary<string, Depo<Train>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        // Добавление депо
        public void AddDepo(string name)
        {
            if (depoStages.ContainsKey(name))
            {
                return;
            }
            depoStages.Add(name, new Depo<Train>(pictureWidth, pictureHeight));
        }
        // Удаление депо
        public void DelDepo(string name)
        {
            if (depoStages.ContainsKey(name))
            {
                depoStages.Remove(name);
            }
        }
        // Доступ к депо
        public Depo<Train> this[string ind]
        {
            get
            {
                if (depoStages.ContainsKey(ind))
                    return depoStages[ind];
                else
                    return null;
            }
        }
    }
}
