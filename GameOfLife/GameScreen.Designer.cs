namespace GameOfLife
{
    partial class GameScreen
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
            this.Field = new System.Windows.Forms.PictureBox();
            this.StartStopBut = new System.Windows.Forms.Button();
            this.FramesCounterLabel = new System.Windows.Forms.Label();
            this.FPSTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.FPSTextBar = new System.Windows.Forms.TextBox();
            this.GoToFrameTextBox = new System.Windows.Forms.TextBox();
            this.GoToFrameBut = new System.Windows.Forms.Button();
            this.SetFpsBut = new System.Windows.Forms.Button();
            this.NextFrameBut = new System.Windows.Forms.Button();
            this.PreviousFrameBut = new System.Windows.Forms.Button();
            this.SaveBut = new System.Windows.Forms.Button();
            this.SaveAsBut = new System.Windows.Forms.Button();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.ExitBut = new System.Windows.Forms.Button();
            this.AliveQuadsLabel = new System.Windows.Forms.Label();
            this.BornQuadsLabel = new System.Windows.Forms.Label();
            this.DiedQuadsLabel = new System.Windows.Forms.Label();
            this.LogTextbox = new System.Windows.Forms.TextBox();
            this.EnableLogCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Field)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FPSTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Field
            // 
            this.Field.Location = new System.Drawing.Point(13, 13);
            this.Field.Name = "Field";
            this.Field.Size = new System.Drawing.Size(750, 750);
            this.Field.TabIndex = 0;
            this.Field.TabStop = false;
            // 
            // StartStopBut
            // 
            this.StartStopBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartStopBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartStopBut.Location = new System.Drawing.Point(769, 180);
            this.StartStopBut.Name = "StartStopBut";
            this.StartStopBut.Size = new System.Drawing.Size(150, 50);
            this.StartStopBut.TabIndex = 3;
            this.StartStopBut.Text = "Start";
            this.StartStopBut.UseVisualStyleBackColor = true;
            this.StartStopBut.Click += new System.EventHandler(this.StartStopBut_Click);
            // 
            // FramesCounterLabel
            // 
            this.FramesCounterLabel.AutoSize = true;
            this.FramesCounterLabel.Font = new System.Drawing.Font("Miramonte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FramesCounterLabel.Location = new System.Drawing.Point(769, 13);
            this.FramesCounterLabel.Name = "FramesCounterLabel";
            this.FramesCounterLabel.Size = new System.Drawing.Size(72, 24);
            this.FramesCounterLabel.TabIndex = 4;
            this.FramesCounterLabel.Text = "Frames:";
            // 
            // FPSTrackBar
            // 
            this.FPSTrackBar.Location = new System.Drawing.Point(769, 78);
            this.FPSTrackBar.Minimum = 1;
            this.FPSTrackBar.Name = "FPSTrackBar";
            this.FPSTrackBar.Size = new System.Drawing.Size(203, 45);
            this.FPSTrackBar.TabIndex = 5;
            this.FPSTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.FPSTrackBar.Value = 1;
            this.FPSTrackBar.Scroll += new System.EventHandler(this.FPSTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(773, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "FPS:";
            // 
            // FPSTextBar
            // 
            this.FPSTextBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FPSTextBar.Location = new System.Drawing.Point(769, 129);
            this.FPSTextBar.Name = "FPSTextBar";
            this.FPSTextBar.Size = new System.Drawing.Size(40, 24);
            this.FPSTextBar.TabIndex = 7;
            // 
            // GoToFrameTextBox
            // 
            this.GoToFrameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoToFrameTextBox.Location = new System.Drawing.Point(769, 266);
            this.GoToFrameTextBox.Name = "GoToFrameTextBox";
            this.GoToFrameTextBox.Size = new System.Drawing.Size(69, 24);
            this.GoToFrameTextBox.TabIndex = 8;
            // 
            // GoToFrameBut
            // 
            this.GoToFrameBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoToFrameBut.Location = new System.Drawing.Point(844, 266);
            this.GoToFrameBut.Name = "GoToFrameBut";
            this.GoToFrameBut.Size = new System.Drawing.Size(75, 24);
            this.GoToFrameBut.TabIndex = 9;
            this.GoToFrameBut.Text = "Go to frame";
            this.GoToFrameBut.UseVisualStyleBackColor = true;
            this.GoToFrameBut.Click += new System.EventHandler(this.GoToFrameBut_Click);
            // 
            // SetFpsBut
            // 
            this.SetFpsBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetFpsBut.Location = new System.Drawing.Point(815, 129);
            this.SetFpsBut.Name = "SetFpsBut";
            this.SetFpsBut.Size = new System.Drawing.Size(75, 24);
            this.SetFpsBut.TabIndex = 10;
            this.SetFpsBut.Text = "Set fps";
            this.SetFpsBut.UseVisualStyleBackColor = true;
            this.SetFpsBut.Click += new System.EventHandler(this.SetFpsBut_Click);
            // 
            // NextFrameBut
            // 
            this.NextFrameBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextFrameBut.Location = new System.Drawing.Point(844, 296);
            this.NextFrameBut.Name = "NextFrameBut";
            this.NextFrameBut.Size = new System.Drawing.Size(75, 50);
            this.NextFrameBut.TabIndex = 11;
            this.NextFrameBut.Text = "Next frame";
            this.NextFrameBut.UseVisualStyleBackColor = true;
            this.NextFrameBut.Click += new System.EventHandler(this.NextFrameBut_Click);
            // 
            // PreviousFrameBut
            // 
            this.PreviousFrameBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PreviousFrameBut.Location = new System.Drawing.Point(769, 296);
            this.PreviousFrameBut.Name = "PreviousFrameBut";
            this.PreviousFrameBut.Size = new System.Drawing.Size(69, 50);
            this.PreviousFrameBut.TabIndex = 12;
            this.PreviousFrameBut.Text = "Previous frame";
            this.PreviousFrameBut.UseVisualStyleBackColor = true;
            this.PreviousFrameBut.Click += new System.EventHandler(this.PreviousFrameBut_Click);
            // 
            // SaveBut
            // 
            this.SaveBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBut.Font = new System.Drawing.Font("Miramonte", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBut.Location = new System.Drawing.Point(769, 579);
            this.SaveBut.Name = "SaveBut";
            this.SaveBut.Size = new System.Drawing.Size(150, 50);
            this.SaveBut.TabIndex = 13;
            this.SaveBut.Text = "Save";
            this.SaveBut.UseVisualStyleBackColor = true;
            this.SaveBut.Click += new System.EventHandler(this.SaveBut_Click);
            // 
            // SaveAsBut
            // 
            this.SaveAsBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAsBut.Font = new System.Drawing.Font("Miramonte", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAsBut.Location = new System.Drawing.Point(769, 635);
            this.SaveAsBut.Name = "SaveAsBut";
            this.SaveAsBut.Size = new System.Drawing.Size(150, 50);
            this.SaveAsBut.TabIndex = 14;
            this.SaveAsBut.Text = "Save as";
            this.SaveAsBut.UseVisualStyleBackColor = true;
            this.SaveAsBut.Click += new System.EventHandler(this.SaveAsBut_Click);
            // 
            // SFD
            // 
            this.SFD.DefaultExt = "golsv";
            this.SFD.Filter = "Game of life save file (*.golsv)|*.golsv";
            this.SFD.Title = "SOS! Someone save me please!";
            // 
            // ExitBut
            // 
            this.ExitBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBut.Font = new System.Drawing.Font("Pescadero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBut.Location = new System.Drawing.Point(769, 713);
            this.ExitBut.Name = "ExitBut";
            this.ExitBut.Size = new System.Drawing.Size(150, 50);
            this.ExitBut.TabIndex = 15;
            this.ExitBut.Text = "Exit";
            this.ExitBut.UseVisualStyleBackColor = true;
            this.ExitBut.Click += new System.EventHandler(this.ExitBut_Click);
            // 
            // AliveQuadsLabel
            // 
            this.AliveQuadsLabel.AutoSize = true;
            this.AliveQuadsLabel.Location = new System.Drawing.Point(766, 380);
            this.AliveQuadsLabel.Name = "AliveQuadsLabel";
            this.AliveQuadsLabel.Size = new System.Drawing.Size(33, 13);
            this.AliveQuadsLabel.TabIndex = 16;
            this.AliveQuadsLabel.Text = "Alive:";
            // 
            // BornQuadsLabel
            // 
            this.BornQuadsLabel.AutoSize = true;
            this.BornQuadsLabel.Location = new System.Drawing.Point(766, 393);
            this.BornQuadsLabel.Name = "BornQuadsLabel";
            this.BornQuadsLabel.Size = new System.Drawing.Size(32, 13);
            this.BornQuadsLabel.TabIndex = 17;
            this.BornQuadsLabel.Text = "Born:";
            // 
            // DiedQuadsLabel
            // 
            this.DiedQuadsLabel.AutoSize = true;
            this.DiedQuadsLabel.Location = new System.Drawing.Point(766, 406);
            this.DiedQuadsLabel.Name = "DiedQuadsLabel";
            this.DiedQuadsLabel.Size = new System.Drawing.Size(32, 13);
            this.DiedQuadsLabel.TabIndex = 18;
            this.DiedQuadsLabel.Text = "Died:";
            // 
            // LogTextbox
            // 
            this.LogTextbox.Location = new System.Drawing.Point(769, 447);
            this.LogTextbox.Multiline = true;
            this.LogTextbox.Name = "LogTextbox";
            this.LogTextbox.ReadOnly = true;
            this.LogTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextbox.Size = new System.Drawing.Size(100, 105);
            this.LogTextbox.TabIndex = 19;
            // 
            // EnableLogCheckbox
            // 
            this.EnableLogCheckbox.AutoSize = true;
            this.EnableLogCheckbox.Location = new System.Drawing.Point(769, 424);
            this.EnableLogCheckbox.Name = "EnableLogCheckbox";
            this.EnableLogCheckbox.Size = new System.Drawing.Size(76, 17);
            this.EnableLogCheckbox.TabIndex = 20;
            this.EnableLogCheckbox.Text = "Enable log";
            this.EnableLogCheckbox.UseVisualStyleBackColor = true;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 812);
            this.Controls.Add(this.EnableLogCheckbox);
            this.Controls.Add(this.LogTextbox);
            this.Controls.Add(this.DiedQuadsLabel);
            this.Controls.Add(this.BornQuadsLabel);
            this.Controls.Add(this.AliveQuadsLabel);
            this.Controls.Add(this.ExitBut);
            this.Controls.Add(this.SaveAsBut);
            this.Controls.Add(this.SaveBut);
            this.Controls.Add(this.PreviousFrameBut);
            this.Controls.Add(this.NextFrameBut);
            this.Controls.Add(this.SetFpsBut);
            this.Controls.Add(this.GoToFrameBut);
            this.Controls.Add(this.GoToFrameTextBox);
            this.Controls.Add(this.FPSTextBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FPSTrackBar);
            this.Controls.Add(this.FramesCounterLabel);
            this.Controls.Add(this.StartStopBut);
            this.Controls.Add(this.Field);
            this.Name = "GameScreen";
            this.Text = "GameScreen";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Field)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FPSTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Field;
        private System.Windows.Forms.Button StartStopBut;
        private System.Windows.Forms.Label FramesCounterLabel;
        private System.Windows.Forms.TrackBar FPSTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FPSTextBar;
        private System.Windows.Forms.TextBox GoToFrameTextBox;
        private System.Windows.Forms.Button GoToFrameBut;
        private System.Windows.Forms.Button SetFpsBut;
        private System.Windows.Forms.Button NextFrameBut;
        private System.Windows.Forms.Button PreviousFrameBut;
        private System.Windows.Forms.Button SaveBut;
        private System.Windows.Forms.Button SaveAsBut;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.Button ExitBut;
        private System.Windows.Forms.Label AliveQuadsLabel;
        private System.Windows.Forms.Label BornQuadsLabel;
        private System.Windows.Forms.Label DiedQuadsLabel;
        private System.Windows.Forms.TextBox LogTextbox;
        private System.Windows.Forms.CheckBox EnableLogCheckbox;
    }
}