namespace SertificatesApp
{
    partial class MyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSpecifications = new System.Windows.Forms.ComboBox();
            this.txtCertificate = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtSpecification = new System.Windows.Forms.TextBox();
            this.pboxCertificate = new System.Windows.Forms.PictureBox();
            this.btnProceed = new System.Windows.Forms.Button();
            this.txtOCRInfo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ofdSelectFile = new System.Windows.Forms.OpenFileDialog();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.cboLab = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbOcrResultView = new System.Windows.Forms.GroupBox();
            this.pPictureBoxes = new System.Windows.Forms.Panel();
            this.btnProcessOcr = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCertTemplate = new System.Windows.Forms.ComboBox();
            this.txtReport = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCertificate)).BeginInit();
            this.gbOcrResultView.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Specification:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cert-File:";
            // 
            // cboSpecifications
            // 
            this.cboSpecifications.FormattingEnabled = true;
            this.cboSpecifications.Location = new System.Drawing.Point(86, 24);
            this.cboSpecifications.Name = "cboSpecifications";
            this.cboSpecifications.Size = new System.Drawing.Size(255, 21);
            this.cboSpecifications.TabIndex = 2;
            this.cboSpecifications.SelectedIndexChanged += new System.EventHandler(this.cboSpecifications_SelectedIndexChanged);
            // 
            // txtCertificate
            // 
            this.txtCertificate.Location = new System.Drawing.Point(503, 65);
            this.txtCertificate.Name = "txtCertificate";
            this.txtCertificate.ReadOnly = true;
            this.txtCertificate.Size = new System.Drawing.Size(182, 20);
            this.txtCertificate.TabIndex = 3;
            this.txtCertificate.Text = "Please select a file";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(701, 65);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(61, 22);
            this.btnOpenFile.TabIndex = 4;
            this.btnOpenFile.Text = "Browse";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtSpecification
            // 
            this.txtSpecification.Location = new System.Drawing.Point(12, 80);
            this.txtSpecification.Multiline = true;
            this.txtSpecification.Name = "txtSpecification";
            this.txtSpecification.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSpecification.Size = new System.Drawing.Size(354, 163);
            this.txtSpecification.TabIndex = 5;
            // 
            // pboxCertificate
            // 
            this.pboxCertificate.BackColor = System.Drawing.SystemColors.Control;
            this.pboxCertificate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxCertificate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxCertificate.Enabled = false;
            this.pboxCertificate.Image = global::SertificatesApp.Properties.Resources.file_list;
            this.pboxCertificate.Location = new System.Drawing.Point(452, 100);
            this.pboxCertificate.Name = "pboxCertificate";
            this.pboxCertificate.Size = new System.Drawing.Size(310, 143);
            this.pboxCertificate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxCertificate.TabIndex = 6;
            this.pboxCertificate.TabStop = false;
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(280, 263);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(233, 28);
            this.btnProceed.TabIndex = 7;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // txtOCRInfo
            // 
            this.txtOCRInfo.Location = new System.Drawing.Point(447, 320);
            this.txtOCRInfo.Multiline = true;
            this.txtOCRInfo.Name = "txtOCRInfo";
            this.txtOCRInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOCRInfo.Size = new System.Drawing.Size(341, 163);
            this.txtOCRInfo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Report:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "OCR Info:";
            // 
            // ofdSelectFile
            // 
            this.ofdSelectFile.FileName = "ofdSelectFile";
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomIn.Location = new System.Drawing.Point(768, 142);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(23, 23);
            this.btnZoomIn.TabIndex = 12;
            this.btnZoomIn.Text = "+";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Location = new System.Drawing.Point(768, 171);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(23, 23);
            this.btnZoomOut.TabIndex = 13;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // cboLab
            // 
            this.cboLab.BackColor = System.Drawing.SystemColors.Window;
            this.cboLab.FormattingEnabled = true;
            this.cboLab.Location = new System.Drawing.Point(479, 12);
            this.cboLab.Name = "cboLab";
            this.cboLab.Size = new System.Drawing.Size(206, 21);
            this.cboLab.TabIndex = 14;
            this.cboLab.Text = "Select laboratory";
            this.cboLab.SelectedIndexChanged += new System.EventHandler(this.cboCertTemplates_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Lab:";
            // 
            // gbOcrResultView
            // 
            this.gbOcrResultView.Controls.Add(this.pPictureBoxes);
            this.gbOcrResultView.Location = new System.Drawing.Point(15, 498);
            this.gbOcrResultView.Name = "gbOcrResultView";
            this.gbOcrResultView.Size = new System.Drawing.Size(772, 258);
            this.gbOcrResultView.TabIndex = 16;
            this.gbOcrResultView.TabStop = false;
            this.gbOcrResultView.Text = "OCR Crops";
            // 
            // pPictureBoxes
            // 
            this.pPictureBoxes.AutoScroll = true;
            this.pPictureBoxes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPictureBoxes.Location = new System.Drawing.Point(6, 19);
            this.pPictureBoxes.Name = "pPictureBoxes";
            this.pPictureBoxes.Size = new System.Drawing.Size(760, 233);
            this.pPictureBoxes.TabIndex = 0;
            // 
            // btnProcessOcr
            // 
            this.btnProcessOcr.Location = new System.Drawing.Point(550, 249);
            this.btnProcessOcr.Name = "btnProcessOcr";
            this.btnProcessOcr.Size = new System.Drawing.Size(111, 23);
            this.btnProcessOcr.TabIndex = 17;
            this.btnProcessOcr.Text = "Process Ocr";
            this.btnProcessOcr.UseVisualStyleBackColor = true;
            this.btnProcessOcr.Click += new System.EventHandler(this.btnProcessOcr_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cert-Template:";
            // 
            // cboCertTemplate
            // 
            this.cboCertTemplate.FormattingEnabled = true;
            this.cboCertTemplate.Location = new System.Drawing.Point(528, 37);
            this.cboCertTemplate.Name = "cboCertTemplate";
            this.cboCertTemplate.Size = new System.Drawing.Size(157, 21);
            this.cboCertTemplate.TabIndex = 19;
            this.cboCertTemplate.Text = "Select template";
            // 
            // txtReport
            // 
            this.txtReport.Location = new System.Drawing.Point(15, 320);
            this.txtReport.Name = "txtReport";
            this.txtReport.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtReport.Size = new System.Drawing.Size(351, 163);
            this.txtReport.TabIndex = 20;
            this.txtReport.Text = "";
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 765);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.cboCertTemplate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnProcessOcr);
            this.Controls.Add(this.gbOcrResultView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboLab);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOCRInfo);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.pboxCertificate);
            this.Controls.Add(this.txtSpecification);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtCertificate);
            this.Controls.Add(this.cboSpecifications);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MyForm";
            this.Text = "Certificate Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxCertificate)).EndInit();
            this.gbOcrResultView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSpecifications;
        private System.Windows.Forms.TextBox txtCertificate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtSpecification;
        private System.Windows.Forms.PictureBox pboxCertificate;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.TextBox txtOCRInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog ofdSelectFile;
        private System.Windows.Forms.Button btnZoomIn;
        public System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.ComboBox cboLab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbOcrResultView;
        private System.Windows.Forms.Button btnProcessOcr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCertTemplate;
        private System.Windows.Forms.Panel pPictureBoxes;
        private System.Windows.Forms.RichTextBox txtReport;
    }
}

