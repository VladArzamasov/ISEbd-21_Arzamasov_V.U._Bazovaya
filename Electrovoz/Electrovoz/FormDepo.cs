using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electrovoz
{
    public partial class FormDepo : Form
    {
        // Объект от класса-депо
        private readonly DepoCollection depoCollection;
        // Логгер
        private readonly Logger logger;
        public FormDepo()
        {
            InitializeComponent();
            depoCollection = new DepoCollection(pictureBoxDepo.Width, pictureBoxDepo.Height);
            logger = LogManager.GetCurrentClassLogger();
            Draw();
        }
        // Заполнение listBoxLevels
        private void ReloadLevels()
        {
            int index = listBoxDepo.SelectedIndex;
            listBoxDepo.Items.Clear();
            for (int i = 0; i < depoCollection.Keys.Count; i++)
            {
                listBoxDepo.Items.Add(depoCollection.Keys[i]);
            }
            if (listBoxDepo.Items.Count > 0 && (index == -1 || index >=
           listBoxDepo.Items.Count))
            {
                listBoxDepo.SelectedIndex = 0;
            }
            else if (listBoxDepo.Items.Count > 0 && index > -1 && index <
           listBoxDepo.Items.Count)
            {
                listBoxDepo.SelectedIndex = index;
            }
        }
        // Метод отрисовки депо
        private void Draw()
        {
            if (listBoxDepo.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxDepo.Width, pictureBoxDepo.Height);
                Graphics gr = Graphics.FromImage(bmp);
                depoCollection[listBoxDepo.SelectedItem.ToString()].Draw(gr);
                pictureBoxDepo.Image = bmp;
            }
        }
        // Обработка нажатия кнопки "Забрать"
        private void buttonZobr_Click(object sender, EventArgs e)
        {
            if (listBoxDepo.SelectedIndex > -1 && maskedTextBoxPlace.Text != "")
            {
                try
                {
                    var train = depoCollection[listBoxDepo.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPlace.Text);
                    if (train != null)
                    {
                        FormElectrovoz form = new FormElectrovoz();
                        form.SetTrain(train);
                        form.ShowDialog();

                        logger.Info($"Изъят поезд {train} с места { maskedTextBoxPlace.Text}");
                        Draw();
                    }
                }
                catch (DepoNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Обработка нажатия кнопки "Добавить депо"
        private void buttonDobavlDepo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNameDepo.Text))
            {
                MessageBox.Show("Введите название депо", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            logger.Info($"Добавили депо {textBoxNameDepo.Text}");
            depoCollection.AddDepo(textBoxNameDepo.Text);
            ReloadLevels();
        }
        // Обработка нажатия кнопки "Удалить депо"
        private void buttonUdalDepo_Click(object sender, EventArgs e)
        {
            if (listBoxDepo.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить депо { listBoxDepo.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Удалили депо { listBoxDepo.SelectedItem.ToString()}");
                    depoCollection.DelDepo(listBoxDepo.Text);
                    ReloadLevels();
                }
            }
        }
        // Метод обработки выбора элемента на listBox
        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли в депо { listBoxDepo.SelectedItem.ToString()}");
            Draw();
        }

        private void buttonAddTrain_Click(object sender, EventArgs e)
        {
            var formElectrovozConfig = new FormElectrovozConfig();
            formElectrovozConfig.AddEvent(AddTrain);
            formElectrovozConfig.Show();
        }
        private void AddTrain(Train train)
        {
            if (train != null && listBoxDepo.SelectedIndex > -1)
            {
                try
                {
                    if ((depoCollection[listBoxDepo.SelectedItem.ToString()]) + train)
                    {
                        Draw();
                        logger.Info($"Добавлен поезд {train}");
                    }
                    else
                    {
                        MessageBox.Show("Поезд не удалось поставить");
                        logger.Warn("Поезд не удалось поставить");
                    }
                    Draw();
                }
                catch (DepoOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Поезд не удалось поставить");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Поезд не удалось поставить");
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    depoCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    depoCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (DepogOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
