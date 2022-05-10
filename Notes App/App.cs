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

        private void setFileName(string file)
        {
            fileName = file;
            string fileNameOutput = Path.GetFileName(fileName);
            FileNameOutput.Text = fileNameOutput;

        }
        
        private void SaveFile(string file= "")
        {
            if (file == "")
            {
                if (SaveNote.ShowDialog() == DialogResult.OK)
                {
                    file = SaveNote.FileName;
                    setFileName(SaveNote.FileName);
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
                    setFileName(NoteOpener.FileName);
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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileName = "";
            FileNameOutput.Text = "Untitled";
            NoteInput.Text = "";
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FontSelector.ShowDialog() == DialogResult.OK)
            {
                NoteInput.Font = FontSelector.Font;
            }
        }

        private void Notes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fileName == "" && NoteInput.Text.Length > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to save your notes?", "Sharp Notes", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    SaveFile();
                } else
                {
                    if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            } else
            {
                if (fileName == "")
                {
                    return;
                }

                string savedData;
                using (StreamReader sr = new StreamReader(fileName))
                {
                    savedData = sr.ReadToEnd();
                    sr.Close();
                }

                if (savedData != NoteInput.Text)
                {
                    DialogResult result = MessageBox.Show("Do you want to save your notes?", "Sharp Notes", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        SaveFile(fileName);
                    }
                    else
                    {
                        if (result == DialogResult.Cancel)
                        {
                            e.Cancel = true;
                        }
                    }
                }
            } 
        }
    }
}
