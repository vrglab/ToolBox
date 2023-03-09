using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolBox.Forms;

namespace ToolBox
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void decompilers_Click(object sender, EventArgs e)
        {
            Decompiler_Page dp = new Decompiler_Page();
            dp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CryptionDialog cd = new CryptionDialog();
            cd.Show();
        }
    }
}
