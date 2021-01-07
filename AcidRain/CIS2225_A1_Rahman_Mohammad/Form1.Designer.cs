namespace CIS2225_A1_Rahman_Mohammad
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
            this.getResult = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputPHLevel = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.displayResults = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // getResult
            // 
            this.getResult.BackColor = System.Drawing.SystemColors.Highlight;
            this.getResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getResult.Location = new System.Drawing.Point(54, 97);
            this.getResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getResult.Name = "getResult";
            this.getResult.Size = new System.Drawing.Size(123, 39);
            this.getResult.TabIndex = 1;
            this.getResult.Text = "Submit";
            this.getResult.UseVisualStyleBackColor = false;
            this.getResult.Click += new System.EventHandler(this.button1_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.SystemColors.Highlight;
            this.reset.Location = new System.Drawing.Point(199, 97);
            this.reset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(125, 39);
            this.reset.TabIndex = 2;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(50, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter pH level\r\n";
            // 
            // inputPHLevel
            // 
            this.inputPHLevel.Location = new System.Drawing.Point(170, 41);
            this.inputPHLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputPHLevel.Name = "inputPHLevel";
            this.inputPHLevel.Size = new System.Drawing.Size(154, 26);
            this.inputPHLevel.TabIndex = 4;
            this.inputPHLevel.Text = "\n";
            this.inputPHLevel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CIS2225_A1_Rahman_Mohammad.Properties.Resources.pHScale;
            this.pictureBox1.Location = new System.Drawing.Point(42, 146);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 68);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // displayResults
            // 
            this.displayResults.Location = new System.Drawing.Point(42, 234);
            this.displayResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.displayResults.Name = "displayResults";
            this.displayResults.Size = new System.Drawing.Size(282, 90);
            this.displayResults.TabIndex = 5;
            this.displayResults.Text = "Result will be displayed here..";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(346, 348);
            this.Controls.Add(this.displayResults);
            this.Controls.Add(this.inputPHLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.getResult);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "pH Level Tracker";
           // this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button getResult;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputPHLevel;
        private System.Windows.Forms.RichTextBox displayResults;
    }
}

