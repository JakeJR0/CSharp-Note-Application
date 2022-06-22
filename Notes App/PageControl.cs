using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Notes_App
{
    internal class PageControl
    {
        List<Panel> panels; // Initiates the variable

        public void Dispose()
        {
            GC.SuppressFinalize(this); // Removes the instance using the garbage collection.
        }

        public void Add(Panel newPanel)
        {
            this.panels.Add(newPanel);
        }

        public void Display(Panel panelToDisplay)
        {
            foreach (Panel p in this.panels)
            {
                if (p == panelToDisplay)
                {
                    p.Visible = true;
                    p.BringToFront();
                } else
                {
                    p.Visible = false;
                }
            }
        }

        public PageControl()
        {
            panels = new List<Panel> { }; // Creates a new list
        }
    }
}