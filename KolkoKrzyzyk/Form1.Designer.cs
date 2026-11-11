namespace KolkoKrzyzyk
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKoniec = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.score_O = new System.Windows.Forms.Label();
            this.score_Tie = new System.Windows.Forms.Label();
            this.score_X = new System.Windows.Forms.Label();
            this.zeruj = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(412, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(88, 24);
            this.toolStripMenuItem1.Text = "Nowa gra";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 40);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKoniec
            // 
            this.buttonKoniec.Location = new System.Drawing.Point(300, 349);
            this.buttonKoniec.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKoniec.Name = "buttonKoniec";
            this.buttonKoniec.Size = new System.Drawing.Size(100, 28);
            this.buttonKoniec.TabIndex = 2;
            this.buttonKoniec.Text = "koniec";
            this.buttonKoniec.UseVisualStyleBackColor = true;
            this.buttonKoniec.Click += new System.EventHandler(this.buttonKoniec_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.score_X);
            this.groupBox1.Controls.Add(this.score_Tie);
            this.groupBox1.Controls.Add(this.score_O);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 79);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyniki:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Wygrane O";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Remisy";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Wygrane X";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score_O
            // 
            this.score_O.AutoSize = true;
            this.score_O.Location = new System.Drawing.Point(33, 51);
            this.score_O.Name = "score_O";
            this.score_O.Size = new System.Drawing.Size(14, 16);
            this.score_O.TabIndex = 5;
            this.score_O.Text = "0";
            this.score_O.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score_Tie
            // 
            this.score_Tie.AutoSize = true;
            this.score_Tie.Location = new System.Drawing.Point(129, 51);
            this.score_Tie.Name = "score_Tie";
            this.score_Tie.Size = new System.Drawing.Size(14, 16);
            this.score_Tie.TabIndex = 7;
            this.score_Tie.Text = "0";
            this.score_Tie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score_X
            // 
            this.score_X.AutoSize = true;
            this.score_X.Location = new System.Drawing.Point(225, 49);
            this.score_X.Name = "score_X";
            this.score_X.Size = new System.Drawing.Size(14, 16);
            this.score_X.TabIndex = 8;
            this.score_X.Text = "0";
            this.score_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zeruj
            // 
            this.zeruj.Location = new System.Drawing.Point(300, 304);
            this.zeruj.Margin = new System.Windows.Forms.Padding(4);
            this.zeruj.Name = "zeruj";
            this.zeruj.Size = new System.Drawing.Size(100, 28);
            this.zeruj.TabIndex = 5;
            this.zeruj.Text = "Zeruj wyniki";
            this.zeruj.UseVisualStyleBackColor = true;
            this.zeruj.Click += new System.EventHandler(this.zeruj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 384);
            this.Controls.Add(this.zeruj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonKoniec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Kolko i krzyzyk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button buttonKoniec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label score_X;
        private System.Windows.Forms.Label score_Tie;
        private System.Windows.Forms.Label score_O;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button zeruj;
    }
}

