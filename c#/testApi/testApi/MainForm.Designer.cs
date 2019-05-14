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
            this.gokkersGroupBox = new System.Windows.Forms.GroupBox();
            this.GokkerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gokkersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(22, 153);
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
            // gokkersGroupBox
            // 
            this.gokkersGroupBox.Controls.Add(this.label1);
            this.gokkersGroupBox.Controls.Add(this.GokkerButton);
            this.gokkersGroupBox.Location = new System.Drawing.Point(22, 241);
            this.gokkersGroupBox.Name = "gokkersGroupBox";
            this.gokkersGroupBox.Size = new System.Drawing.Size(351, 343);
            this.gokkersGroupBox.TabIndex = 2;
            this.gokkersGroupBox.TabStop = false;
            this.gokkersGroupBox.Text = "Gokkers";
            // 
            // GokkerButton
            // 
            this.GokkerButton.Location = new System.Drawing.Point(6, 21);
            this.GokkerButton.Name = "GokkerButton";
            this.GokkerButton.Size = new System.Drawing.Size(181, 32);
            this.GokkerButton.TabIndex = 0;
            this.GokkerButton.Text = "Gokker toe voegen";
            this.GokkerButton.UseVisualStyleBackColor = true;
            this.GokkerButton.Click += new System.EventHandler(this.GokkerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 604);
            this.Controls.Add(this.gokkersGroupBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.loadButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.gokkersGroupBox.ResumeLayout(false);
            this.gokkersGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox gokkersGroupBox;
        private System.Windows.Forms.Button GokkerButton;
        private System.Windows.Forms.Label label1;
    }
}

