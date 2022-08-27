using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AlgorithmAndStructedData.Views
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для сохранения изменений необходимо перезупустить приложение","",MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                Process.Start("AlgorithmAndStructedDat1a.exe");
            }
            catch(Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
            Environment.Exit(0);
        }



    }
}
