using AlgorithmAndStructedData.Controllers;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AlgorithmAndStructedData.Views
{
    public partial class SettingsForm : Form
    {
        private SettingController _settingController;
        public SettingsForm()
        {
            InitializeComponent();
            _settingController = new SettingController();
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

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            //LOAD DATA
        }
    }
}
