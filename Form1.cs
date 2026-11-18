using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Editor
{
    public partial class Form1 : Form
    {
        int formindex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
            private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form active = this.ActiveMdiChild; // одоо идэвхтэй байгаа child
            if (active == null)
            {
                MessageBox.Show("Хадгалах цонх алга байна.");
                return;
            }
            TextBox txtBox = active.Controls.OfType<TextBox>().FirstOrDefault();
            if (txtBox == null) return; string path = active.Tag as string; // өмнө нь хадгалсан/нээсэн файлын зам      if (string.IsNullOrEmpty(path)) // анх удаа хадгалж байвал зам асууна
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Текст файл (*.txt)|*.txt|Бүх файл (*.*)|*.*";
                sfd.FileName = active.Text;
                if (sfd.ShowDialog() != DialogResult.OK) return;
                path = sfd.FileName;
            }
            System.IO.File.WriteAllText(path, txtBox.Text);
            active.Tag = path;                              // дараагийн удаа шууд хадгална
            active.Text = System.IO.Path.GetFileName(path); // гарчгийг файлын нэрээр солино
        }
        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form active = this.ActiveMdiChild; // одоо идэвхтэй байгаа child
            if (active == null)
            {
                MessageBox.Show("Хадгалах цонх алга байна.");
                return;
            }
            TextBox txtBox = active.Controls.OfType<TextBox>().FirstOrDefault();
            if (txtBox == null) return; string path = active.Tag as string; // өмнө нь хадгалсан/нээсэн файлын зам      if (string.IsNullOrEmpty(path)) // анх удаа хадгалж байвал зам асууна
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Текст файл (*.txt)|*.txt|Бүх файл (*.*)|*.*";
                sfd.FileName = active.Text;
                if (sfd.ShowDialog() != DialogResult.OK) return;
                path = sfd.FileName;
            }
            System.IO.File.WriteAllText(path, txtBox.Text);
            active.Tag = path;                              // дараагийн удаа шууд хадгална
            active.Text = System.IO.Path.GetFileName(path); // гарчгийг файлын нэрээр солино
        }

        private void cascedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);

    }

        private void virtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void horstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
