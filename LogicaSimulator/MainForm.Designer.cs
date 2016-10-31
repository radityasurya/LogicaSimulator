namespace LogicaSimulator
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbNSimple = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNdisjunc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSimpleDisInfix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSimpleDisPrefix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDisInfix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDisPrefix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnViewTree = new System.Windows.Forms.Button();
            this.btnParse = new System.Windows.Forms.Button();
            this.tbHash = new System.Windows.Forms.TextBox();
            this.lbHash = new System.Windows.Forms.Label();
            this.tbVariables = new System.Windows.Forms.TextBox();
            this.lbVariables = new System.Windows.Forms.Label();
            this.tbInfix = new System.Windows.Forms.TextBox();
            this.lbInfix = new System.Windows.Forms.Label();
            this.tbPrefix = new System.Windows.Forms.TextBox();
            this.lbPrefix = new System.Windows.Forms.Label();
            this.pbTree = new System.Windows.Forms.PictureBox();
            this.lbTree = new System.Windows.Forms.Label();
            this.lbSimplified = new System.Windows.Forms.ListBox();
            this.lbSimple = new System.Windows.Forms.Label();
            this.lbTruth = new System.Windows.Forms.ListBox();
            this.lbTruthTable = new System.Windows.Forms.Label();
            this.tbNandHash = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNandDisjuncHash = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNandSimpleHash = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTree)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel1.Controls.Add(this.tbNandSimpleHash);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.tbNandDisjuncHash);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.tbNandHash);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.tbNSimple);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.tbNdisjunc);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.tbN);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.tbSimpleDisInfix);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.tbSimpleDisPrefix);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.tbDisInfix);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.tbDisPrefix);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnViewTree);
            this.splitContainer1.Panel1.Controls.Add(this.btnParse);
            this.splitContainer1.Panel1.Controls.Add(this.tbHash);
            this.splitContainer1.Panel1.Controls.Add(this.lbHash);
            this.splitContainer1.Panel1.Controls.Add(this.tbVariables);
            this.splitContainer1.Panel1.Controls.Add(this.lbVariables);
            this.splitContainer1.Panel1.Controls.Add(this.tbInfix);
            this.splitContainer1.Panel1.Controls.Add(this.lbInfix);
            this.splitContainer1.Panel1.Controls.Add(this.tbPrefix);
            this.splitContainer1.Panel1.Controls.Add(this.lbPrefix);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.pbTree);
            this.splitContainer1.Panel2.Controls.Add(this.lbTree);
            this.splitContainer1.Panel2.Controls.Add(this.lbSimplified);
            this.splitContainer1.Panel2.Controls.Add(this.lbSimple);
            this.splitContainer1.Panel2.Controls.Add(this.lbTruth);
            this.splitContainer1.Panel2.Controls.Add(this.lbTruthTable);
            this.splitContainer1.Size = new System.Drawing.Size(1260, 613);
            this.splitContainer1.SplitterDistance = 689;
            this.splitContainer1.TabIndex = 0;
            // 
            // tbNSimple
            // 
            this.tbNSimple.BackColor = System.Drawing.Color.Cyan;
            this.tbNSimple.Location = new System.Drawing.Point(29, 433);
            this.tbNSimple.Name = "tbNSimple";
            this.tbNSimple.Size = new System.Drawing.Size(505, 20);
            this.tbNSimple.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "NAND Simplified Prefix";
            // 
            // tbNdisjunc
            // 
            this.tbNdisjunc.BackColor = System.Drawing.Color.Cyan;
            this.tbNdisjunc.Location = new System.Drawing.Point(29, 384);
            this.tbNdisjunc.Name = "tbNdisjunc";
            this.tbNdisjunc.Size = new System.Drawing.Size(505, 20);
            this.tbNdisjunc.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "NAND DisJunc Prefix";
            // 
            // tbN
            // 
            this.tbN.BackColor = System.Drawing.Color.Cyan;
            this.tbN.Location = new System.Drawing.Point(29, 334);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(505, 20);
            this.tbN.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "NAND Prefix";
            // 
            // tbSimpleDisInfix
            // 
            this.tbSimpleDisInfix.BackColor = System.Drawing.Color.SkyBlue;
            this.tbSimpleDisInfix.Location = new System.Drawing.Point(29, 284);
            this.tbSimpleDisInfix.Name = "tbSimpleDisInfix";
            this.tbSimpleDisInfix.Size = new System.Drawing.Size(625, 20);
            this.tbSimpleDisInfix.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Simplified DisJunc Infix";
            // 
            // tbSimpleDisPrefix
            // 
            this.tbSimpleDisPrefix.BackColor = System.Drawing.Color.SkyBlue;
            this.tbSimpleDisPrefix.Location = new System.Drawing.Point(29, 235);
            this.tbSimpleDisPrefix.Name = "tbSimpleDisPrefix";
            this.tbSimpleDisPrefix.Size = new System.Drawing.Size(625, 20);
            this.tbSimpleDisPrefix.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Simplified DisJunc Prefix";
            // 
            // tbDisInfix
            // 
            this.tbDisInfix.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbDisInfix.Location = new System.Drawing.Point(29, 185);
            this.tbDisInfix.Name = "tbDisInfix";
            this.tbDisInfix.Size = new System.Drawing.Size(625, 20);
            this.tbDisInfix.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "DisJunc Infix";
            // 
            // tbDisPrefix
            // 
            this.tbDisPrefix.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbDisPrefix.Location = new System.Drawing.Point(29, 136);
            this.tbDisPrefix.Name = "tbDisPrefix";
            this.tbDisPrefix.Size = new System.Drawing.Size(625, 20);
            this.tbDisPrefix.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "DisJunc Prefix";
            // 
            // btnViewTree
            // 
            this.btnViewTree.BackColor = System.Drawing.Color.DimGray;
            this.btnViewTree.ForeColor = System.Drawing.Color.White;
            this.btnViewTree.Location = new System.Drawing.Point(104, 526);
            this.btnViewTree.Name = "btnViewTree";
            this.btnViewTree.Size = new System.Drawing.Size(464, 38);
            this.btnViewTree.TabIndex = 10;
            this.btnViewTree.Text = "View Tree";
            this.btnViewTree.UseVisualStyleBackColor = false;
            this.btnViewTree.Click += new System.EventHandler(this.btnViewTree_Click);
            // 
            // btnParse
            // 
            this.btnParse.BackColor = System.Drawing.Color.DimGray;
            this.btnParse.ForeColor = System.Drawing.Color.White;
            this.btnParse.Location = new System.Drawing.Point(104, 482);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(464, 38);
            this.btnParse.TabIndex = 9;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = false;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // tbHash
            // 
            this.tbHash.BackColor = System.Drawing.Color.Firebrick;
            this.tbHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHash.ForeColor = System.Drawing.Color.White;
            this.tbHash.Location = new System.Drawing.Point(431, 85);
            this.tbHash.Name = "tbHash";
            this.tbHash.Size = new System.Drawing.Size(103, 20);
            this.tbHash.TabIndex = 8;
            // 
            // lbHash
            // 
            this.lbHash.AutoSize = true;
            this.lbHash.Location = new System.Drawing.Point(428, 69);
            this.lbHash.Name = "lbHash";
            this.lbHash.Size = new System.Drawing.Size(32, 13);
            this.lbHash.TabIndex = 7;
            this.lbHash.Text = "Hash";
            // 
            // tbVariables
            // 
            this.tbVariables.Location = new System.Drawing.Point(300, 85);
            this.tbVariables.Name = "tbVariables";
            this.tbVariables.Size = new System.Drawing.Size(125, 20);
            this.tbVariables.TabIndex = 6;
            // 
            // lbVariables
            // 
            this.lbVariables.AutoSize = true;
            this.lbVariables.Location = new System.Drawing.Point(297, 69);
            this.lbVariables.Name = "lbVariables";
            this.lbVariables.Size = new System.Drawing.Size(50, 13);
            this.lbVariables.TabIndex = 5;
            this.lbVariables.Text = "Variables";
            // 
            // tbInfix
            // 
            this.tbInfix.Location = new System.Drawing.Point(29, 85);
            this.tbInfix.Name = "tbInfix";
            this.tbInfix.Size = new System.Drawing.Size(236, 20);
            this.tbInfix.TabIndex = 4;
            // 
            // lbInfix
            // 
            this.lbInfix.AutoSize = true;
            this.lbInfix.Location = new System.Drawing.Point(26, 69);
            this.lbInfix.Name = "lbInfix";
            this.lbInfix.Size = new System.Drawing.Size(66, 13);
            this.lbInfix.TabIndex = 3;
            this.lbInfix.Text = "Infix Formula";
            // 
            // tbPrefix
            // 
            this.tbPrefix.Location = new System.Drawing.Point(29, 36);
            this.tbPrefix.Name = "tbPrefix";
            this.tbPrefix.Size = new System.Drawing.Size(236, 20);
            this.tbPrefix.TabIndex = 2;
            // 
            // lbPrefix
            // 
            this.lbPrefix.AutoSize = true;
            this.lbPrefix.Location = new System.Drawing.Point(26, 20);
            this.lbPrefix.Name = "lbPrefix";
            this.lbPrefix.Size = new System.Drawing.Size(73, 13);
            this.lbPrefix.TabIndex = 1;
            this.lbPrefix.Text = "Prefix Formula";
            // 
            // pbTree
            // 
            this.pbTree.Location = new System.Drawing.Point(19, 252);
            this.pbTree.Name = "pbTree";
            this.pbTree.Size = new System.Drawing.Size(460, 300);
            this.pbTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbTree.TabIndex = 5;
            this.pbTree.TabStop = false;
            // 
            // lbTree
            // 
            this.lbTree.AutoSize = true;
            this.lbTree.Location = new System.Drawing.Point(16, 235);
            this.lbTree.Name = "lbTree";
            this.lbTree.Size = new System.Drawing.Size(80, 13);
            this.lbTree.TabIndex = 4;
            this.lbTree.Text = "Tree Structures";
            // 
            // lbSimplified
            // 
            this.lbSimplified.FormattingEnabled = true;
            this.lbSimplified.Location = new System.Drawing.Point(290, 36);
            this.lbSimplified.Name = "lbSimplified";
            this.lbSimplified.Size = new System.Drawing.Size(257, 186);
            this.lbSimplified.TabIndex = 3;
            // 
            // lbSimple
            // 
            this.lbSimple.AutoSize = true;
            this.lbSimple.Location = new System.Drawing.Point(287, 20);
            this.lbSimple.Name = "lbSimple";
            this.lbSimple.Size = new System.Drawing.Size(109, 13);
            this.lbSimple.TabIndex = 2;
            this.lbSimple.Text = "Simplified Truth Table";
            // 
            // lbTruth
            // 
            this.lbTruth.DisplayMember = "listBox";
            this.lbTruth.FormattingEnabled = true;
            this.lbTruth.Location = new System.Drawing.Point(19, 36);
            this.lbTruth.Name = "lbTruth";
            this.lbTruth.Size = new System.Drawing.Size(265, 186);
            this.lbTruth.TabIndex = 1;
            this.lbTruth.ValueMember = "listBox";
            // 
            // lbTruthTable
            // 
            this.lbTruthTable.AutoSize = true;
            this.lbTruthTable.Location = new System.Drawing.Point(16, 20);
            this.lbTruthTable.Name = "lbTruthTable";
            this.lbTruthTable.Size = new System.Drawing.Size(62, 13);
            this.lbTruthTable.TabIndex = 0;
            this.lbTruthTable.Text = "Truth Table";
            // 
            // tbNandHash
            // 
            this.tbNandHash.BackColor = System.Drawing.Color.Firebrick;
            this.tbNandHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNandHash.ForeColor = System.Drawing.Color.White;
            this.tbNandHash.Location = new System.Drawing.Point(543, 334);
            this.tbNandHash.Name = "tbNandHash";
            this.tbNandHash.Size = new System.Drawing.Size(111, 20);
            this.tbNandHash.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(540, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Hash";
            // 
            // tbNandDisjuncHash
            // 
            this.tbNandDisjuncHash.BackColor = System.Drawing.Color.Firebrick;
            this.tbNandDisjuncHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNandDisjuncHash.ForeColor = System.Drawing.Color.White;
            this.tbNandDisjuncHash.Location = new System.Drawing.Point(543, 384);
            this.tbNandDisjuncHash.Name = "tbNandDisjuncHash";
            this.tbNandDisjuncHash.Size = new System.Drawing.Size(111, 20);
            this.tbNandDisjuncHash.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(540, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Hash";
            // 
            // tbNandSimpleHash
            // 
            this.tbNandSimpleHash.BackColor = System.Drawing.Color.Firebrick;
            this.tbNandSimpleHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNandSimpleHash.ForeColor = System.Drawing.Color.White;
            this.tbNandSimpleHash.Location = new System.Drawing.Point(543, 433);
            this.tbNandSimpleHash.Name = "tbNandSimpleHash";
            this.tbNandSimpleHash.Size = new System.Drawing.Size(111, 20);
            this.tbNandSimpleHash.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(540, 417);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Hash";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 613);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Logica Simulator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbTruthTable;
        private System.Windows.Forms.Label lbPrefix;
        private System.Windows.Forms.TextBox tbHash;
        private System.Windows.Forms.Label lbHash;
        private System.Windows.Forms.TextBox tbVariables;
        private System.Windows.Forms.Label lbVariables;
        private System.Windows.Forms.TextBox tbInfix;
        private System.Windows.Forms.Label lbInfix;
        private System.Windows.Forms.TextBox tbPrefix;
        private System.Windows.Forms.Button btnViewTree;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.PictureBox pbTree;
        private System.Windows.Forms.Label lbTree;
        private System.Windows.Forms.ListBox lbSimplified;
        private System.Windows.Forms.Label lbSimple;
        private System.Windows.Forms.ListBox lbTruth;
        private System.Windows.Forms.TextBox tbSimpleDisInfix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSimpleDisPrefix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDisInfix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDisPrefix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNSimple;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNdisjunc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNandSimpleHash;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNandDisjuncHash;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNandHash;
        private System.Windows.Forms.Label label8;
    }
}

