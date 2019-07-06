using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musicApp
{
    public partial class Form1 : Form
    {
        public List<MusicBlock> blocks = new List<MusicBlock>();

        public Form1()
        {
            InitializeComponent();
            //Load up the blocks if there is some
            LoadBlocks();
            //Load the block Modifier
        }

        public void LoadBlocks()
        {
            //Clear the items just to make sure
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < blocks.Count; i++)
            {
                AddBlock(blocks[i].name, delegate { ModifyBlock(i); });
            }
            AddBlock("Add Block", AddProperty);
        }

        public void ModifyBlock(int index)
        {
            ModifyBlock blockModifier = new ModifyBlock(index - 1, this);
            blockModifier.ShowDialog();
        }

        public void AddBlock(string message, Action listenAction)
        {
            Button newButton = new Button();
            newButton.Text = message;
            newButton.Size = new Size(200, 200);
            newButton.Click += delegate { listenAction(); };
            flowLayoutPanel1.Controls.Add(newButton);
        }

        public void AddProperty()
        {
            MusicBlock blockCreated = new MusicBlock();
            blockCreated.musicFilePath = "No Path!";
            blockCreated.keyCode = "No Key Code";
            blockCreated.name = "Untitled";
            blockCreated.index = blocks.Count;
            blocks.Add(blockCreated);
            LoadBlocks();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void FlowLayoutPanel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Console.WriteLine(e.KeyCode.ToString());
            foreach (MusicBlock block in blocks)
            {
                //Trigger that block
                if (e.KeyCode.ToString() == block.keyCode)
                {
                    //Play that sound\
                    Console.WriteLine("Playing sound...");
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = block.musicFilePath;
                    player.Play();
                }
            }
        }
    }
}
