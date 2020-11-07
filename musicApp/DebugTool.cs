using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musicApp
{
    public partial class DebugTool : Form
    {
        public DebugTool()
        {
            InitializeComponent();
        }

        private void DebugTool_Load(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            //Update
            UpdateList();
        }

        public void UpdateList()
        {
            //Load up the current events.
            //Load a blank one for update
            //listView1.Items.Add("Update");
            if(Program.metaFile.dictionary.Count <= 0)
            {
                if (Program.DebugMode) { Console.WriteLine("There was no items to display in the debug tool.."); }
            }
            foreach (string m in Program.metaFile.dictionary.Keys)
            {
                listView1.Items.Add(m + " " + Program.metaFile.dictionary[m]);
            }
        }
    }
}
