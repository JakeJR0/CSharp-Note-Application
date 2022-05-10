using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes_App
{
    public partial class Notes : Form
    {
        string fileName = "";
        
        public Notes()
        {
            InitializeComponent();
        }

        private void SaveFile(string file= "")
        {
            if (file == "")
            {
                if (SaveNote.ShowDialog() == DialogResult.OK)
                {
                    file = SaveNote.FileName;
                    fileName = SaveNote.FileName;
                }
                else
                {
                    return;
                }
            }

            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.Write(NoteInput.Text);
                sw.Close();
            }
        }

        private void OpenFile()
        {
            
            if (NoteOpener.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(NoteOpener.FileName))
                {
                    string output = sr.ReadToEnd();
                    NoteInput.Text = output;
                    fileName = NoteOpener.FileName;
                    sr.Close();
                }
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile(fileName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
