using AlgorithmAndStructedData.Logic.FormFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmAndStructedData
{
    public partial class MainForm : Form
    {
        private bool _firstStartFlag = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
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
            }
            if (form==null)
                return;
            if (form is Form)
            {
                form.Show();
                return;
            }

        }
    }

}
