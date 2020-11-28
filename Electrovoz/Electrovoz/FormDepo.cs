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
        public FormDepo()
        {
            InitializeComponent();
            depoCollection = new DepoCollection(pictureBoxDepo.Width, pictureBoxDepo.Height);
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
                var train = depoCollection[listBoxDepo.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (train != null)
                {
                    FormElectrovoz form = new FormElectrovoz();
                    form.SetTrain(train);
                    form.ShowDialog();
                }
                Draw();
            }
        }
        // Обработка нажатия кнопки "Добавить депо"
        private void buttonDobavlDepo_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxNameDepo.Text))
            {
                MessageBox.Show("Введите название депо", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
                    depoCollection.DelDepo(listBoxDepo.Text);
                    ReloadLevels();
                }
            }
        }
        // Метод обработки выбора элемента на listBox
        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                if ((depoCollection[listBoxDepo.SelectedItem.ToString()]) + train)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Поезд не удалось поставить");
                }
            }
        }
    }
}
