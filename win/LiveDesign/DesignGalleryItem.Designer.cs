namespace LiveDesign
{
    partial class DesignGalleryItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.previewPicuture = new System.Windows.Forms.PictureBox();
            this.designNameLabel = new System.Windows.Forms.Label();
            this.revisionsLabel = new System.Windows.Forms.Label();
            this.updateTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.previewPicuture)).BeginInit();
            this.SuspendLayout();
            // 
            // previewPicuture
            // 
            this.previewPicuture.Location = new System.Drawing.Point(13, 14);
            this.previewPicuture.Name = "previewPicuture";
            this.previewPicuture.Size = new System.Drawing.Size(200, 200);
            this.previewPicuture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewPicuture.TabIndex = 0;
            this.previewPicuture.TabStop = false;
            // 
            // designNameLabel
            // 
            this.designNameLabel.AutoSize = true;
            this.designNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.designNameLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.designNameLabel.Location = new System.Drawing.Point(10, 227);
            this.designNameLabel.Name = "designNameLabel";
            this.designNameLabel.Size = new System.Drawing.Size(120, 17);
            this.designNameLabel.TabIndex = 1;
            this.designNameLabel.Text = "Sample Design.psd";
            // 
            // revisionsLabel
            // 
            this.revisionsLabel.AutoSize = true;
            this.revisionsLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.revisionsLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.revisionsLabel.Location = new System.Drawing.Point(10, 244);
            this.revisionsLabel.Name = "revisionsLabel";
            this.revisionsLabel.Size = new System.Drawing.Size(76, 17);
            this.revisionsLabel.TabIndex = 1;
            this.revisionsLabel.Text = "Revisions: 7";
            // 
            // updateTimeLabel
            // 
            this.updateTimeLabel.AutoSize = true;
            this.updateTimeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.updateTimeLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.updateTimeLabel.Location = new System.Drawing.Point(10, 261);
            this.updateTimeLabel.Name = "updateTimeLabel";
            this.updateTimeLabel.Size = new System.Drawing.Size(209, 17);
            this.updateTimeLabel.TabIndex = 1;
            this.updateTimeLabel.Text = "Last updated: 2013-03-01 13:00:00";
            // 
            // DesignGalleryItem
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updateTimeLabel);
            this.Controls.Add(this.revisionsLabel);
            this.Controls.Add(this.designNameLabel);
            this.Controls.Add(this.previewPicuture);
            this.Name = "DesignGalleryItem";
            this.Size = new System.Drawing.Size(226, 291);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.DesignGalleryItem_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.DesignGalleryItem_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.previewPicuture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox previewPicuture;
        private System.Windows.Forms.Label designNameLabel;
        private System.Windows.Forms.Label revisionsLabel;
        private System.Windows.Forms.Label updateTimeLabel;
    }
}
