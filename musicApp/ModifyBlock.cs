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
    public partial class ModifyBlock : Form
    {
        Form1 parsedForm;
        int indexModdedBlock;

        public ModifyBlock(int moddedBlock, Form1 form)
        {
            InitializeComponent();
            parsedForm = form;
            indexModdedBlock = moddedBlock;
            //Load the info into the textboxes
            textBox1.Text = form.blocks[moddedBlock].musicFilePath;
            textBox2.Text = form.blocks[moddedBlock].name;
            textBox3.Text = form.blocks[moddedBlock].keyCode;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Browse for a file and put the path into the textbox
            openFileDialog1.Filter = "WAV files (*.wav)|*.wav|MP3 Files (*.mp3)|*.mp3|All files (*.*)|*.*";
            DialogResult result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                //Add it to the text box on the app
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Modify this music block
            parsedForm.blocks[indexModdedBlock].name = textBox2.Text;
            parsedForm.blocks[indexModdedBlock].musicFilePath = textBox1.Text;
            parsedForm.blocks[indexModdedBlock].keyCode = textBox3.Text;
            parsedForm.AddBlock("tryblock", null);
            parsedForm.LoadBlocks();
            Close();
        }
        public bool changedText;

        private void TextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if(changedText == true)
            {
                //Changing text in progress
                textBox3.Text = "";
                textBox3.Text = e.KeyCode.ToString();
                changedText = false;
            }
        }

        private void TextBox3_MouseDown(object sender, MouseEventArgs e)
        {
            changedText = true;
        }

        private void ModifyBlock_FormClosing(object sender, FormClosingEventArgs e)
        {
            parsedForm.flowLayoutPanel1.Focus();
        }
    }
}
