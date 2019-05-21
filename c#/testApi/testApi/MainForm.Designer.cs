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
            this.GokkerListBox = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(16, 111);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(186, 23);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Haal teams binnen ";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 95);
            this.listBox1.TabIndex = 1;
            // 
            // GamblerTextbox
            // 
            this.GamblerTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamblerTextbox.Location = new System.Drawing.Point(16, 149);
            this.GamblerTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GamblerTextbox.Multiline = true;
            this.GamblerTextbox.Name = "GamblerTextbox";
            this.GamblerTextbox.Size = new System.Drawing.Size(187, 27);
            this.GamblerTextbox.TabIndex = 2;
            // 
            // GokkerButton
            // 
            this.GokkerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GokkerButton.Location = new System.Drawing.Point(16, 180);
            this.GokkerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GokkerButton.Name = "GokkerButton";
            this.GokkerButton.Size = new System.Drawing.Size(186, 27);
            this.GokkerButton.TabIndex = 3;
            this.GokkerButton.Text = "maak een nieuwe gokker aan";
            this.GokkerButton.UseVisualStyleBackColor = true;
            // 
            // GokkerListBox
            // 
            this.GokkerListBox.FormattingEnabled = true;
            this.GokkerListBox.Location = new System.Drawing.Point(16, 220);
            this.GokkerListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GokkerListBox.Name = "GokkerListBox";
            this.GokkerListBox.Size = new System.Drawing.Size(187, 147);
            this.GokkerListBox.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(220, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(75, 95);
            this.listBox2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Haal wedsrijden binnen ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(331, 11);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(75, 95);
            this.listBox3.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 396);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GokkerListBox);
            this.Controls.Add(this.GokkerButton);
            this.Controls.Add(this.GamblerTextbox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.loadButton);
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
        private System.Windows.Forms.ListBox GokkerListBox;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox3;
    }
}

