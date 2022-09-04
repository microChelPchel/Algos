using AlgorithmAndStructedData.Controllers;
using System;
using System.Windows.Forms;

namespace AlgorithmAndStructedData.Views
{
    public partial class DeleteForm : Form
    {
        private DirectiveController _directiveController;
        public DeleteForm()
        {
            InitializeComponent();
            _directiveController = new DirectiveController();
        }

        private void FillCollections()
        {
            FillComboboxSection();
            FillMainCombobox();

        }
        private void FillComboboxSection()
        {
            comboBox1.Items.Add("Алгоритмы");
            comboBox1.Items.Add("Структуры данных");
            comboBox1.Items.Add("Паттерны");
            comboBox1.SelectedIndex = 0;
        }

        private void FillMainCombobox()
        {
            //need for outher directive
            var algorithms = _directiveController.GetListFilesDirectory("Algorithms") ;
            if (algorithms == null)
                return;
            foreach (var item in algorithms)
            {
                comboBox2.Items.Add(item);
            }
            comboBox2.SelectedIndex = 0;
        }



        private string[] GetCollections(string nameSetction)
        {
            return default;
        }


        private void DeleateForm_Load(object sender, EventArgs e)
        {
            FillCollections();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //получить имя удаляемого узла
            var result = MessageBox.Show($"Вы действительно хотите удалить узел {comboBox2.SelectedItem}", "Удалить узел?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string patch = $@"Algorithms\{comboBox2.SelectedItem}.dat";
                _directiveController.DeleteFile(patch);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var nameItem = comboBox1.SelectedItem.ToString();
            string[] collections;
            switch (nameItem)
            {
                case "Алгоритмы":
                    collections = GetCollections(nameItem);
                    break;
                case "Структуры данных":
                    collections = GetCollections(nameItem);
                    break;
                case "Паттерны":
                    collections = GetCollections(nameItem);
                    break;
            }
            //TODO: доделать


        }
    }
}
