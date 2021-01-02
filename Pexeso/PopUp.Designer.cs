namespace Pexeso
{
    partial class PopUp
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
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveScoreButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.JmenoHrace = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 130);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveScoreButton
            // 
            this.SaveScoreButton.Location = new System.Drawing.Point(194, 130);
            this.SaveScoreButton.Name = "SaveScoreButton";
            this.SaveScoreButton.Size = new System.Drawing.Size(75, 23);
            this.SaveScoreButton.TabIndex = 1;
            this.SaveScoreButton.Text = "Save Score";
            this.SaveScoreButton.UseVisualStyleBackColor = true;
            this.SaveScoreButton.Click += new System.EventHandler(this.SaveScoreButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(377, 130);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(191, 46);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(46, 17);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "label1";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JmenoHrace
            // 
            this.JmenoHrace.Location = new System.Drawing.Point(194, 67);
            this.JmenoHrace.Name = "JmenoHrace";
            this.JmenoHrace.Size = new System.Drawing.Size(100, 22);
            this.JmenoHrace.TabIndex = 4;
            this.JmenoHrace.Text = "vaše jméno";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(301, 67);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(36, 22);
            this.OK.TabIndex = 5;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // PopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 183);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.JmenoHrace);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SaveScoreButton);
            this.Controls.Add(this.BackButton);
            this.Name = "PopUp";
            this.Text = "PopUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveScoreButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.TextBox JmenoHrace;
        private System.Windows.Forms.Button OK;
    }
}