namespace Pexeso
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewGame = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewGame
            // 
            this.NewGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewGame.Location = new System.Drawing.Point(283, 81);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(213, 50);
            this.NewGame.TabIndex = 0;
            this.NewGame.Text = "New game";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click_1);
            // 
            // Score
            // 
            this.Score.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Score.Cursor = System.Windows.Forms.Cursors.Default;
            this.Score.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Score.Location = new System.Drawing.Point(283, 173);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(213, 50);
            this.Score.TabIndex = 1;
            this.Score.Text = "Score";
            this.Score.UseVisualStyleBackColor = true;
            this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit.Location = new System.Drawing.Point(283, 258);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(213, 50);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 443);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.NewGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button Score;
        private System.Windows.Forms.Button Exit;
    }
}

