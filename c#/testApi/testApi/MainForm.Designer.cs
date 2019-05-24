namespace testApi
{
    partial class MainForm
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
            this.loadButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GamblerTextbox = new System.Windows.Forms.TextBox();
            this.GokkerButton = new System.Windows.Forms.Button();
            this.Team1ListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Team2ListBox = new System.Windows.Forms.ListBox();
            this.GokkerListBox = new System.Windows.Forms.ListBox();
            this.ScoreListBox = new System.Windows.Forms.ListBox();
            this.ScoreListBox2 = new System.Windows.Forms.ListBox();
            this.CheatTextBox = new System.Windows.Forms.TextBox();
            this.BetButton = new System.Windows.Forms.Button();
            this.BetTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(21, 137);
            this.loadButton.Margin = new System.Windows.Forms.Padding(4);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(248, 28);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Haal teams binnen ";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(21, 14);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(248, 116);
            this.listBox1.TabIndex = 1;
            // 
            // GamblerTextbox
            // 
            this.GamblerTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamblerTextbox.Location = new System.Drawing.Point(21, 183);
            this.GamblerTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GamblerTextbox.Multiline = true;
            this.GamblerTextbox.Name = "GamblerTextbox";
            this.GamblerTextbox.Size = new System.Drawing.Size(248, 32);
            this.GamblerTextbox.TabIndex = 2;
            // 
            // GokkerButton
            // 
            this.GokkerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GokkerButton.Location = new System.Drawing.Point(21, 222);
            this.GokkerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GokkerButton.Name = "GokkerButton";
            this.GokkerButton.Size = new System.Drawing.Size(248, 33);
            this.GokkerButton.TabIndex = 3;
            this.GokkerButton.Text = "maak een nieuwe gokker aan";
            this.GokkerButton.UseVisualStyleBackColor = true;
            this.GokkerButton.Click += new System.EventHandler(this.GokkerButton_Click_1);
            // 
            // Team1ListBox
            // 
            this.Team1ListBox.FormattingEnabled = true;
            this.Team1ListBox.ItemHeight = 16;
            this.Team1ListBox.Location = new System.Drawing.Point(293, 15);
            this.Team1ListBox.Margin = new System.Windows.Forms.Padding(4);
            this.Team1ListBox.Name = "Team1ListBox";
            this.Team1ListBox.Size = new System.Drawing.Size(99, 308);
            this.Team1ListBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 326);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Haal wedsrijden binnen ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Team2ListBox
            // 
            this.Team2ListBox.FormattingEnabled = true;
            this.Team2ListBox.ItemHeight = 16;
            this.Team2ListBox.Location = new System.Drawing.Point(503, 15);
            this.Team2ListBox.Margin = new System.Windows.Forms.Padding(4);
            this.Team2ListBox.Name = "Team2ListBox";
            this.Team2ListBox.Size = new System.Drawing.Size(99, 308);
            this.Team2ListBox.TabIndex = 7;
            // 
            // GokkerListBox
            // 
            this.GokkerListBox.FormattingEnabled = true;
            this.GokkerListBox.ItemHeight = 16;
            this.GokkerListBox.Location = new System.Drawing.Point(21, 278);
            this.GokkerListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GokkerListBox.Name = "GokkerListBox";
            this.GokkerListBox.Size = new System.Drawing.Size(248, 196);
            this.GokkerListBox.TabIndex = 4;
            // 
            // ScoreListBox
            // 
            this.ScoreListBox.FormattingEnabled = true;
            this.ScoreListBox.ItemHeight = 16;
            this.ScoreListBox.Location = new System.Drawing.Point(400, 14);
            this.ScoreListBox.Name = "ScoreListBox";
            this.ScoreListBox.Size = new System.Drawing.Size(43, 308);
            this.ScoreListBox.TabIndex = 11;
            // 
            // ScoreListBox2
            // 
            this.ScoreListBox2.FormattingEnabled = true;
            this.ScoreListBox2.ItemHeight = 16;
            this.ScoreListBox2.Location = new System.Drawing.Point(450, 13);
            this.ScoreListBox2.Name = "ScoreListBox2";
            this.ScoreListBox2.Size = new System.Drawing.Size(45, 308);
            this.ScoreListBox2.TabIndex = 12;
            // 
            // CheatTextBox
            // 
            this.CheatTextBox.Location = new System.Drawing.Point(293, 452);
            this.CheatTextBox.Name = "CheatTextBox";
            this.CheatTextBox.Size = new System.Drawing.Size(75, 22);
            this.CheatTextBox.TabIndex = 13;
            // 
            // BetButton
            // 
            this.BetButton.Location = new System.Drawing.Point(293, 374);
            this.BetButton.Name = "BetButton";
            this.BetButton.Size = new System.Drawing.Size(99, 23);
            this.BetButton.TabIndex = 14;
            this.BetButton.Text = "blaats bot";
            this.BetButton.UseVisualStyleBackColor = true;
            this.BetButton.Click += new System.EventHandler(this.BetButton_Click);
            // 
            // BetTextBox
            // 
            this.BetTextBox.Location = new System.Drawing.Point(400, 374);
            this.BetTextBox.Name = "BetTextBox";
            this.BetTextBox.Size = new System.Drawing.Size(100, 22);
            this.BetTextBox.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 496);
            this.Controls.Add(this.BetTextBox);
            this.Controls.Add(this.BetButton);
            this.Controls.Add(this.CheatTextBox);
            this.Controls.Add(this.ScoreListBox2);
            this.Controls.Add(this.ScoreListBox);
            this.Controls.Add(this.Team2ListBox);
            this.Controls.Add(this.Team1ListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GokkerListBox);
            this.Controls.Add(this.GokkerButton);
            this.Controls.Add(this.GamblerTextbox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.loadButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox GamblerTextbox;
        private System.Windows.Forms.Button GokkerButton;
        private System.Windows.Forms.ListBox Team1ListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox Team2ListBox;
        private System.Windows.Forms.ListBox GokkerListBox;
        private System.Windows.Forms.ListBox ScoreListBox;
        private System.Windows.Forms.ListBox ScoreListBox2;
        private System.Windows.Forms.TextBox CheatTextBox;
        private System.Windows.Forms.Button BetButton;
        private System.Windows.Forms.TextBox BetTextBox;
    }
}

