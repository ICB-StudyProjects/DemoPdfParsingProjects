namespace ImageProcessingPractice
{
    partial class ImageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageForm));
            this.txtImage = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.ofdSelectFile = new System.Windows.Forms.OpenFileDialog();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.tbarImageSize = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pboxOcrLines = new System.Windows.Forms.PictureBox();
            this.pboxFileImage = new System.Windows.Forms.PictureBox();
            this.btnProcessImg = new System.Windows.Forms.Button();
            this.lbOcrPage = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbOcrRows = new System.Windows.Forms.Label();
            this.txtOcrRows = new System.Windows.Forms.TextBox();
            this.pboxOcrLines1 = new System.Windows.Forms.PictureBox();
            this.pboxOcrLines2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbarImageSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxOcrLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFileImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxOcrLines1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxOcrLines2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(61, 12);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(209, 20);
            this.txtImage.TabIndex = 0;
            this.txtImage.Text = "Please select a file";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(292, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(71, 20);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // ofdSelectFile
            // 
            this.ofdSelectFile.FileName = "ofdSelectFile";
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.BackColor = System.Drawing.Color.LimeGreen;
            this.btnZoomIn.Location = new System.Drawing.Point(23, 193);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(32, 32);
            this.btnZoomIn.TabIndex = 3;
            this.btnZoomIn.Text = "+";
            this.btnZoomIn.UseVisualStyleBackColor = false;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnZoomOut.Location = new System.Drawing.Point(23, 231);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(32, 32);
            this.btnZoomOut.TabIndex = 4;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.UseVisualStyleBackColor = false;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // tbarImageSize
            // 
            this.tbarImageSize.Location = new System.Drawing.Point(61, 51);
            this.tbarImageSize.Name = "tbarImageSize";
            this.tbarImageSize.Size = new System.Drawing.Size(302, 45);
            this.tbarImageSize.TabIndex = 5;
            this.tbarImageSize.Scroll += new System.EventHandler(this.tbarImageSize_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "OCR Line Results";
            // 
            // pboxOcrLines
            // 
            this.pboxOcrLines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxOcrLines.Location = new System.Drawing.Point(414, 106);
            this.pboxOcrLines.Name = "pboxOcrLines";
            this.pboxOcrLines.Size = new System.Drawing.Size(507, 78);
            this.pboxOcrLines.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxOcrLines.TabIndex = 6;
            this.pboxOcrLines.TabStop = false;
            // 
            // pboxFileImage
            // 
            this.pboxFileImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pboxFileImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxFileImage.Image = ((System.Drawing.Image)(resources.GetObject("pboxFileImage.Image")));
            this.pboxFileImage.Location = new System.Drawing.Point(60, 106);
            this.pboxFileImage.Name = "pboxFileImage";
            this.pboxFileImage.Size = new System.Drawing.Size(302, 252);
            this.pboxFileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxFileImage.TabIndex = 2;
            this.pboxFileImage.TabStop = false;
            this.pboxFileImage.Click += new System.EventHandler(this.pboxFileImage_Click);
            // 
            // btnProcessImg
            // 
            this.btnProcessImg.Location = new System.Drawing.Point(149, 364);
            this.btnProcessImg.Name = "btnProcessImg";
            this.btnProcessImg.Size = new System.Drawing.Size(121, 35);
            this.btnProcessImg.TabIndex = 8;
            this.btnProcessImg.Text = "Process";
            this.btnProcessImg.UseVisualStyleBackColor = true;
            this.btnProcessImg.Visible = false;
            this.btnProcessImg.Click += new System.EventHandler(this.btnProcessImg_Click);
            // 
            // lbOcrPage
            // 
            this.lbOcrPage.AutoSize = true;
            this.lbOcrPage.Location = new System.Drawing.Point(414, 38);
            this.lbOcrPage.Name = "lbOcrPage";
            this.lbOcrPage.Size = new System.Drawing.Size(35, 13);
            this.lbOcrPage.TabIndex = 9;
            this.lbOcrPage.Text = "Page:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(455, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(22, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(483, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 20);
            this.label3.TabIndex = 11;
            // 
            // lbOcrRows
            // 
            this.lbOcrRows.AutoSize = true;
            this.lbOcrRows.Location = new System.Drawing.Point(491, 38);
            this.lbOcrRows.Name = "lbOcrRows";
            this.lbOcrRows.Size = new System.Drawing.Size(37, 13);
            this.lbOcrRows.TabIndex = 12;
            this.lbOcrRows.Text = "Rows:";
            // 
            // txtOcrRows
            // 
            this.txtOcrRows.Location = new System.Drawing.Point(532, 35);
            this.txtOcrRows.Name = "txtOcrRows";
            this.txtOcrRows.Size = new System.Drawing.Size(27, 20);
            this.txtOcrRows.TabIndex = 13;
            // 
            // pboxOcrLines1
            // 
            this.pboxOcrLines1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxOcrLines1.Location = new System.Drawing.Point(414, 190);
            this.pboxOcrLines1.Name = "pboxOcrLines1";
            this.pboxOcrLines1.Size = new System.Drawing.Size(507, 83);
            this.pboxOcrLines1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxOcrLines1.TabIndex = 14;
            this.pboxOcrLines1.TabStop = false;
            // 
            // pboxOcrLines2
            // 
            this.pboxOcrLines2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxOcrLines2.Location = new System.Drawing.Point(414, 279);
            this.pboxOcrLines2.Name = "pboxOcrLines2";
            this.pboxOcrLines2.Size = new System.Drawing.Size(507, 79);
            this.pboxOcrLines2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxOcrLines2.TabIndex = 15;
            this.pboxOcrLines2.TabStop = false;
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(931, 443);
            this.Controls.Add(this.pboxOcrLines2);
            this.Controls.Add(this.pboxOcrLines1);
            this.Controls.Add(this.txtOcrRows);
            this.Controls.Add(this.lbOcrRows);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbOcrPage);
            this.Controls.Add(this.btnProcessImg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pboxOcrLines);
            this.Controls.Add(this.tbarImageSize);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.pboxFileImage);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtImage);
            this.Name = "ImageForm";
            this.Text = "ImageForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImageForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tbarImageSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxOcrLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFileImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxOcrLines1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxOcrLines2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog ofdSelectFile;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.TrackBar tbarImageSize;
        public System.Windows.Forms.PictureBox pboxFileImage;
        private System.Windows.Forms.PictureBox pboxOcrLines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcessImg;
        private System.Windows.Forms.Label lbOcrPage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbOcrRows;
        private System.Windows.Forms.TextBox txtOcrRows;
        private System.Windows.Forms.PictureBox pboxOcrLines1;
        private System.Windows.Forms.PictureBox pboxOcrLines2;
    }
}

