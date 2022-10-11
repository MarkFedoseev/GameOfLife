namespace GameOfLife
{
    partial class NewGameSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.RB1x1 = new System.Windows.Forms.RadioButton();
            this.RB3x3 = new System.Windows.Forms.RadioButton();
            this.RB5x5 = new System.Windows.Forms.RadioButton();
            this.SaveBut = new System.Windows.Forms.Button();
            this.LoadBut = new System.Windows.Forms.Button();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.SaveAsBut = new System.Windows.Forms.Button();
            this.ExitBut = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Field)).BeginInit();
            this.SuspendLayout();
            // 
            // Field
            // 
            this.Field.Location = new System.Drawing.Point(13, 13);
            this.Field.Name = "Field";
            this.Field.Size = new System.Drawing.Size(750, 750);
            this.Field.TabIndex = 0;
            this.Field.TabStop = false;
            this.Field.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Field_MouseDown);
            this.Field.MouseLeave += new System.EventHandler(this.Field_MouseLeave);
            this.Field.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Field_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(769, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brush size";
            // 
            // RB1x1
            // 
            this.RB1x1.AutoSize = true;
            this.RB1x1.Location = new System.Drawing.Point(773, 377);
            this.RB1x1.Name = "RB1x1";
            this.RB1x1.Size = new System.Drawing.Size(42, 17);
            this.RB1x1.TabIndex = 2;
            this.RB1x1.TabStop = true;
            this.RB1x1.Text = "1x1";
            this.RB1x1.UseVisualStyleBackColor = true;
            // 
            // RB3x3
            // 
            this.RB3x3.AutoSize = true;
            this.RB3x3.Location = new System.Drawing.Point(821, 377);
            this.RB3x3.Name = "RB3x3";
            this.RB3x3.Size = new System.Drawing.Size(42, 17);
            this.RB3x3.TabIndex = 3;
            this.RB3x3.TabStop = true;
            this.RB3x3.Text = "3x3";
            this.RB3x3.UseVisualStyleBackColor = true;
            // 
            // RB5x5
            // 
            this.RB5x5.AutoSize = true;
            this.RB5x5.Location = new System.Drawing.Point(869, 377);
            this.RB5x5.Name = "RB5x5";
            this.RB5x5.Size = new System.Drawing.Size(42, 17);
            this.RB5x5.TabIndex = 4;
            this.RB5x5.TabStop = true;
            this.RB5x5.Text = "5x5";
            this.RB5x5.UseVisualStyleBackColor = true;
            // 
            // SaveBut
            // 
            this.SaveBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBut.Location = new System.Drawing.Point(773, 190);
            this.SaveBut.Name = "SaveBut";
            this.SaveBut.Size = new System.Drawing.Size(150, 50);
            this.SaveBut.TabIndex = 5;
            this.SaveBut.Text = "Save";
            this.SaveBut.UseVisualStyleBackColor = true;
            this.SaveBut.Click += new System.EventHandler(this.SaveBut_Click);
            // 
            // LoadBut
            // 
            this.LoadBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadBut.Location = new System.Drawing.Point(773, 302);
            this.LoadBut.Name = "LoadBut";
            this.LoadBut.Size = new System.Drawing.Size(150, 50);
            this.LoadBut.TabIndex = 6;
            this.LoadBut.Text = "Load";
            this.LoadBut.UseVisualStyleBackColor = true;
            this.LoadBut.Click += new System.EventHandler(this.LoadBut_Click);
            // 
            // SFD
            // 
            this.SFD.DefaultExt = "golsv";
            this.SFD.Filter = "Game of life save file (*.golsv)|*.golsv";
            this.SFD.Title = "SOS! Someone save me please!";
            // 
            // SaveAsBut
            // 
            this.SaveAsBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAsBut.Location = new System.Drawing.Point(773, 246);
            this.SaveAsBut.Name = "SaveAsBut";
            this.SaveAsBut.Size = new System.Drawing.Size(150, 50);
            this.SaveAsBut.TabIndex = 7;
            this.SaveAsBut.Text = "Save as";
            this.SaveAsBut.UseVisualStyleBackColor = true;
            this.SaveAsBut.Click += new System.EventHandler(this.SaveAsBut_Click);
            // 
            // ExitBut
            // 
            this.ExitBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBut.Font = new System.Drawing.Font("Miramonte", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBut.Location = new System.Drawing.Point(769, 713);
            this.ExitBut.Name = "ExitBut";
            this.ExitBut.Size = new System.Drawing.Size(150, 50);
            this.ExitBut.TabIndex = 8;
            this.ExitBut.Text = "Exit";
            this.ExitBut.UseVisualStyleBackColor = true;
            this.ExitBut.Click += new System.EventHandler(this.ExitBut_Click);
            // 
            // OFD
            // 
            this.OFD.DefaultExt = "golsv";
            this.OFD.Filter = "Game of life save file (*.golsv)|*.golsv";
            this.OFD.Title = "Choose save file";
            // 
            // NewGameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 812);
            this.Controls.Add(this.ExitBut);
            this.Controls.Add(this.SaveAsBut);
            this.Controls.Add(this.LoadBut);
            this.Controls.Add(this.SaveBut);
            this.Controls.Add(this.RB5x5);
            this.Controls.Add(this.RB3x3);
            this.Controls.Add(this.RB1x1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Field);
            this.Name = "NewGameSettings";
            this.Text = "NewGameSettings";
            this.Load += new System.EventHandler(this.NewGameSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Field)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Field;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RB1x1;
        private System.Windows.Forms.RadioButton RB3x3;
        private System.Windows.Forms.RadioButton RB5x5;
        private System.Windows.Forms.Button SaveBut;
        private System.Windows.Forms.Button LoadBut;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.Button SaveAsBut;
        private System.Windows.Forms.Button ExitBut;
        private System.Windows.Forms.OpenFileDialog OFD;
    }
}