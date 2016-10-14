namespace WiesePA2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vanIce = new System.Windows.Forms.NumericUpDown();
            this.strawIce = new System.Windows.Forms.NumericUpDown();
            this.chocIce = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.peanuts = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fudge = new System.Windows.Forms.CheckBox();
            this.sprinkles = new System.Windows.Forms.CheckBox();
            this.cherries = new System.Windows.Forms.CheckBox();
            this.marshmellow = new System.Windows.Forms.CheckBox();
            this.toffee = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cup = new System.Windows.Forms.RadioButton();
            this.cone = new System.Windows.Forms.RadioButton();
            this.calc = new System.Windows.Forms.Button();
            this.cost = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vanIce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strawIce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chocIce)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.vanIce);
            this.groupBox1.Controls.Add(this.strawIce);
            this.groupBox1.Controls.Add(this.chocIce);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ice Cream";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Strawberry";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chocolate";
            // 
            // vanIce
            // 
            this.vanIce.AutoSize = true;
            this.vanIce.Location = new System.Drawing.Point(448, 48);
            this.vanIce.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.vanIce.Name = "vanIce";
            this.vanIce.Size = new System.Drawing.Size(73, 20);
            this.vanIce.TabIndex = 2;
            // 
            // strawIce
            // 
            this.strawIce.Location = new System.Drawing.Point(239, 48);
            this.strawIce.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.strawIce.Name = "strawIce";
            this.strawIce.Size = new System.Drawing.Size(73, 20);
            this.strawIce.TabIndex = 1;
            // 
            // chocIce
            // 
            this.chocIce.Location = new System.Drawing.Point(54, 48);
            this.chocIce.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.chocIce.Name = "chocIce";
            this.chocIce.Size = new System.Drawing.Size(73, 20);
            this.chocIce.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vanilla";
            // 
            // peanuts
            // 
            this.peanuts.AutoSize = true;
            this.peanuts.Location = new System.Drawing.Point(6, 19);
            this.peanuts.Name = "peanuts";
            this.peanuts.Size = new System.Drawing.Size(65, 17);
            this.peanuts.TabIndex = 5;
            this.peanuts.Text = "Peanuts";
            this.peanuts.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toffee);
            this.groupBox2.Controls.Add(this.marshmellow);
            this.groupBox2.Controls.Add(this.cherries);
            this.groupBox2.Controls.Add(this.sprinkles);
            this.groupBox2.Controls.Add(this.fudge);
            this.groupBox2.Controls.Add(this.peanuts);
            this.groupBox2.Location = new System.Drawing.Point(13, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toppings";
            // 
            // fudge
            // 
            this.fudge.AutoSize = true;
            this.fudge.Location = new System.Drawing.Point(120, 19);
            this.fudge.Name = "fudge";
            this.fudge.Size = new System.Drawing.Size(56, 17);
            this.fudge.TabIndex = 6;
            this.fudge.Text = "Fudge";
            this.fudge.UseVisualStyleBackColor = true;
            // 
            // sprinkles
            // 
            this.sprinkles.AutoSize = true;
            this.sprinkles.Location = new System.Drawing.Point(237, 19);
            this.sprinkles.Name = "sprinkles";
            this.sprinkles.Size = new System.Drawing.Size(69, 17);
            this.sprinkles.TabIndex = 7;
            this.sprinkles.Text = "Sprinkles";
            this.sprinkles.UseVisualStyleBackColor = true;
            // 
            // cherries
            // 
            this.cherries.AutoSize = true;
            this.cherries.Location = new System.Drawing.Point(6, 62);
            this.cherries.Name = "cherries";
            this.cherries.Size = new System.Drawing.Size(64, 17);
            this.cherries.TabIndex = 8;
            this.cherries.Text = "Cherries";
            this.cherries.UseVisualStyleBackColor = true;
            // 
            // marshmellow
            // 
            this.marshmellow.AutoSize = true;
            this.marshmellow.Location = new System.Drawing.Point(120, 62);
            this.marshmellow.Name = "marshmellow";
            this.marshmellow.Size = new System.Drawing.Size(87, 17);
            this.marshmellow.TabIndex = 9;
            this.marshmellow.Text = "Marshmellow";
            this.marshmellow.UseVisualStyleBackColor = true;
            // 
            // toffee
            // 
            this.toffee.AutoSize = true;
            this.toffee.Location = new System.Drawing.Point(237, 62);
            this.toffee.Name = "toffee";
            this.toffee.Size = new System.Drawing.Size(57, 17);
            this.toffee.TabIndex = 10;
            this.toffee.Text = "Toffee";
            this.toffee.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cone);
            this.groupBox3.Controls.Add(this.cup);
            this.groupBox3.Location = new System.Drawing.Point(332, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Apparatus";
            // 
            // cup
            // 
            this.cup.AutoSize = true;
            this.cup.Checked = true;
            this.cup.Location = new System.Drawing.Point(63, 42);
            this.cup.Name = "cup";
            this.cup.Size = new System.Drawing.Size(44, 17);
            this.cup.TabIndex = 0;
            this.cup.TabStop = true;
            this.cup.Text = "Cup";
            this.cup.UseVisualStyleBackColor = true;
            // 
            // cone
            // 
            this.cone.AutoSize = true;
            this.cone.Location = new System.Drawing.Point(185, 42);
            this.cone.Name = "cone";
            this.cone.Size = new System.Drawing.Size(50, 17);
            this.cone.TabIndex = 1;
            this.cone.Text = "Cone";
            this.cone.UseVisualStyleBackColor = true;
            // 
            // calc
            // 
            this.calc.BackColor = System.Drawing.Color.Coral;
            this.calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc.Location = new System.Drawing.Point(151, 282);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(320, 57);
            this.calc.TabIndex = 4;
            this.calc.Text = "Calculate Cost";
            this.calc.UseVisualStyleBackColor = false;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost.Location = new System.Drawing.Point(245, 367);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(115, 39);
            this.cost.TabIndex = 5;
            this.cost.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(640, 485);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ice Cream Shop App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vanIce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strawIce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chocIce)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown vanIce;
        private System.Windows.Forms.NumericUpDown strawIce;
        private System.Windows.Forms.NumericUpDown chocIce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox peanuts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox toffee;
        private System.Windows.Forms.CheckBox marshmellow;
        private System.Windows.Forms.CheckBox cherries;
        private System.Windows.Forms.CheckBox sprinkles;
        private System.Windows.Forms.CheckBox fudge;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton cone;
        private System.Windows.Forms.RadioButton cup;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Label cost;
    }
}

