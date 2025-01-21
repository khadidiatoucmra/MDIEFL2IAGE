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
    public partial class Form2class : Form
    {
        public Form2class()
        {
            InitializeComponent();
        }

        public Form1 Mdiparent { get; internal set; }

        private void Form2class_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var Db = new Dbscolaire())
            {
                Classe classe = new Classe();
                classe.libelle = txtlibelle.Text;
                Db.Classe.Add(classe);
                Db.SaveChanges();
                if (Db.SaveChanges() != 0)
                {
                    MessageBox.Show("donner inserer", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualiser();
                }
            }

        }
        public void actualiser()
        {
            dataGridView1.DataSource = null;
            using (var db = new Dbscolaire())

            {
                dataGridView1.DataSource = db.Classe.ToList();
            }

        }
    }

}