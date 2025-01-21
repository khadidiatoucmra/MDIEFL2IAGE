using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIEFL2IAGE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cludClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2class FC = new Form2class();
            FC.MdiParent = this;
            FC.Show();
        }

        private void cludEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2Etudiant FE = new Form2Etudiant();
            FE.MdiParent = this;
            FE.Show();
        }
    }
}
