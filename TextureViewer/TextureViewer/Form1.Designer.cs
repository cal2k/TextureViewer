namespace TextureViewer
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
            this.lbMaterials = new System.Windows.Forms.ListBox();
            this.lbOptions = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSelectLibarary = new System.Windows.Forms.Button();
            this.lblCurrentDir = new System.Windows.Forms.Label();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.btnTextureLocation = new System.Windows.Forms.Button();
            this.btnCopyTexturePath = new System.Windows.Forms.Button();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.btnDeleteTexture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaterials
            // 
            this.lbMaterials.FormattingEnabled = true;
            this.lbMaterials.Location = new System.Drawing.Point(15, 38);
            this.lbMaterials.Name = "lbMaterials";
            this.lbMaterials.Size = new System.Drawing.Size(107, 602);
            this.lbMaterials.TabIndex = 0;
            this.lbMaterials.SelectedIndexChanged += new System.EventHandler(this.lbMaterials_SelectedIndexChanged);
            // 
            // lbOptions
            // 
            this.lbOptions.FormattingEnabled = true;
            this.lbOptions.HorizontalScrollbar = true;
            this.lbOptions.Location = new System.Drawing.Point(128, 38);
            this.lbOptions.Name = "lbOptions";
            this.lbOptions.Size = new System.Drawing.Size(170, 602);
            this.lbOptions.TabIndex = 1;
            this.lbOptions.SelectedIndexChanged += new System.EventHandler(this.lbOptions_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(304, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 602);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnSelectLibarary
            // 
            this.btnSelectLibarary.Location = new System.Drawing.Point(15, 9);
            this.btnSelectLibarary.Name = "btnSelectLibarary";
            this.btnSelectLibarary.Size = new System.Drawing.Size(107, 23);
            this.btnSelectLibarary.TabIndex = 3;
            this.btnSelectLibarary.Text = "Select Library";
            this.btnSelectLibarary.UseVisualStyleBackColor = true;
            this.btnSelectLibarary.Click += new System.EventHandler(this.btnSelectLibarary_Click);
            // 
            // lblCurrentDir
            // 
            this.lblCurrentDir.Location = new System.Drawing.Point(125, 9);
            this.lblCurrentDir.Name = "lblCurrentDir";
            this.lblCurrentDir.Size = new System.Drawing.Size(779, 21);
            this.lblCurrentDir.TabIndex = 4;
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Enabled = false;
            this.btnOpenImage.Location = new System.Drawing.Point(439, 646);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(129, 23);
            this.btnOpenImage.TabIndex = 6;
            this.btnOpenImage.Text = "View Texture Image";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // btnTextureLocation
            // 
            this.btnTextureLocation.Location = new System.Drawing.Point(304, 646);
            this.btnTextureLocation.Name = "btnTextureLocation";
            this.btnTextureLocation.Size = new System.Drawing.Size(129, 23);
            this.btnTextureLocation.TabIndex = 7;
            this.btnTextureLocation.Text = "Open Texture Location";
            this.btnTextureLocation.UseVisualStyleBackColor = true;
            this.btnTextureLocation.Click += new System.EventHandler(this.btnTextureLocation_Click);
            // 
            // btnCopyTexturePath
            // 
            this.btnCopyTexturePath.Location = new System.Drawing.Point(574, 646);
            this.btnCopyTexturePath.Name = "btnCopyTexturePath";
            this.btnCopyTexturePath.Size = new System.Drawing.Size(129, 23);
            this.btnCopyTexturePath.TabIndex = 8;
            this.btnCopyTexturePath.Text = "Copy Texture Path";
            this.btnCopyTexturePath.UseVisualStyleBackColor = true;
            this.btnCopyTexturePath.Click += new System.EventHandler(this.btnCopyTexturePath_Click);
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(15, 649);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(283, 20);
            this.tbFilter.TabIndex = 9;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // btnDeleteTexture
            // 
            this.btnDeleteTexture.Location = new System.Drawing.Point(775, 646);
            this.btnDeleteTexture.Name = "btnDeleteTexture";
            this.btnDeleteTexture.Size = new System.Drawing.Size(129, 23);
            this.btnDeleteTexture.TabIndex = 10;
            this.btnDeleteTexture.Text = "Delete Texture";
            this.btnDeleteTexture.UseVisualStyleBackColor = true;
            this.btnDeleteTexture.Click += new System.EventHandler(this.btnDeleteTexture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 681);
            this.Controls.Add(this.btnDeleteTexture);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.btnCopyTexturePath);
            this.Controls.Add(this.btnTextureLocation);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.lblCurrentDir);
            this.Controls.Add(this.btnSelectLibarary);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbOptions);
            this.Controls.Add(this.lbMaterials);
            this.Name = "Form1";
            this.Text = "Texture Preview";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSelectLibarary;
        private System.Windows.Forms.Label lblCurrentDir;
        private System.Windows.Forms.TextBox tbFilter;
        public System.Windows.Forms.Button btnOpenImage;
        public System.Windows.Forms.Button btnTextureLocation;
        public System.Windows.Forms.Button btnCopyTexturePath;
        public System.Windows.Forms.Button btnDeleteTexture;
        public System.Windows.Forms.ListBox lbMaterials;
        public System.Windows.Forms.ListBox lbOptions;
    }
}

