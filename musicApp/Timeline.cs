using musicApp.Types.UIElements;
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
    public partial class Timeline : Form
    {
        public bool PlayMode = false;
        public bool recording = false;

        public Timeline()
        {
            InitializeComponent();
            //Initialise the control panel like enabling and disabling buttons!!!
            if(PlayMode)
            {
                //Then we want to disable the play and stop buttons!
                playButton.Enabled = false;
                stopButton.Enabled = false;
            }

            if (!recording)
            {
                stopButtonRecord.Enabled = false;
                recordButton.Enabled = true;
            }
        }

        public List<UIElement> uiElements = new List<UIElement>();

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Call the List Box for the main drawing and paste it here!!!
            if (uiElements.Count > 0)
            {
                foreach (UIElement element in uiElements)
                {
                    element.DrawElement(e.Graphics);
                } 
            }
        }

        BlockWindow window;

        private void button1_Click(object sender, EventArgs e)
        {
            //Open the block editor
            if(window == null)
            {
                window = new BlockWindow();
                window.Show();
            }
        }

        private void newTimeline_Click(object sender, EventArgs e)
        {
            //Create a new timeline for the thing to sit on...
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Save the newly edited stuff...
        }

        private void variableViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DebugTool tool = new DebugTool();
            tool.Show();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
