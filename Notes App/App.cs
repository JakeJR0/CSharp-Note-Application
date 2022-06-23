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
        string fileName = ""; // Sets a default value to the fileName variable
        PageControl PageController; // Initiates the variable
        
        public Notes()
        {
            InitializeComponent();
        }

        private void setFileName(string file)
        {
            fileName = file; // Sets the variable to the filename
            string fileNameOutput = Path.GetFileName(fileName); // Gets the full file name.
            this.Text = $"Sharp Notes ({fileNameOutput})"; // Sets the title of the application
        }
        
        private void SaveFile(string file= "")
        {
            if (file == "") // Checks if a file has been selected already.
            {
                if (SaveNote.ShowDialog() == DialogResult.OK) // Prompts the user to save the file
                {
                    file = SaveNote.FileName; // Sets file name for future saves
                    setFileName(SaveNote.FileName); // Sets the file name and modifys the title of the application
                }
                else
                {
                    return; 
                }
            }

            using (StreamWriter sw = new StreamWriter(file)) // Creates a file stream which is used to modify the file
            {
                sw.Write(NoteInput.Text); // Writes the changes to the file.
                sw.Close(); // Closes the file.
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
            PageController = new PageControl(); // Creates a child instance of the PageControl class.
            PageController.Add(MainPage); // Adds the Main Page to the controller.
            PageController.Add(Settings); // Adds the settings page to the controller.
            PageController.Display(MainPage); // Shows the main page.
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageController.Display(Settings); // Displays the settings page
        }

        private void SettingsExit_Click(object sender, EventArgs e)
        {
            PageController.Display(MainPage); // Displays the main page as the user wishes to exit the settings.
        }

        private void setTransparency(double transparency)
        {
            this.Opacity = transparency; // Sets the transparency of the application to the value
        }

        private void setTransparency() // Used to have a default so the function does not require parameters
        {
            setTransparency(1); // Sets the transparency to 100%
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            /*
             * Converts the value of the bar to a double and divides it by 10
             * 
             * Example:
             * 
             *  Transparency Value could equal 70 which is short for 70%
             *  Since the form requires that the value is a decimal / double
             *  the transparency value is converted into 0.7 which the form
             *  can interpret.
            */
            
            double TransparencyValue = ((double)TransparencyBar.Value)/10; 
            
            setTransparency(TransparencyValue); // Sets the transparency to the calculated value
        }

        private void fontToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            /*
             * The application opens the font selecter which allows the user to
             * modify the size, style and font, once the user has finished the application
             * checks if the user pressed ok which is used to confirm the changes,
             * if the user just exits out of the popup, the application will not
             * apply the changes that have been made.
            */

            if (FontSelector.ShowDialog() == DialogResult.OK) 
            {
                NoteInput.Font = FontSelector.Font; // Applys the desired changes to the NoteInput (TextBox).
            }
        }

        
    }
}
