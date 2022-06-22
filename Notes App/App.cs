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
using Notes_App;

namespace Notes_App
{
    public partial class Notes : Form
    {
        string fileName = "";
        PageControl PageController;
        
        public Notes()
        {
            InitializeComponent();
        }

        private void setFileName(string file)
        {
            fileName = file;
            string fileNameOutput = Path.GetFileName(fileName);
            this.Text = $"Sharp Notes ({fileNameOutput})";
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

        private int requestedToSaveForNew()
        {

            /*
             * 0: OK
             * 1: NO
             * 2: CANCEL
            */

            if (NoteInput.Text.Length > 0) // Checks if the user has typed anything into the text box.
            {
                if (fileName == "") // Checks if the file has a name (if it has been assigned when the user opens or saves a file)
                {
                    DialogResult request = MessageBox.Show("Do you want to save your notes?", "Sharp Notes", MessageBoxButtons.YesNoCancel); // Asks the user if they wish to save.
                    if (request == DialogResult.OK)
                    {
                        return 0; 
                    } else if (request == DialogResult.Cancel)
                    {
                        return 2;
                    }
                } else
                {
                    string FileText;
                    using (StreamReader sw = new StreamReader(fileName))
                    {
                        FileText = sw.ReadToEnd();
                        sw.Close();
                    }

                    if (FileText != NoteInput.Text)
                    {
                        DialogResult request = MessageBox.Show("Do you want to save your notes?", "Sharp Notes", MessageBoxButtons.YesNoCancel);
                        if (request == DialogResult.OK)
                        {
                            return 0;
                        } else if (request == DialogResult.Cancel)
                        {
                            return 2;
                        }
                    } else
                    {
                        return 1;
                    }
                }
            }

            return 1;
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
            OpenFile(); // Runs the open file function.
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile(); // Runs the save file function.
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile(fileName); // Runs the save file function.
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); // Closes the application.
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userRequestFileSave = requestedToSaveForNew();

            switch (userRequestFileSave) 
            {
                case 0:
                    {
                        SaveFile(fileName);
                        fileName = "";
                        this.Text = "Sharp Notes (Untitled)";
                        NoteInput.Text = "";
                        break;
                    }
                case 1:
                    {
                        fileName = "";
                        this.Text = "Sharp Notes (Untitled)";
                        NoteInput.Text = "";
                        break;
                    }
                case 2:
                    {
                        break;
                    }
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

        private void Notes_Load(object sender, EventArgs e)
        {
            this.Text = "Sharp Notes (Untitled)";
            PageController = new PageControl();
            PageController.Add(MainPage); // Adds the Main Page to the controller.
            PageController.Add(Settings); // Adds the settings page to the controller.
            PageController.Display(MainPage); // Shows the main page.
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageController.Display(Settings);
        }

        private void SettingsExit_Click(object sender, EventArgs e)
        {
            PageController.Display(MainPage);
        }

        private void setTransparency(double transparency)
        {
            this.Opacity = transparency;
        }

        private void setTransparency()
        {
            setTransparency(1);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            double TransparencyValue = ((double)TransparencyBar.Value)/10;
            setTransparency(TransparencyValue);
        }

        private void fontToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (FontSelector.ShowDialog() == DialogResult.OK)
            {
                NoteInput.Font = FontSelector.Font;
            }
        }

        
    }
}
