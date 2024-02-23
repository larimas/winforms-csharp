namespace Final_Project
{
    partial class L649
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(L649));
            this.btnreadfile = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.showbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.showNumbers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnreadfile
            // 
            this.btnreadfile.Location = new System.Drawing.Point(183, 299);
            this.btnreadfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnreadfile.Name = "btnreadfile";
            this.btnreadfile.Size = new System.Drawing.Size(95, 23);
            this.btnreadfile.TabIndex = 22;
            this.btnreadfile.Text = "&Read File";
            this.btnreadfile.UseVisualStyleBackColor = true;
            this.btnreadfile.Click += new System.EventHandler(this.btnreadfile_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(72, 299);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(95, 23);
            this.btnGenerate.TabIndex = 21;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(294, 299);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 23);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // showbox
            // 
            this.showbox.Location = new System.Drawing.Point(294, 79);
            this.showbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showbox.Multiline = true;
            this.showbox.Name = "showbox";
            this.showbox.ReadOnly = true;
            this.showbox.Size = new System.Drawing.Size(93, 179);
            this.showbox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "The winning numbers are:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(72, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 179);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showNumbers
            // 
            this.showNumbers.AutoSize = true;
            this.showNumbers.Location = new System.Drawing.Point(123, 261);
            this.showNumbers.Name = "showNumbers";
            this.showNumbers.Size = new System.Drawing.Size(0, 16);
            this.showNumbers.TabIndex = 24;
            // 
            // L649
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 418);
            this.Controls.Add(this.showNumbers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnreadfile);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.showbox);
            this.Controls.Add(this.label2);
            this.Name = "L649";
            this.Text = "Lotto 649 - Larissa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnreadfile;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox showbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label showNumbers;
    }
}