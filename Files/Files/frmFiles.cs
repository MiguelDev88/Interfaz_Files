using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Files
{
    public partial class frmFiles : Form
    {
        public frmFiles()
        {
            InitializeComponent();
            
            
        }

        private void Menu_MouseHover(object sender, EventArgs e)
        {
            labelHelp.Text = ((ToolStripMenuItem)sender).Text;   
        }

        private void frmFiles_Load(object sender, EventArgs e)
        {

        }
    }
}
