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
            this.recordButton = new System.Windows.Forms.Button();
            this.stopButtonRecord = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.blockEditor = new System.Windows.Forms.Button();
            this.newTimeline = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // recordButton
            // 
            this.recordButton.Location = new System.Drawing.Point(12, 12);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(75, 23);
            this.recordButton.TabIndex = 0;
            this.recordButton.Text = "Record";
            this.recordButton.UseVisualStyleBackColor = true;
            // 
            // stopButtonRecord
            // 
            this.stopButtonRecord.Location = new System.Drawing.Point(93, 12);
            this.stopButtonRecord.Name = "stopButtonRecord";
            this.stopButtonRecord.Size = new System.Drawing.Size(75, 23);
            this.stopButtonRecord.TabIndex = 1;
            this.stopButtonRecord.Text = "Stop";
            this.stopButtonRecord.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(713, 12);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(632, 12);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
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
            // blockEditor
            // 
            this.blockEditor.Location = new System.Drawing.Point(551, 12);
            this.blockEditor.Name = "blockEditor";
            this.blockEditor.Size = new System.Drawing.Size(75, 23);
            this.blockEditor.TabIndex = 5;
            this.blockEditor.Text = "Block Editor";
            this.blockEditor.UseVisualStyleBackColor = true;
            this.blockEditor.Click += new System.EventHandler(this.button1_Click);
            // 
            // newTimeline
            // 
            this.newTimeline.Location = new System.Drawing.Point(175, 12);
            this.newTimeline.Name = "newTimeline";
            this.newTimeline.Size = new System.Drawing.Size(81, 23);
            this.newTimeline.TabIndex = 6;
            this.newTimeline.Text = "New Timeline";
            this.newTimeline.UseVisualStyleBackColor = true;
            this.newTimeline.Click += new System.EventHandler(this.newTimeline_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(262, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(92, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save Edits";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Timeline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newTimeline);
            this.Controls.Add(this.blockEditor);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.stopButtonRecord);
            this.Controls.Add(this.recordButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Timeline";
            this.Text = "Smack My Meat Audio Timeline";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Button stopButtonRecord;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button blockEditor;
        private System.Windows.Forms.Button newTimeline;
        private System.Windows.Forms.Button saveButton;
    }
}