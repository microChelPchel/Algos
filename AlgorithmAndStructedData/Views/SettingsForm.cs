using AlgorithmAndStructedData.Controllers;
using AlgorithmAndStructedData.Models.Base;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AlgorithmAndStructedData.Views
{
    public partial class SettingsForm : Form
    {
        private SettingController _settingController;
        private AlgorithmController _algorithmController;

        public SettingsForm()
        {
            InitializeComponent();
            _settingController = new SettingController();
            _algorithmController = new AlgorithmController();
        }

        private void FillCollections()
        {
            FillComboboxSection();
        }

        private void FillComboboxSection()
        {
            comboBox1.Items.Add("Алгоритмы");
            comboBox1.Items.Add("Структуры данных");
            comboBox1.Items.Add("Паттерны");
            comboBox1.SelectedIndex = 0;
       }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для сохранения изменений необходимо перезупустить приложение","",MessageBoxButtons.OK, MessageBoxIcon.Information);
            SaveData(SetModelSectionData(), SetModelStatisticData());
            
            try
            {
               Process.Start("AlgorithmAndStructedData.exe");
            }
            catch(Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
            Environment.Exit(0);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            var data = LoadData();
            SetStatistic(data.Item2);
            SetSectionVisible(data.Item1);
            FillCollections();
        }

        private void SetStatistic(Statistic statistic)
        {
            label4.Text = statistic.SuccessSolution.ToString();
            label5.Text = statistic.TotalSolution.ToString();
        }

        private void SetSectionVisible(Section section)
        {
            checkedListBox1.SetItemCheckState(0, (CheckState)Convert.ToInt32(section.IsVisAlgo));
            checkedListBox1.SetItemCheckState(1, (CheckState)Convert.ToInt32(section.IsVisStruct));
            checkedListBox1.SetItemCheckState(2, (CheckState)Convert.ToInt32(section.IsVisPattern));
        }

        private Statistic SetModelStatisticData()
        {
            var res = new Statistic()
            {
                SuccessSolution = int.Parse(label4.Text),
                TotalSolution = int.Parse(label5.Text)
            };
            return res;
        }

        private Section SetModelSectionData()
        {
            var res = new Section()
            {
                IsVisAlgo = checkedListBox1.GetItemChecked(0),
                IsVisStruct = checkedListBox1.GetItemChecked(1),
                IsVisPattern = checkedListBox1.GetItemChecked(2)
            };
            return res;
        }

        private void SaveData(Section section, Statistic statistic)
        {
            _settingController.SaveSettings(section, statistic);
        }

        private (Section, Statistic) LoadData()
        {
            return _settingController.LoadSettings();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var resultDialog = MessageBox.Show("Вы уверены что хотите сбросить статистику?", "Сбросить статистику?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultDialog == DialogResult.Yes)
            {
                label4.Text = "0";
                label5.Text = "0";
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var formVisible = new DeleteForm();
            formVisible.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var parrent = comboBox1.SelectedItem.ToString();
            var item = new Algorithm(parrent,textBox1.Text,textBox2.Text);
            _algorithmController.SetAlgorithm(item, textBox1.Text);
            MessageBox.Show("Сохраненно");
        }
    }
}
