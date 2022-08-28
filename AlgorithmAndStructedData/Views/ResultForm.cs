using System;
using System.Windows.Forms;

namespace AlgorithmAndStructedData.Views
{
    public partial class ResultForm : Form
    {
        private string _result;
        public ResultForm(string result)
        {
            InitializeComponent();
            _result = result;
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = _result;
        }
    }
}
