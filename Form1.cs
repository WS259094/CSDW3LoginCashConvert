using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDW3LoginCashConvert
{
    public partial class F1LCCLogin : Form
    {
        public F1LCCLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string sUsername = txtUsername.Text;
            string sPassword = txtPassword.Text;
            if (sUsername == "Beep" && sPassword == "Boop")
            {
               W3F2CashConvert F2CashConvert = new W3F2CashConvert();
                this.Hide();
                F2CashConvert.Show();
            }
        }
    }
}
