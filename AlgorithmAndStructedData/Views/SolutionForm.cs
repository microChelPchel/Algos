using AlgorithmAndStructedData.Models.Base;
using System;
using System.Windows.Forms;

namespace AlgorithmAndStructedData.Views
{
    public partial class SolutionForm : Form
    {
        private TaskModel _taskModel;

        public SolutionForm(TaskModel taskModel)
        {
            InitializeComponent();
            _taskModel = taskModel;
        }

        private void SolutionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
