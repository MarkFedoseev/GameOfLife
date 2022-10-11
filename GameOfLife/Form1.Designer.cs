namespace GameOfLife
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewGameBut = new System.Windows.Forms.Button();
            this.LoadGameBut = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.ExitBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewGameBut
            // 
            this.NewGameBut.Location = new System.Drawing.Point(12, 12);
            this.NewGameBut.Name = "NewGameBut";
            this.NewGameBut.Size = new System.Drawing.Size(150, 50);
            this.NewGameBut.TabIndex = 0;
            this.NewGameBut.Text = "New game";
            this.NewGameBut.UseVisualStyleBackColor = true;
            this.NewGameBut.Click += new System.EventHandler(this.NewGameBut_Click);
            // 
            // LoadGameBut
            // 
            this.LoadGameBut.Location = new System.Drawing.Point(12, 68);
            this.LoadGameBut.Name = "LoadGameBut";
            this.LoadGameBut.Size = new System.Drawing.Size(150, 50);
            this.LoadGameBut.TabIndex = 1;
            this.LoadGameBut.Text = "Load game";
            this.LoadGameBut.UseVisualStyleBackColor = true;
            this.LoadGameBut.Click += new System.EventHandler(this.LoadGameBut_Click);
            // 
            // OFD
            // 
            this.OFD.DefaultExt = "golsv";
            this.OFD.Filter = "Game of life save file (*.golsv)|*.golsv";
            this.OFD.Title = "Choose save file";
            // 
            // ExitBut
            // 
            this.ExitBut.Location = new System.Drawing.Point(12, 124);
            this.ExitBut.Name = "ExitBut";
            this.ExitBut.Size = new System.Drawing.Size(150, 50);
            this.ExitBut.TabIndex = 2;
            this.ExitBut.Text = "Exit";
            this.ExitBut.UseVisualStyleBackColor = true;
            this.ExitBut.Click += new System.EventHandler(this.ExitBut_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 189);
            this.Controls.Add(this.ExitBut);
            this.Controls.Add(this.LoadGameBut);
            this.Controls.Add(this.NewGameBut);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewGameBut;
        private System.Windows.Forms.Button LoadGameBut;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.Button ExitBut;
    }
}

