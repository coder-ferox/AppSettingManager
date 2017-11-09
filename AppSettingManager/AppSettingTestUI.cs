using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSettingManager
{
    public partial class AppSettingTestUI : Form
    {
        public AppSettingTestUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnReadKey_Click(object sender, EventArgs e)
        {

        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            btnReadValueFor.Text = "Read value for " + txtKey.Text;
            btnUpdateValueFor.Text = "Update value for " + txtKey.Text;
        }

        private void btnReadValueFor_Click(object sender, EventArgs e)
        {
            txtValue.Text = AppConfigManager.GetValue(txtKey.Text);
            
        }

        private void btnUpdateValueFor_Click(object sender, EventArgs e)
        {
            AppConfigManager.UpdateValue(txtKey.Text, txtValue.Text);
            MessageBox.Show("SUCCESS: "+txtKey.Text+" -> "+txtValue.Text);
        }
    }
}
