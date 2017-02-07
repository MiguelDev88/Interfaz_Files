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


        private void languageMenuItem_Click(object sender, EventArgs e)
        {

            System.Resources.ResourceManager rm=null;


            switch (((ToolStripItem)sender).Name)
            {
                case ("españolToolStripMenuItem"):
                    rm = new System.Resources.ResourceManager("Files.Resources.TraductorCastellano", typeof(frmFiles).Assembly);
                    break;
                case ("englishToolStripMenuItem"):
                    rm = new System.Resources.ResourceManager("Files.Resources.TraductorIngles", typeof(frmFiles).Assembly);
                    break;
            }


            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(SplitContainer))
                {
                    foreach (Label label in ((SplitContainer)c).Panel1.Controls)
                    {
                        label.Text= rm.GetString(label.Name);
                    }
                }

                if (c.GetType() == typeof(MenuStrip))
                {
                    foreach (ToolStripItem item in ((MenuStrip)c).Items)
                    {
                        item.Text = rm.GetString(item.Name);
                    }
                }
            }

            foreach (ToolStripItem item in contextMenu.Items)
            {
                item.Text = rm.GetString(item.Name);
            }

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenu.Show(Cursor.Position);
                }
            }
        }
    }
}
