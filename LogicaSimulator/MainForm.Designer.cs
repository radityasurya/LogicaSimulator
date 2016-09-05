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
            this.lbPrefix = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.lbTruthTable = new System.Windows.Forms.Label();
            this.tbPrefix = new System.Windows.Forms.TextBox();
            this.tbInfix = new System.Windows.Forms.TextBox();
            this.lbInfix = new System.Windows.Forms.Label();
            this.tbVariables = new System.Windows.Forms.TextBox();
            this.lbVariables = new System.Windows.Forms.Label();
            this.tbHash = new System.Windows.Forms.TextBox();
            this.lbHash = new System.Windows.Forms.Label();
            this.btnParse = new System.Windows.Forms.Button();
            this.btnViewTree = new System.Windows.Forms.Button();
            this.lbTruth = new System.Windows.Forms.ListBox();
            this.lbSimplified = new System.Windows.Forms.ListBox();
            this.lbSimple = new System.Windows.Forms.Label();
            this.lbTree = new System.Windows.Forms.Label();
            this.pbTree = new System.Windows.Forms.PictureBox();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnRandom);
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
            this.splitContainer1.Size = new System.Drawing.Size(784, 561);
            this.splitContainer1.SplitterDistance = 289;
            this.splitContainer1.TabIndex = 0;
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
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.DimGray;
            this.btnRandom.ForeColor = System.Drawing.Color.White;
            this.btnRandom.Location = new System.Drawing.Point(29, 466);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(236, 38);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "Randomize";
            this.btnRandom.UseVisualStyleBackColor = false;
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
            // tbPrefix
            // 
            this.tbPrefix.Location = new System.Drawing.Point(29, 36);
            this.tbPrefix.Name = "tbPrefix";
            this.tbPrefix.Size = new System.Drawing.Size(236, 20);
            this.tbPrefix.TabIndex = 2;
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
            // tbVariables
            // 
            this.tbVariables.Location = new System.Drawing.Point(29, 135);
            this.tbVariables.Name = "tbVariables";
            this.tbVariables.Size = new System.Drawing.Size(125, 20);
            this.tbVariables.TabIndex = 6;
            // 
            // lbVariables
            // 
            this.lbVariables.AutoSize = true;
            this.lbVariables.Location = new System.Drawing.Point(26, 119);
            this.lbVariables.Name = "lbVariables";
            this.lbVariables.Size = new System.Drawing.Size(50, 13);
            this.lbVariables.TabIndex = 5;
            this.lbVariables.Text = "Variables";
            // 
            // tbHash
            // 
            this.tbHash.BackColor = System.Drawing.Color.Firebrick;
            this.tbHash.Location = new System.Drawing.Point(160, 135);
            this.tbHash.Name = "tbHash";
            this.tbHash.Size = new System.Drawing.Size(103, 20);
            this.tbHash.TabIndex = 8;
            // 
            // lbHash
            // 
            this.lbHash.AutoSize = true;
            this.lbHash.Location = new System.Drawing.Point(157, 119);
            this.lbHash.Name = "lbHash";
            this.lbHash.Size = new System.Drawing.Size(32, 13);
            this.lbHash.TabIndex = 7;
            this.lbHash.Text = "Hash";
            // 
            // btnParse
            // 
            this.btnParse.BackColor = System.Drawing.Color.DimGray;
            this.btnParse.ForeColor = System.Drawing.Color.White;
            this.btnParse.Location = new System.Drawing.Point(29, 422);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(236, 38);
            this.btnParse.TabIndex = 9;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = false;
            // 
            // btnViewTree
            // 
            this.btnViewTree.BackColor = System.Drawing.Color.DimGray;
            this.btnViewTree.ForeColor = System.Drawing.Color.White;
            this.btnViewTree.Location = new System.Drawing.Point(29, 510);
            this.btnViewTree.Name = "btnViewTree";
            this.btnViewTree.Size = new System.Drawing.Size(236, 38);
            this.btnViewTree.TabIndex = 10;
            this.btnViewTree.Text = "View Tree";
            this.btnViewTree.UseVisualStyleBackColor = false;
            // 
            // lbTruth
            // 
            this.lbTruth.DisplayMember = "listBox";
            this.lbTruth.FormattingEnabled = true;
            this.lbTruth.Location = new System.Drawing.Point(19, 36);
            this.lbTruth.Name = "lbTruth";
            this.lbTruth.Size = new System.Drawing.Size(109, 225);
            this.lbTruth.TabIndex = 1;
            this.lbTruth.ValueMember = "listBox";
            // 
            // lbSimplified
            // 
            this.lbSimplified.FormattingEnabled = true;
            this.lbSimplified.Location = new System.Drawing.Point(137, 36);
            this.lbSimplified.Name = "lbSimplified";
            this.lbSimplified.Size = new System.Drawing.Size(109, 225);
            this.lbSimplified.TabIndex = 3;
            // 
            // lbSimple
            // 
            this.lbSimple.AutoSize = true;
            this.lbSimple.Location = new System.Drawing.Point(134, 20);
            this.lbSimple.Name = "lbSimple";
            this.lbSimple.Size = new System.Drawing.Size(109, 13);
            this.lbSimple.TabIndex = 2;
            this.lbSimple.Text = "Simplified Truth Table";
            // 
            // lbTree
            // 
            this.lbTree.AutoSize = true;
            this.lbTree.Location = new System.Drawing.Point(16, 275);
            this.lbTree.Name = "lbTree";
            this.lbTree.Size = new System.Drawing.Size(80, 13);
            this.lbTree.TabIndex = 4;
            this.lbTree.Text = "Tree Structures";
            // 
            // pbTree
            // 
            this.pbTree.Location = new System.Drawing.Point(19, 292);
            this.pbTree.Name = "pbTree";
            this.pbTree.Size = new System.Drawing.Size(460, 256);
            this.pbTree.TabIndex = 5;
            this.pbTree.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
        private System.Windows.Forms.Button btnRandom;
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
    }
}

