﻿using AlgorithmAndStructedData.Controllers;
using AlgorithmAndStructedData.Logic.FormFactory;
using AlgorithmAndStructedData.Models.Base;
using AlgorithmAndStructedData.Views;
using System;
using System.Windows.Forms;

namespace AlgorithmAndStructedData
{
    public partial class MainForm : Form
    {
        private bool _firstStartFlag = false;

        private AlgorithmController _algorithmController;
        private TaskModel _currentTaskModel;

        public MainForm()
        {
            InitializeComponent();
            _algorithmController = new AlgorithmController();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void NameLabel_Click(object sender, EventArgs e)
        {

        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!_firstStartFlag)
            {
                _firstStartFlag = true;
                return;
            }
            var creater = new CreaterView();
            string name = e.Node.Text;
            Control form = null;
            Algorithm algorithm = null;
            switch(name)
            {
                case "Алгоритмы":
                    form = creater.CallView(ViewEnum.Alghos);
                    break;
                case "Структуры данных":
                    form = creater.CallView(ViewEnum.Structs);
                    break;
                case "Паттерны проектирования":
                    form = creater.CallView(ViewEnum.Patterns);
                    break;
                case "Настройки":
                    form = creater.CallView(ViewEnum.Settings);
                    break;
                case "Сортировка пузырьком":
                    form = creater.CallView(ViewEnum.BubbleSort);
                    form.Name = "AlgorithmPanel";
                    algorithm = _algorithmController.GetAlgorithm(Logic.AlgosFactory.AlgosEnum.BubbleSort);
                    break;
            }
            if (form==null)
                return;
            if (form is Form frm)
            {
                frm.ShowDialog();
                return;
            }

            if (form is Panel)
            {
                foreach (var control in this.Controls)
                {
                    if (control is Control cntrl)
                    {
                        if (form.Name == cntrl.Name)
                        {
                            cntrl.Visible = true;
                        }
                    }
                }
                SetAlgosControlsText(algorithm); 
                return;
            }
        }



        private void SetAlgosControlsText(Algorithm algorithm)
        {
            if (algorithm == null)
                return;
            NameLabel.Text = algorithm.Name;
            textBox1.Text = algorithm.Text;
            listBox1.Items.Clear();

            foreach (var item in algorithm.Tasks)
            {
                listBox1.Items.Add(item);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_currentTaskModel == null)
                return;
            var formSolution = new SolutionForm(_currentTaskModel); 
            formSolution.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentTaskModel = (TaskModel)listBox1.SelectedItem;
            SetLabelsText();
        }


        private void SetLabelsText()
        {
            if (_currentTaskModel == null)
                return;
            textBox3.Text = _currentTaskModel.Name;
        }
    }

}
