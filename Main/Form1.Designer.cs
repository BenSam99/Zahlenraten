namespace Main
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_Start = new System.Windows.Forms.Button();
            this.TB_Ausgabe = new System.Windows.Forms.TextBox();
            this.TB_Eingabe = new System.Windows.Forms.TextBox();
            this.BT_New = new System.Windows.Forms.Button();
            this.BT_difficulty_1 = new System.Windows.Forms.Button();
            this.BT_Difficulty_2 = new System.Windows.Forms.Button();
            this.BT_Difficulty_3 = new System.Windows.Forms.Button();
            this.BT_Difficulty_4 = new System.Windows.Forms.Button();
            this.BT_Exit = new System.Windows.Forms.Button();
            this.TB_Difficulty = new System.Windows.Forms.TextBox();
            this.TB_Counter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_Start
            // 
            this.Button_Start.Location = new System.Drawing.Point(195, 119);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(77, 20);
            this.Button_Start.TabIndex = 0;
            this.Button_Start.Text = "Start";
            this.Button_Start.UseVisualStyleBackColor = true;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // TB_Ausgabe
            // 
            this.TB_Ausgabe.Location = new System.Drawing.Point(12, 51);
            this.TB_Ausgabe.Multiline = true;
            this.TB_Ausgabe.Name = "TB_Ausgabe";
            this.TB_Ausgabe.ReadOnly = true;
            this.TB_Ausgabe.Size = new System.Drawing.Size(260, 62);
            this.TB_Ausgabe.TabIndex = 1;
            // 
            // TB_Eingabe
            // 
            this.TB_Eingabe.Location = new System.Drawing.Point(12, 119);
            this.TB_Eingabe.Name = "TB_Eingabe";
            this.TB_Eingabe.Size = new System.Drawing.Size(156, 20);
            this.TB_Eingabe.TabIndex = 2;
            this.TB_Eingabe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Eingabe_KeyDown);
            // 
            // BT_New
            // 
            this.BT_New.Location = new System.Drawing.Point(12, 13);
            this.BT_New.Name = "BT_New";
            this.BT_New.Size = new System.Drawing.Size(95, 32);
            this.BT_New.TabIndex = 3;
            this.BT_New.Text = "New Game";
            this.BT_New.UseVisualStyleBackColor = true;
            this.BT_New.Click += new System.EventHandler(this.BT_New_Click);
            // 
            // BT_difficulty_1
            // 
            this.BT_difficulty_1.Location = new System.Drawing.Point(12, 197);
            this.BT_difficulty_1.Name = "BT_difficulty_1";
            this.BT_difficulty_1.Size = new System.Drawing.Size(75, 23);
            this.BT_difficulty_1.TabIndex = 4;
            this.BT_difficulty_1.Text = "Easy";
            this.BT_difficulty_1.UseVisualStyleBackColor = true;
            this.BT_difficulty_1.Click += new System.EventHandler(this.BT_difficulty_1_Click);
            // 
            // BT_Difficulty_2
            // 
            this.BT_Difficulty_2.Location = new System.Drawing.Point(12, 226);
            this.BT_Difficulty_2.Name = "BT_Difficulty_2";
            this.BT_Difficulty_2.Size = new System.Drawing.Size(75, 23);
            this.BT_Difficulty_2.TabIndex = 5;
            this.BT_Difficulty_2.Text = "Normal";
            this.BT_Difficulty_2.UseVisualStyleBackColor = true;
            this.BT_Difficulty_2.Click += new System.EventHandler(this.BT_Difficulty_2_Click);
            // 
            // BT_Difficulty_3
            // 
            this.BT_Difficulty_3.Location = new System.Drawing.Point(93, 197);
            this.BT_Difficulty_3.Name = "BT_Difficulty_3";
            this.BT_Difficulty_3.Size = new System.Drawing.Size(75, 23);
            this.BT_Difficulty_3.TabIndex = 6;
            this.BT_Difficulty_3.Text = "Hard";
            this.BT_Difficulty_3.UseVisualStyleBackColor = true;
            this.BT_Difficulty_3.Click += new System.EventHandler(this.BT_Difficulty_3_Click);
            // 
            // BT_Difficulty_4
            // 
            this.BT_Difficulty_4.Location = new System.Drawing.Point(93, 226);
            this.BT_Difficulty_4.Name = "BT_Difficulty_4";
            this.BT_Difficulty_4.Size = new System.Drawing.Size(75, 23);
            this.BT_Difficulty_4.TabIndex = 7;
            this.BT_Difficulty_4.Text = "Extreme";
            this.BT_Difficulty_4.UseVisualStyleBackColor = true;
            this.BT_Difficulty_4.Click += new System.EventHandler(this.BT_Difficulty_4_Click);
            // 
            // BT_Exit
            // 
            this.BT_Exit.Location = new System.Drawing.Point(195, 13);
            this.BT_Exit.Name = "BT_Exit";
            this.BT_Exit.Size = new System.Drawing.Size(77, 32);
            this.BT_Exit.TabIndex = 8;
            this.BT_Exit.Text = "Exit";
            this.BT_Exit.UseVisualStyleBackColor = true;
            this.BT_Exit.Click += new System.EventHandler(this.BT_Exit_Click);
            // 
            // TB_Difficulty
            // 
            this.TB_Difficulty.Location = new System.Drawing.Point(12, 171);
            this.TB_Difficulty.Name = "TB_Difficulty";
            this.TB_Difficulty.ReadOnly = true;
            this.TB_Difficulty.Size = new System.Drawing.Size(156, 20);
            this.TB_Difficulty.TabIndex = 9;
            // 
            // TB_Counter
            // 
            this.TB_Counter.Location = new System.Drawing.Point(113, 20);
            this.TB_Counter.Name = "TB_Counter";
            this.TB_Counter.ReadOnly = true;
            this.TB_Counter.Size = new System.Drawing.Size(76, 20);
            this.TB_Counter.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TB_Counter);
            this.Controls.Add(this.TB_Difficulty);
            this.Controls.Add(this.BT_Exit);
            this.Controls.Add(this.BT_Difficulty_4);
            this.Controls.Add(this.BT_Difficulty_3);
            this.Controls.Add(this.BT_Difficulty_2);
            this.Controls.Add(this.BT_difficulty_1);
            this.Controls.Add(this.BT_New);
            this.Controls.Add(this.TB_Eingabe);
            this.Controls.Add(this.TB_Ausgabe);
            this.Controls.Add(this.Button_Start);
            this.Name = "Form1";
            this.Text = "Zahlenraten";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.TextBox TB_Ausgabe;
        private System.Windows.Forms.TextBox TB_Eingabe;
        private System.Windows.Forms.Button BT_New;
        private System.Windows.Forms.Button BT_difficulty_1;
        private System.Windows.Forms.Button BT_Difficulty_2;
        private System.Windows.Forms.Button BT_Difficulty_3;
        private System.Windows.Forms.Button BT_Difficulty_4;
        private System.Windows.Forms.Button BT_Exit;
        private System.Windows.Forms.TextBox TB_Difficulty;
        private System.Windows.Forms.TextBox TB_Counter;
    }
}

