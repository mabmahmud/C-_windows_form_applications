namespace CIS_2225_Test3_Mohamad_Rahman
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnSeniorAgent = new System.Windows.Forms.RadioButton();
            this.rbtnAgent = new System.Windows.Forms.RadioButton();
            this.rbtnJuniorAgent = new System.Windows.Forms.RadioButton();
            this.txtSalesAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.richTextResult = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(175, 45);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(168, 26);
            this.txtLastName.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(175, 139);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(168, 26);
            this.txtEmail.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(175, 93);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(168, 26);
            this.txtFirstName.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnSeniorAgent);
            this.groupBox1.Controls.Add(this.rbtnAgent);
            this.groupBox1.Controls.Add(this.rbtnJuniorAgent);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(81, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 140);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agent Type";
            // 
            // rbtnSeniorAgent
            // 
            this.rbtnSeniorAgent.AutoSize = true;
            this.rbtnSeniorAgent.Location = new System.Drawing.Point(20, 95);
            this.rbtnSeniorAgent.Name = "rbtnSeniorAgent";
            this.rbtnSeniorAgent.Size = new System.Drawing.Size(120, 24);
            this.rbtnSeniorAgent.TabIndex = 2;
            this.rbtnSeniorAgent.TabStop = true;
            this.rbtnSeniorAgent.Text = "Senior Agent";
            this.rbtnSeniorAgent.UseVisualStyleBackColor = true;
            // 
            // rbtnAgent
            // 
            this.rbtnAgent.AutoSize = true;
            this.rbtnAgent.Location = new System.Drawing.Point(20, 65);
            this.rbtnAgent.Name = "rbtnAgent";
            this.rbtnAgent.Size = new System.Drawing.Size(70, 24);
            this.rbtnAgent.TabIndex = 1;
            this.rbtnAgent.TabStop = true;
            this.rbtnAgent.Text = "Agent";
            this.rbtnAgent.UseVisualStyleBackColor = true;
            // 
            // rbtnJuniorAgent
            // 
            this.rbtnJuniorAgent.AutoSize = true;
            this.rbtnJuniorAgent.Location = new System.Drawing.Point(20, 32);
            this.rbtnJuniorAgent.Name = "rbtnJuniorAgent";
            this.rbtnJuniorAgent.Size = new System.Drawing.Size(117, 24);
            this.rbtnJuniorAgent.TabIndex = 0;
            this.rbtnJuniorAgent.TabStop = true;
            this.rbtnJuniorAgent.Text = "Junior Agent";
            this.rbtnJuniorAgent.UseVisualStyleBackColor = true;
            // 
            // txtSalesAmount
            // 
            this.txtSalesAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesAmount.Location = new System.Drawing.Point(175, 361);
            this.txtSalesAmount.Name = "txtSalesAmount";
            this.txtSalesAmount.Size = new System.Drawing.Size(168, 26);
            this.txtSalesAmount.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sales Amount";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(123, 415);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(198, 52);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // richTextResult
            // 
            this.richTextResult.AutoWordSelection = true;
            this.richTextResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextResult.Location = new System.Drawing.Point(406, 47);
            this.richTextResult.Name = "richTextResult";
            this.richTextResult.Size = new System.Drawing.Size(258, 420);
            this.richTextResult.TabIndex = 10;
            this.richTextResult.Text = "";
            this.richTextResult.HideSelectionChanged += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 489);
            this.Controls.Add(this.richTextResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSalesAmount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Sales Agent Commission Incomes Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnSeniorAgent;
        private System.Windows.Forms.RadioButton rbtnAgent;
        private System.Windows.Forms.RadioButton rbtnJuniorAgent;
        private System.Windows.Forms.TextBox txtSalesAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RichTextBox richTextResult;
    }
}

