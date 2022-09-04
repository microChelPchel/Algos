using AlgorithmAndStructedData.Controllers;
using AlgorithmAndStructedData.Logic;
using AlgorithmAndStructedData.Logic.FormFactory;
using AlgorithmAndStructedData.Models.Base;
using AlgorithmAndStructedData.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlgorithmAndStructedData
{
    public partial class MainForm : Form
    {
        private bool _firstStartFlag = false;

        private AlgorithmController _algorithmController;
        private SettingController _settingController;
        private TaskModel _currentTaskModel;
        private DirectiveController _directiveController;
        private List<Algorithm> _algorithms;

        private string _currentTaskResult;

        public MainForm()
        {
            InitializeComponent();
            _algorithmController = new AlgorithmController();
            _settingController = new SettingController(); 
            _currentTaskResult = "";
            _directiveController = new DirectiveController();
            CreateAlgorithm();
            _algorithms = _directiveController.GetListFilesDirectory("Algorithms");
        }

        private void CreateAlgorithm()
        {
            _directiveController.CheckDir("Algorithms");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var section = _settingController.LoadSettings().Item1;
            var remIndex = 0;
            if (section.IsVisAlgo)
            {
                SetVisibleNode(0);
                remIndex++;
            }
            if (section.IsVisStruct)
            {
                SetVisibleNode(1 - remIndex);
                remIndex++;
            }
            if (section.IsVisPattern)
            {
                SetVisibleNode(2 - remIndex);
                remIndex++;
            }

            if (_algorithms.Count != 0)
            {
                foreach (var item in _algorithms)
                {
                    var index = treeView1.Nodes.IndexOfKey(item.Parrent);
                    if (index == -1)
                        continue;
                    treeView1.Nodes[index].Nodes.Add(item.Name);
                
                }
            }


            this.treeView1.SelectedNode = null;
        }

        private void SetVisibleNode(int index)
        {
            treeView1.Nodes.RemoveAt(index);
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

            //Base algorithm and menu
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
            
            if (form == null)
            {
                //case when item from file
                algorithm = _algorithms.Find(x => x.Name.Equals(name));
                if (algorithm == null)
                    return;
                AlgorithmPanel.Visible = true;
                SetAlgosControlsText(algorithm, false);
                return;
            }


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
                SetAlgosControlsText(algorithm,true); 
                return;
            }
        }

        private void SetAlgosControlsText(Algorithm algorithm, bool isBaseAlgorithm)
        {
            if (algorithm == null)
                return;
            NameLabel.Text = algorithm.Name;
            textBox1.Text = algorithm.Text;
            listBox1.Items.Clear();

            if (isBaseAlgorithm)
            {
                panel2.Visible = false;
                foreach (var item in algorithm.Tasks)
                {
                    listBox1.Items.Add(item);
                }
            }
            else
            {
                panel2.Visible = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: не выводит результат работы
            var result = CompilatorHelper.Compliler(textBox2.Text);
            foreach (var res in result.Output)
            {
                _currentTaskResult += res+'\n';
            }
            SetVisibleResult(true);
        }


        private void SetVisibleResult(bool visible)
        {
            label2.Visible = visible;
            linkLabel1.Visible = visible;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var formResult = new ResultForm(_currentTaskResult);
            formResult.ShowDialog();
        }

        private void AlgorithmPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
