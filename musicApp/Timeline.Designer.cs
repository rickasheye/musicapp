namespace musicApp
{
    partial class Timeline
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.canvas = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordButton = new System.Windows.Forms.ToolStripMenuItem();
            this.stopButtonRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.newTimelineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveEditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variableViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.playButton = new System.Windows.Forms.ToolStripMenuItem();
            this.stopButton = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(12, 41);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(776, 397);
            this.canvas.TabIndex = 4;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.gPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.variableViewerToolStripMenuItem,
            this.blockEditorToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // gPToolStripMenuItem
            // 
            this.gPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordButton,
            this.stopButtonRecord,
            this.newTimelineToolStripMenuItem,
            this.saveEditsToolStripMenuItem,
            this.toolStripSeparator1,
            this.playButton,
            this.stopButton});
            this.gPToolStripMenuItem.Name = "gPToolStripMenuItem";
            this.gPToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.gPToolStripMenuItem.Text = "GP";
            // 
            // recordButton
            // 
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(180, 22);
            this.recordButton.Text = "Record";
            // 
            // stopButtonRecord
            // 
            this.stopButtonRecord.Name = "stopButtonRecord";
            this.stopButtonRecord.Size = new System.Drawing.Size(180, 22);
            this.stopButtonRecord.Text = "Stop";
            // 
            // newTimelineToolStripMenuItem
            // 
            this.newTimelineToolStripMenuItem.Name = "newTimelineToolStripMenuItem";
            this.newTimelineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newTimelineToolStripMenuItem.Text = "New Timeline";
            // 
            // saveEditsToolStripMenuItem
            // 
            this.saveEditsToolStripMenuItem.Name = "saveEditsToolStripMenuItem";
            this.saveEditsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveEditsToolStripMenuItem.Text = "Save Edits";
            // 
            // variableViewerToolStripMenuItem
            // 
            this.variableViewerToolStripMenuItem.Name = "variableViewerToolStripMenuItem";
            this.variableViewerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.variableViewerToolStripMenuItem.Text = "Variable Viewer";
            this.variableViewerToolStripMenuItem.Click += new System.EventHandler(this.variableViewerToolStripMenuItem_Click);
            // 
            // blockEditorToolStripMenuItem
            // 
            this.blockEditorToolStripMenuItem.Name = "blockEditorToolStripMenuItem";
            this.blockEditorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blockEditorToolStripMenuItem.Text = "Block Editor";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // playButton
            // 
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(180, 22);
            this.playButton.Text = "Play";
            this.playButton.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // stopButton
            // 
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(180, 22);
            this.stopButton.Text = "Stop";
            // 
            // Timeline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Timeline";
            this.Text = "Smack My Meat Audio Timeline";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variableViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blockEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordButton;
        private System.Windows.Forms.ToolStripMenuItem stopButtonRecord;
        private System.Windows.Forms.ToolStripMenuItem newTimelineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveEditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem playButton;
        private System.Windows.Forms.ToolStripMenuItem stopButton;
    }
}