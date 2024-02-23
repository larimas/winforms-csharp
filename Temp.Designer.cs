namespace Final_Project
{
    partial class Temp
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.txtboxMessage = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelto = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.radiobtnFtoC = new System.Windows.Forms.RadioButton();
            this.radiobtnCtoF = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(32, 314);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(87, 30);
            this.btnConvert.TabIndex = 23;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(129, 314);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(87, 30);
            this.btnReadFile.TabIndex = 22;
            this.btnReadFile.Text = "&ReadFile";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(226, 314);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 30);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(252, 173);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(16, 16);
            this.labelResult.TabIndex = 20;
            this.labelResult.Text = "F";
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.Location = new System.Drawing.Point(76, 173);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(17, 16);
            this.labelInput.TabIndex = 19;
            this.labelInput.Text = "C";
            // 
            // txtboxMessage
            // 
            this.txtboxMessage.Location = new System.Drawing.Point(34, 224);
            this.txtboxMessage.Multiline = true;
            this.txtboxMessage.Name = "txtboxMessage";
            this.txtboxMessage.ReadOnly = true;
            this.txtboxMessage.Size = new System.Drawing.Size(277, 58);
            this.txtboxMessage.TabIndex = 18;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(31, 204);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(67, 16);
            this.labelMessage.TabIndex = 17;
            this.labelMessage.Text = "Message:";
            // 
            // labelto
            // 
            this.labelto.AutoSize = true;
            this.labelto.Location = new System.Drawing.Point(162, 148);
            this.labelto.Name = "labelto";
            this.labelto.Size = new System.Drawing.Size(18, 16);
            this.labelto.TabIndex = 16;
            this.labelto.Text = "to";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(210, 148);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(100, 22);
            this.txtResult.TabIndex = 15;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(34, 148);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 22);
            this.txtInput.TabIndex = 14;
            // 
            // radiobtnFtoC
            // 
            this.radiobtnFtoC.AutoSize = true;
            this.radiobtnFtoC.Location = new System.Drawing.Point(121, 94);
            this.radiobtnFtoC.Name = "radiobtnFtoC";
            this.radiobtnFtoC.Size = new System.Drawing.Size(96, 20);
            this.radiobtnFtoC.TabIndex = 13;
            this.radiobtnFtoC.TabStop = true;
            this.radiobtnFtoC.Text = "From F to C";
            this.radiobtnFtoC.UseVisualStyleBackColor = true;
            this.radiobtnFtoC.CheckedChanged += new System.EventHandler(this.radiobtnFtoC_CheckedChanged);
            // 
            // radiobtnCtoF
            // 
            this.radiobtnCtoF.AutoSize = true;
            this.radiobtnCtoF.Location = new System.Drawing.Point(121, 57);
            this.radiobtnCtoF.Name = "radiobtnCtoF";
            this.radiobtnCtoF.Size = new System.Drawing.Size(96, 20);
            this.radiobtnCtoF.TabIndex = 12;
            this.radiobtnCtoF.TabStop = true;
            this.radiobtnCtoF.Text = "From C to F";
            this.radiobtnCtoF.UseVisualStyleBackColor = true;
            this.radiobtnCtoF.CheckedChanged += new System.EventHandler(this.radiobtnCtoF_CheckedChanged);
            // 
            // Temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 407);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.txtboxMessage);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelto);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.radiobtnFtoC);
            this.Controls.Add(this.radiobtnCtoF);
            this.Name = "Temp";
            this.Text = "Temp App - Larissa";
            this.Load += new System.EventHandler(this.Temp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox txtboxMessage;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelto;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.RadioButton radiobtnFtoC;
        private System.Windows.Forms.RadioButton radiobtnCtoF;
    }
}