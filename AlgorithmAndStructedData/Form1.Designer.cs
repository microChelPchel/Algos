namespace AlgorithmAndStructedData
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Алгоритмы");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Структуры данных");
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.AlgorithmPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(193)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 768);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Меню";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(193)))), ((int)(((byte)(221)))));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.Location = new System.Drawing.Point(3, 48);
            this.treeView1.Name = "treeView1";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Алгоритмы";
            treeNode4.Name = "Node1";
            treeNode4.Text = "Структуры данных";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(281, 708);
            this.treeView1.TabIndex = 1;
            // 
            // AlgorithmPanel
            // 
            this.AlgorithmPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlgorithmPanel.Location = new System.Drawing.Point(287, 0);
            this.AlgorithmPanel.Name = "AlgorithmPanel";
            this.AlgorithmPanel.Size = new System.Drawing.Size(1095, 768);
            this.AlgorithmPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 768);
            this.Controls.Add(this.AlgorithmPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Справочник алгоритмов и структур данных";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel AlgorithmPanel;
    }
}

