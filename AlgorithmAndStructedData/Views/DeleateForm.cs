﻿using System;
using System.Windows.Forms;

namespace AlgorithmAndStructedData.Views
{
    public partial class DeleateForm : Form
    {
        public DeleateForm()
        {
            InitializeComponent();
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
            var result = MessageBox.Show("Вы действительно хотите удалить узел ИМЯ", "Удалить узел?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //УДАЛЕНИЕ
                int fec = 10;
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
            //TYT


        }
    }
}
