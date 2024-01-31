using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSP_Launcher
{
    public partial class error : Form
    {
        public error()
        {
            InitializeComponent();
        }

        private async void error_Load(object sender, EventArgs e)
        {
            await Task.Delay(1000);
            MessageBox.Show(Form1.errortext, "ERROR!");
            this.Close();
        }
    }
}
