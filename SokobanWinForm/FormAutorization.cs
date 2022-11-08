using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SokobanWinForm
{
    public partial class FormAutorization : Form
    {
        public string PlayerName;
        public FormAutorization()
        {
            InitializeComponent();
            PlayerName = "";
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            PlayerName = textBox1.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
