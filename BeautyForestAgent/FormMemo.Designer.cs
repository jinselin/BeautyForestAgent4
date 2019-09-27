namespace BeautyForestAgent
{
    partial class FormMemo
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
            this.components = new System.ComponentModel.Container();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.tpRead = new System.Windows.Forms.TabControl();
            this.tpRea = new System.Windows.Forms.TabPage();
            this.tpWrite = new System.Windows.Forms.TabPage();
            this.loadFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtReadFile = new System.Windows.Forms.TextBox();
            this.txtReadText = new System.Windows.Forms.TextBox();
            this.btnReadFileSelect = new System.Windows.Forms.Button();
            this.btnReadText = new System.Windows.Forms.Button();
            this.txtWriteFile = new System.Windows.Forms.TextBox();
            this.btnWriteFileSelect = new System.Windows.Forms.Button();
            this.btnWriteText = new System.Windows.Forms.Button();
            this.txtWriteText = new System.Windows.Forms.TextBox();
            this.tpRead.SuspendLayout();
            this.tpRea.SuspendLayout();
            this.tpWrite.SuspendLayout();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(0, 319);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(485, 22);
            this.Status.TabIndex = 0;
            this.Status.Text = "statusStrip1";
            // 
            // tpRead
            // 
            this.tpRead.Controls.Add(this.tpRea);
            this.tpRead.Controls.Add(this.tpWrite);
            this.tpRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpRead.Location = new System.Drawing.Point(0, 0);
            this.tpRead.Name = "tpRead";
            this.tpRead.SelectedIndex = 0;
            this.tpRead.Size = new System.Drawing.Size(485, 319);
            this.tpRead.TabIndex = 1;
            // 
            // tpRea
            // 
            this.tpRea.Controls.Add(this.btnReadText);
            this.tpRea.Controls.Add(this.btnReadFileSelect);
            this.tpRea.Controls.Add(this.txtReadText);
            this.tpRea.Controls.Add(this.txtReadFile);
            this.tpRea.Location = new System.Drawing.Point(4, 22);
            this.tpRea.Name = "tpRea";
            this.tpRea.Padding = new System.Windows.Forms.Padding(3);
            this.tpRea.Size = new System.Drawing.Size(477, 293);
            this.tpRea.TabIndex = 0;
            this.tpRea.Text = "파일 읽기";
            this.tpRea.UseVisualStyleBackColor = true;
            // 
            // tpWrite
            // 
            this.tpWrite.Controls.Add(this.txtWriteText);
            this.tpWrite.Controls.Add(this.btnWriteText);
            this.tpWrite.Controls.Add(this.btnWriteFileSelect);
            this.tpWrite.Controls.Add(this.txtWriteFile);
            this.tpWrite.Location = new System.Drawing.Point(4, 22);
            this.tpWrite.Name = "tpWrite";
            this.tpWrite.Padding = new System.Windows.Forms.Padding(3);
            this.tpWrite.Size = new System.Drawing.Size(477, 293);
            this.tpWrite.TabIndex = 1;
            this.tpWrite.Text = "파일 쓰기";
            this.tpWrite.UseVisualStyleBackColor = true;
            // 
            // loadFileDlg
            // 
            this.loadFileDlg.FileName = "openFileDialog1";
            this.loadFileDlg.Filter = "텍스트 파일(*.txt)|*.txt|모든파일 (*.*)|*.*";
            // 
            // saveFileDlg
            // 
            this.saveFileDlg.Filter = "텍스트 파일(*.txt)|*.txt";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtReadFile
            // 
            this.txtReadFile.Location = new System.Drawing.Point(7, 7);
            this.txtReadFile.Name = "txtReadFile";
            this.txtReadFile.ReadOnly = true;
            this.txtReadFile.Size = new System.Drawing.Size(297, 21);
            this.txtReadFile.TabIndex = 0;
            // 
            // txtReadText
            // 
            this.txtReadText.Location = new System.Drawing.Point(3, 34);
            this.txtReadText.Multiline = true;
            this.txtReadText.Name = "txtReadText";
            this.txtReadText.ReadOnly = true;
            this.txtReadText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReadText.Size = new System.Drawing.Size(466, 253);
            this.txtReadText.TabIndex = 1;
            // 
            // btnReadFileSelect
            // 
            this.btnReadFileSelect.Location = new System.Drawing.Point(310, 6);
            this.btnReadFileSelect.Name = "btnReadFileSelect";
            this.btnReadFileSelect.Size = new System.Drawing.Size(75, 23);
            this.btnReadFileSelect.TabIndex = 2;
            this.btnReadFileSelect.Text = "파일 선택";
            this.btnReadFileSelect.UseVisualStyleBackColor = true;
            // 
            // btnReadText
            // 
            this.btnReadText.Location = new System.Drawing.Point(392, 7);
            this.btnReadText.Name = "btnReadText";
            this.btnReadText.Size = new System.Drawing.Size(75, 23);
            this.btnReadText.TabIndex = 3;
            this.btnReadText.Text = "불러오기";
            this.btnReadText.UseVisualStyleBackColor = true;
            // 
            // txtWriteFile
            // 
            this.txtWriteFile.Location = new System.Drawing.Point(9, 7);
            this.txtWriteFile.Name = "txtWriteFile";
            this.txtWriteFile.ReadOnly = true;
            this.txtWriteFile.Size = new System.Drawing.Size(298, 21);
            this.txtWriteFile.TabIndex = 0;
            // 
            // btnWriteFileSelect
            // 
            this.btnWriteFileSelect.Location = new System.Drawing.Point(313, 5);
            this.btnWriteFileSelect.Name = "btnWriteFileSelect";
            this.btnWriteFileSelect.Size = new System.Drawing.Size(75, 23);
            this.btnWriteFileSelect.TabIndex = 1;
            this.btnWriteFileSelect.Text = "파일 선택";
            this.btnWriteFileSelect.UseVisualStyleBackColor = true;
            // 
            // btnWriteText
            // 
            this.btnWriteText.Location = new System.Drawing.Point(394, 4);
            this.btnWriteText.Name = "btnWriteText";
            this.btnWriteText.Size = new System.Drawing.Size(75, 23);
            this.btnWriteText.TabIndex = 2;
            this.btnWriteText.Text = "저장하기";
            this.btnWriteText.UseVisualStyleBackColor = true;
            // 
            // txtWriteText
            // 
            this.txtWriteText.Location = new System.Drawing.Point(9, 35);
            this.txtWriteText.Multiline = true;
            this.txtWriteText.Name = "txtWriteText";
            this.txtWriteText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtWriteText.Size = new System.Drawing.Size(460, 242);
            this.txtWriteText.TabIndex = 3;
            // 
            // FormMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 341);
            this.Controls.Add(this.tpRead);
            this.Controls.Add(this.Status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormMemo";
            this.Text = "3119 진세린";
            this.tpRead.ResumeLayout(false);
            this.tpRea.ResumeLayout(false);
            this.tpRea.PerformLayout();
            this.tpWrite.ResumeLayout(false);
            this.tpWrite.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.TabControl tpRead;
        private System.Windows.Forms.TabPage tpRea;
        private System.Windows.Forms.Button btnReadText;
        private System.Windows.Forms.Button btnReadFileSelect;
        private System.Windows.Forms.TextBox txtReadText;
        private System.Windows.Forms.TextBox txtReadFile;
        private System.Windows.Forms.TabPage tpWrite;
        private System.Windows.Forms.TextBox txtWriteText;
        private System.Windows.Forms.Button btnWriteText;
        private System.Windows.Forms.Button btnWriteFileSelect;
        private System.Windows.Forms.TextBox txtWriteFile;
        private System.Windows.Forms.OpenFileDialog loadFileDlg;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}