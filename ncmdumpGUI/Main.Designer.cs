namespace ncmdumpGUI
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectMp3Folder = new System.Windows.Forms.Button();
            this.txtMp3FolderPath = new System.Windows.Forms.TextBox();
            this.btnSelectNcmFolder = new System.Windows.Forms.Button();
            this.txtNcmFolderPath = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ncm文件目录：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(629, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "mp3文件目录：";
            // 
            // btnSelectMp3Folder
            // 
            this.btnSelectMp3Folder.Location = new System.Drawing.Point(1071, 14);
            this.btnSelectMp3Folder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectMp3Folder.Name = "btnSelectMp3Folder";
            this.btnSelectMp3Folder.Size = new System.Drawing.Size(100, 40);
            this.btnSelectMp3Folder.TabIndex = 5;
            this.btnSelectMp3Folder.Text = "选择目录";
            this.btnSelectMp3Folder.UseVisualStyleBackColor = true;
            this.btnSelectMp3Folder.Click += new System.EventHandler(this.btnSelectMp3Folder_Click);
            // 
            // txtMp3FolderPath
            // 
            this.txtMp3FolderPath.Location = new System.Drawing.Point(746, 21);
            this.txtMp3FolderPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMp3FolderPath.Name = "txtMp3FolderPath";
            this.txtMp3FolderPath.Size = new System.Drawing.Size(317, 26);
            this.txtMp3FolderPath.TabIndex = 4;
            // 
            // btnSelectNcmFolder
            // 
            this.btnSelectNcmFolder.Location = new System.Drawing.Point(454, 14);
            this.btnSelectNcmFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectNcmFolder.Name = "btnSelectNcmFolder";
            this.btnSelectNcmFolder.Size = new System.Drawing.Size(100, 40);
            this.btnSelectNcmFolder.TabIndex = 2;
            this.btnSelectNcmFolder.Text = "选择目录";
            this.btnSelectNcmFolder.UseVisualStyleBackColor = true;
            this.btnSelectNcmFolder.Click += new System.EventHandler(this.btnSelectNcmFolder_Click);
            // 
            // txtNcmFolderPath
            // 
            this.txtNcmFolderPath.Location = new System.Drawing.Point(129, 21);
            this.txtNcmFolderPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNcmFolderPath.Name = "txtNcmFolderPath";
            this.txtNcmFolderPath.Size = new System.Drawing.Size(317, 26);
            this.txtNcmFolderPath.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(963, 457);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 40);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "开始转换";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(855, 457);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除文件";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1071, 457);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 40);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "关闭程序";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 62);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(542, 382);
            this.checkedListBox1.TabIndex = 7;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(629, 62);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(542, 382);
            this.checkedListBox2.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 511);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSelectMp3Folder);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSelectNcmFolder);
            this.Controls.Add(this.txtMp3FolderPath);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNcmFolderPath);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ncmdumpGUI by kpali v1.3";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSelectMp3Folder;
        private System.Windows.Forms.TextBox txtMp3FolderPath;
        private System.Windows.Forms.Button btnSelectNcmFolder;
        private System.Windows.Forms.TextBox txtNcmFolderPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
    }
}

