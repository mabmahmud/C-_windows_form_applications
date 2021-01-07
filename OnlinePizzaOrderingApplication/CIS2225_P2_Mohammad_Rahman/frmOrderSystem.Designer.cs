namespace CIS2225_P2_Mohammad_Rahman
{
    partial class frmOrderSystem
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.groupBoxMealType = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFishQty = new System.Windows.Forms.TextBox();
            this.txtSubQty = new System.Windows.Forms.TextBox();
            this.txtHamQty = new System.Windows.Forms.TextBox();
            this.checkBoxFish = new System.Windows.Forms.CheckBox();
            this.checkBoxSub = new System.Windows.Forms.CheckBox();
            this.checkBoxHam = new System.Windows.Forms.CheckBox();
            this.cmbMealSelection = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBoxMealType.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.orderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(548, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeOrderToolStripMenuItem,
            this.checkOrderToolStripMenuItem});
            this.orderToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(63, 25);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // placeOrderToolStripMenuItem
            // 
            this.placeOrderToolStripMenuItem.Name = "placeOrderToolStripMenuItem";
            this.placeOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.placeOrderToolStripMenuItem.Text = "Place Order";
            this.placeOrderToolStripMenuItem.Click += new System.EventHandler(this.placeOrderToolStripMenuItem_Click);
            // 
            // checkOrderToolStripMenuItem
            // 
            this.checkOrderToolStripMenuItem.Name = "checkOrderToolStripMenuItem";
            this.checkOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.checkOrderToolStripMenuItem.Text = "Check Order";
            this.checkOrderToolStripMenuItem.Click += new System.EventHandler(this.checkOrderToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(186, 65);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(139, 24);
            this.txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(186, 111);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(139, 24);
            this.txtFirstName.TabIndex = 4;
            // 
            // groupBoxMealType
            // 
            this.groupBoxMealType.Controls.Add(this.label3);
            this.groupBoxMealType.Controls.Add(this.txtFishQty);
            this.groupBoxMealType.Controls.Add(this.txtSubQty);
            this.groupBoxMealType.Controls.Add(this.txtHamQty);
            this.groupBoxMealType.Controls.Add(this.checkBoxFish);
            this.groupBoxMealType.Controls.Add(this.checkBoxSub);
            this.groupBoxMealType.Controls.Add(this.checkBoxHam);
            this.groupBoxMealType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMealType.Location = new System.Drawing.Point(97, 183);
            this.groupBoxMealType.Name = "groupBoxMealType";
            this.groupBoxMealType.Size = new System.Drawing.Size(298, 141);
            this.groupBoxMealType.TabIndex = 5;
            this.groupBoxMealType.TabStop = false;
            this.groupBoxMealType.Text = "Meal Type Options";
            this.groupBoxMealType.Enter += new System.EventHandler(this.groupBoxMealType_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity";
            // 
            // txtFishQty
            // 
            this.txtFishQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFishQty.Location = new System.Drawing.Point(174, 108);
            this.txtFishQty.Name = "txtFishQty";
            this.txtFishQty.Size = new System.Drawing.Size(89, 24);
            this.txtFishQty.TabIndex = 8;
            // 
            // txtSubQty
            // 
            this.txtSubQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubQty.Location = new System.Drawing.Point(174, 79);
            this.txtSubQty.Name = "txtSubQty";
            this.txtSubQty.Size = new System.Drawing.Size(89, 24);
            this.txtSubQty.TabIndex = 7;
            // 
            // txtHamQty
            // 
            this.txtHamQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHamQty.Location = new System.Drawing.Point(174, 50);
            this.txtHamQty.Name = "txtHamQty";
            this.txtHamQty.Size = new System.Drawing.Size(89, 24);
            this.txtHamQty.TabIndex = 6;
            // 
            // checkBoxFish
            // 
            this.checkBoxFish.AutoSize = true;
            this.checkBoxFish.Location = new System.Drawing.Point(17, 108);
            this.checkBoxFish.Name = "checkBoxFish";
            this.checkBoxFish.Size = new System.Drawing.Size(105, 22);
            this.checkBoxFish.TabIndex = 2;
            this.checkBoxFish.Text = "Fish ($8.00)";
            this.checkBoxFish.UseVisualStyleBackColor = true;
            // 
            // checkBoxSub
            // 
            this.checkBoxSub.AutoSize = true;
            this.checkBoxSub.Location = new System.Drawing.Point(17, 78);
            this.checkBoxSub.Name = "checkBoxSub";
            this.checkBoxSub.Size = new System.Drawing.Size(103, 22);
            this.checkBoxSub.TabIndex = 1;
            this.checkBoxSub.Text = "Sub ($6.00)";
            this.checkBoxSub.UseVisualStyleBackColor = true;
            // 
            // checkBoxHam
            // 
            this.checkBoxHam.AutoSize = true;
            this.checkBoxHam.Location = new System.Drawing.Point(17, 50);
            this.checkBoxHam.Name = "checkBoxHam";
            this.checkBoxHam.Size = new System.Drawing.Size(151, 22);
            this.checkBoxHam.TabIndex = 0;
            this.checkBoxHam.Text = "Hamburger ($5.00)";
            this.checkBoxHam.UseVisualStyleBackColor = true;
            this.checkBoxHam.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cmbMealSelection
            // 
            this.cmbMealSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMealSelection.FormattingEnabled = true;
            this.cmbMealSelection.Items.AddRange(new object[] {
            "Meal only",
            "Combo Meal",
            "Upsize Combo Meal"});
            this.cmbMealSelection.Location = new System.Drawing.Point(368, 111);
            this.cmbMealSelection.Name = "cmbMealSelection";
            this.cmbMealSelection.Size = new System.Drawing.Size(165, 26);
            this.cmbMealSelection.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(378, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select Combo Option ";
            // 
            // frmOrderSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 369);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMealSelection);
            this.Controls.Add(this.groupBoxMealType);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmOrderSystem";
            this.Text = "Fast Food Drive-Thru Order System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxMealType.ResumeLayout(false);
            this.groupBoxMealType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOrderToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox groupBoxMealType;
        private System.Windows.Forms.CheckBox checkBoxHam;
        private System.Windows.Forms.CheckBox checkBoxFish;
        private System.Windows.Forms.CheckBox checkBoxSub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFishQty;
        private System.Windows.Forms.TextBox txtSubQty;
        private System.Windows.Forms.TextBox txtHamQty;
        private System.Windows.Forms.ComboBox cmbMealSelection;
        private System.Windows.Forms.Label label4;
    }
}

