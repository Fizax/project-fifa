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
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(22, 137);
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
            this.listBox1.Location = new System.Drawing.Point(22, 13);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(248, 116);
            this.listBox1.TabIndex = 1;
            // 
            // GamblerTextbox
            // 
            this.GamblerTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamblerTextbox.Location = new System.Drawing.Point(22, 183);
            this.GamblerTextbox.Multiline = true;
            this.GamblerTextbox.Name = "GamblerTextbox";
            this.GamblerTextbox.Size = new System.Drawing.Size(248, 32);
            this.GamblerTextbox.TabIndex = 2;
            // 
            // GokkerButton
            // 
            this.GokkerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GokkerButton.Location = new System.Drawing.Point(22, 221);
            this.GokkerButton.Name = "GokkerButton";
            this.GokkerButton.Size = new System.Drawing.Size(248, 33);
            this.GokkerButton.TabIndex = 3;
            this.GokkerButton.Text = "maak een nieuwe gokker aan";
            this.GokkerButton.UseVisualStyleBackColor = true;
            this.GokkerButton.Click += new System.EventHandler(this.GokkerButton_Click);
            // 
            // GokkerListBox
            // 
            this.GokkerListBox.FormattingEnabled = true;
            this.GokkerListBox.ItemHeight = 16;
            this.GokkerListBox.Location = new System.Drawing.Point(22, 271);
            this.GokkerListBox.Name = "GokkerListBox";
            this.GokkerListBox.Size = new System.Drawing.Size(248, 180);
            this.GokkerListBox.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 487);
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
        private System.Windows.Forms.ListBox GokkerListBox;
    }
}

