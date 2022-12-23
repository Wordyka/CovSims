namespace CovSims
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPath = new System.Windows.Forms.Label();
            this.lblNodes = new System.Windows.Forms.Label();
            this.lblRoot = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtNodesPath = new System.Windows.Forms.TextBox();
            this.txtListNodes = new System.Windows.Forms.ListBox();
            this.txtRoot = new System.Windows.Forms.TextBox();
            this.txtNodes = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtListTotal = new System.Windows.Forms.ListBox();
            this.btnSubmitBFS = new System.Windows.Forms.Button();
            this.btnAddNodes = new System.Windows.Forms.Button();
            this.btnAddNodesPath = new System.Windows.Forms.Button();
            this.bgGraph = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(16, 14);
            this.lblPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(116, 20);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "Path of two nodes:";
            // 
            // lblNodes
            // 
            this.lblNodes.AutoSize = true;
            this.lblNodes.Location = new System.Drawing.Point(16, 77);
            this.lblNodes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNodes.Name = "lblNodes";
            this.lblNodes.Size = new System.Drawing.Size(377, 20);
            this.lblNodes.TabIndex = 2;
            this.lblNodes.Text = "Chance of the path in decimal:";
            // 
            // lblRoot
            // 
            this.lblRoot.AutoSize = true;
            this.lblRoot.Location = new System.Drawing.Point(16, 400);
            this.lblRoot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoot.Name = "lblRoot";
            this.lblRoot.Size = new System.Drawing.Size(196, 20);
            this.lblRoot.TabIndex = 2;
            this.lblRoot.Text = "Root of Graph:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(16, 460);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(267, 20);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Insert node and it's value:";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(16, 740);
            this.lblDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(267, 20);
            this.lblDays.TabIndex = 2;
            this.lblDays.Text = "Number of days to calculate:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(20, 38);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(399, 27);
            this.txtPath.TabIndex = 2;
            // 
            // txtNodesPath
            // 
            this.txtNodesPath.Location = new System.Drawing.Point(20, 100);
            this.txtNodesPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNodesPath.Name = "txtNodesPath";
            this.txtNodesPath.Size = new System.Drawing.Size(399, 27);
            this.txtNodesPath.TabIndex = 2;
            // 
            // txtNodes
            // 
            this.txtNodes.Location = new System.Drawing.Point(20, 480);
            this.txtNodes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNodes.Name = "txtNodes";
            this.txtNodes.Size = new System.Drawing.Size(399, 27);
            this.txtNodes.TabIndex = 2;
            // 
            // txtListNodes
            // 
            this.txtListNodes.Location = new System.Drawing.Point(21, 200);
            this.txtListNodes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtListNodes.FormattingEnabled = true;
            this.txtListNodes.Name = "txtListNodes";
            this.txtListNodes.Size = new System.Drawing.Size(399, 200);
            this.txtListNodes.TabIndex = 2;
            // 
            // txtRoot
            // 
            this.txtRoot.Location = new System.Drawing.Point(20, 420);
            this.txtRoot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoot.Name = "txtRoot";
            this.txtRoot.Size = new System.Drawing.Size(399, 27);
            this.txtRoot.TabIndex = 2;
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(20, 760);
            this.txtDays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(399, 27);
            this.txtDays.TabIndex = 2;
            // 
            // txtListTotal
            // 
            this.txtListTotal.Location = new System.Drawing.Point(20, 580);
            this.txtListTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtListTotal.FormattingEnabled = true;
            this.txtListTotal.Name = "txtListTotal";
            this.txtListTotal.Size = new System.Drawing.Size(399, 152);
            this.txtListTotal.TabIndex = 2;
            // 
            // btnAddNodesPath
            // 
            this.btnAddNodesPath.Location = new System.Drawing.Point(20, 150);
            this.btnAddNodesPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddNodesPath.Name = "btnAddNodes";
            this.btnAddNodesPath.Size = new System.Drawing.Size(400, 35);
            this.btnAddNodesPath.TabIndex = 6;
            this.btnAddNodesPath.Text = "Add Nodes Path and Chance to list";
            this.btnAddNodesPath.UseVisualStyleBackColor = true;
            this.btnAddNodesPath.Click += new System.EventHandler(this.btnAddNodesPath_Click);
            // 
            // btnAddNodes
            //
            this.btnAddNodes.Location = new System.Drawing.Point(20, 530);
            this.btnAddNodes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddNodes.Name = "btnAddNodes";
            this.btnAddNodes.Size = new System.Drawing.Size(400, 35);
            this.btnAddNodes.TabIndex = 6;
            this.btnAddNodes.Text = "Add Node with Value to list";
            this.btnAddNodes.UseVisualStyleBackColor = true;
            this.btnAddNodes.Click += new System.EventHandler(this.btnAddNodes_Click);
            // 
            // btnSubmitBFS
            // 
            this.btnSubmitBFS.Location = new System.Drawing.Point(20, 800);
            this.btnSubmitBFS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmitBFS.Name = "btnSubmitBFS";
            this.btnSubmitBFS.Size = new System.Drawing.Size(400, 35);
            this.btnSubmitBFS.TabIndex = 6;
            this.btnSubmitBFS.Text = "View Bread First Search Graph";
            this.btnSubmitBFS.UseVisualStyleBackColor = true;
            this.btnSubmitBFS.Click += new System.EventHandler(this.btnSubmitBFS_Click);
            // 
            // bgBFS
            // 
            this.bgGraph.WorkerReportsProgress = true;
            this.bgGraph.WorkerSupportsCancellation = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 1800);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblNodes);
            this.Controls.Add(this.txtNodesPath);
            this.Controls.Add(this.btnAddNodesPath);
            this.Controls.Add(this.txtListNodes);
            this.Controls.Add(this.lblRoot);
            this.Controls.Add(this.txtRoot);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtNodes);
            this.Controls.Add(this.btnAddNodes);
            this.Controls.Add(this.txtListTotal);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.btnSubmitBFS);
            this.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.Name = "Form1";
            this.Text = "Covid Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblNodes;
        private System.Windows.Forms.Label lblRoot;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtNodes;
        private System.Windows.Forms.TextBox txtNodesPath;
        private System.Windows.Forms.ListBox txtListNodes;
        private System.Windows.Forms.TextBox txtRoot;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.ListBox txtListTotal;
        private System.Windows.Forms.Button btnSubmitBFS;
        private System.Windows.Forms.Button btnAddNodes;
        private System.Windows.Forms.Button btnAddNodesPath;
        private System.ComponentModel.BackgroundWorker bgGraph;
    }
}