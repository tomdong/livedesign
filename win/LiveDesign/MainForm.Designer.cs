namespace LiveDesign
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
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("All");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Favorites");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("My Design", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Tom");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Jacky");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Team", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Sample Project");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("My First project");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Projects", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.designGalleryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.designGalleryItem1 = new LiveDesign.DesignGalleryItem();
            this.designGalleryItem2 = new LiveDesign.DesignGalleryItem();
            this.designGalleryItem3 = new LiveDesign.DesignGalleryItem();
            this.designGalleryItem4 = new LiveDesign.DesignGalleryItem();
            this.designGalleryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(0);
            this.treeView1.MinimumSize = new System.Drawing.Size(200, 300);
            this.treeView1.Name = "treeView1";
            treeNode10.Name = "Node8";
            treeNode10.Text = "All";
            treeNode11.Name = "Node9";
            treeNode11.Text = "Favorites";
            treeNode12.Name = "Node5";
            treeNode12.Text = "My Design";
            treeNode13.Name = "Node10";
            treeNode13.Text = "Tom";
            treeNode14.Name = "Node11";
            treeNode14.Text = "Jacky";
            treeNode15.Name = "Node6";
            treeNode15.Text = "Team";
            treeNode16.Name = "Node12";
            treeNode16.Text = "Sample Project";
            treeNode17.Name = "Node13";
            treeNode17.Text = "My First project";
            treeNode18.Name = "Node7";
            treeNode18.Text = "Projects";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode15,
            treeNode18});
            this.treeView1.ShowPlusMinus = false;
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new System.Drawing.Size(200, 564);
            this.treeView1.TabIndex = 2;
            // 
            // designGalleryPanel
            // 
            this.designGalleryPanel.AutoScroll = true;
            this.designGalleryPanel.Controls.Add(this.designGalleryItem1);
            this.designGalleryPanel.Controls.Add(this.designGalleryItem2);
            this.designGalleryPanel.Controls.Add(this.designGalleryItem3);
            this.designGalleryPanel.Controls.Add(this.designGalleryItem4);
            this.designGalleryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.designGalleryPanel.Location = new System.Drawing.Point(200, 0);
            this.designGalleryPanel.Name = "designGalleryPanel";
            this.designGalleryPanel.Size = new System.Drawing.Size(714, 564);
            this.designGalleryPanel.TabIndex = 3;
            // 
            // designGalleryItem1
            // 
            this.designGalleryItem1.AllowDrop = true;
            this.designGalleryItem1.Location = new System.Drawing.Point(3, 3);
            this.designGalleryItem1.Name = "designGalleryItem1";
            this.designGalleryItem1.Size = new System.Drawing.Size(226, 291);
            this.designGalleryItem1.TabIndex = 0;
            // 
            // designGalleryItem2
            // 
            this.designGalleryItem2.AllowDrop = true;
            this.designGalleryItem2.Location = new System.Drawing.Point(235, 3);
            this.designGalleryItem2.Name = "designGalleryItem2";
            this.designGalleryItem2.Size = new System.Drawing.Size(226, 291);
            this.designGalleryItem2.TabIndex = 1;
            // 
            // designGalleryItem3
            // 
            this.designGalleryItem3.AllowDrop = true;
            this.designGalleryItem3.Location = new System.Drawing.Point(467, 3);
            this.designGalleryItem3.Name = "designGalleryItem3";
            this.designGalleryItem3.Size = new System.Drawing.Size(226, 291);
            this.designGalleryItem3.TabIndex = 2;
            // 
            // designGalleryItem4
            // 
            this.designGalleryItem4.AllowDrop = true;
            this.designGalleryItem4.Location = new System.Drawing.Point(3, 300);
            this.designGalleryItem4.Name = "designGalleryItem4";
            this.designGalleryItem4.Size = new System.Drawing.Size(226, 291);
            this.designGalleryItem4.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(914, 564);
            this.Controls.Add(this.designGalleryPanel);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Live Design";
            this.designGalleryPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.FlowLayoutPanel designGalleryPanel;
        private DesignGalleryItem designGalleryItem1;
        private DesignGalleryItem designGalleryItem2;
        private DesignGalleryItem designGalleryItem3;
        private DesignGalleryItem designGalleryItem4;
    }
}

