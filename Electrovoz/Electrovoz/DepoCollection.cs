using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


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
        // Разделитель для записи информации в файл
        private readonly char separator = ':';
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
        
        // Сохранение информации по поездам в депо в файл
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename, true))
            {
                sw.Write($"DepoCollection{Environment.NewLine}");
                foreach (var level in depoStages)
                {
                    //начинаем парковку
                    sw.Write($"Depo{separator}{level.Key}{Environment.NewLine}");
                    Train train = null;
                    for (int i = 0; (train = level.Value.GetNext(i)) != null; i++)
                    {
                        if (train != null)
                        {
                            //если у нас место не пустое тогда мы записываем тип поезда              
                            if (train.GetType().Name == "Locomotive")
                            {
                                sw.Write($"Locomotive{separator}");
                            }
                            if (train.GetType().Name == "Electrovoz")
                            {
                                sw.Write($"Electrovoz{separator}");
                            }
                            //запись параметровв
                            sw.Write(train + Environment.NewLine);
                        }
                    }
                }
            }
            return true;
        }
        // Загрузка информации по поездам в депо из файла
        public bool LoadData(string filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                Train _train = null;

                string line = sr.ReadLine();
                string key = string.Empty;

                if (line.Contains("DepoCollection"))
                {
                    depoStages.Clear();
                    line = sr.ReadLine();
                    while (line != null)
                    {
                        if (line.Contains("Depo"))
                        {
                            key = line.Split(separator)[1];
                            depoStages.Add(key, new Depo<Train>(pictureWidth, pictureHeight));
                            line = sr.ReadLine();
                            continue;
                        }
                        if (string.IsNullOrEmpty(line))
                        {
                            line = sr.ReadLine();
                            continue;
                        }
                        if (line.Split(separator)[0] == "Locomotive")
                        {
                            _train = new Locomotive(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "Electrovoz")
                        {
                            _train = new Electrovoz(line.Split(separator)[1]);
                        }
                        var result = depoStages[key] + _train;
                        if (!result)
                        {
                            throw new Exception("Не удалось загрузить поезд в депо");
                        }
                        line = sr.ReadLine();
                    }
                    return true;
                }
                //если нет такой записи, то это не те данные
                throw new Exception("Неверный формат файла");
            }
        }
    }
}
