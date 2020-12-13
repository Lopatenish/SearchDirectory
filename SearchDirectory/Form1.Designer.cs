
namespace SearchDirectory
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Нет элементов");
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.textBoxRegex = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.treeViewFolder = new System.Windows.Forms.TreeView();
            this.labelFoundFiles = new System.Windows.Forms.Label();
            this.labelAllFiles = new System.Windows.Forms.Label();
            this.labelCountFound = new System.Windows.Forms.Label();
            this.labelCountAll = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFolderChecked = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Enabled = false;
            this.textBoxDirectory.Location = new System.Drawing.Point(12, 33);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(305, 20);
            this.textBoxDirectory.TabIndex = 0;
            // 
            // textBoxRegex
            // 
            this.textBoxRegex.Location = new System.Drawing.Point(12, 84);
            this.textBoxRegex.Name = "textBoxRegex";
            this.textBoxRegex.Size = new System.Drawing.Size(305, 20);
            this.textBoxRegex.TabIndex = 0;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(341, 30);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Обзор...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(341, 82);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Tag = "search";
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // treeViewFolder
            // 
            this.treeViewFolder.Location = new System.Drawing.Point(12, 174);
            this.treeViewFolder.Name = "treeViewFolder";
            treeNode4.Name = "Root";
            treeNode4.Text = "Нет элементов";
            this.treeViewFolder.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeViewFolder.Size = new System.Drawing.Size(547, 273);
            this.treeViewFolder.TabIndex = 2;
            // 
            // labelFoundFiles
            // 
            this.labelFoundFiles.AutoSize = true;
            this.labelFoundFiles.Location = new System.Drawing.Point(14, 467);
            this.labelFoundFiles.Name = "labelFoundFiles";
            this.labelFoundFiles.Size = new System.Drawing.Size(108, 13);
            this.labelFoundFiles.TabIndex = 3;
            this.labelFoundFiles.Text = "Найденных файлов:";
            // 
            // labelAllFiles
            // 
            this.labelAllFiles.AutoSize = true;
            this.labelAllFiles.Location = new System.Drawing.Point(14, 489);
            this.labelAllFiles.Name = "labelAllFiles";
            this.labelAllFiles.Size = new System.Drawing.Size(81, 13);
            this.labelAllFiles.TabIndex = 3;
            this.labelAllFiles.Text = "Всего файлов:";
            // 
            // labelCountFound
            // 
            this.labelCountFound.AutoSize = true;
            this.labelCountFound.Location = new System.Drawing.Point(140, 467);
            this.labelCountFound.Name = "labelCountFound";
            this.labelCountFound.Size = new System.Drawing.Size(13, 13);
            this.labelCountFound.TabIndex = 3;
            this.labelCountFound.Text = "0";
            // 
            // labelCountAll
            // 
            this.labelCountAll.AutoSize = true;
            this.labelCountAll.Location = new System.Drawing.Point(140, 489);
            this.labelCountAll.Name = "labelCountAll";
            this.labelCountAll.Size = new System.Drawing.Size(13, 13);
            this.labelCountAll.TabIndex = 3;
            this.labelCountAll.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Время:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(73, 118);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(13, 13);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Папка, в которой идет поиск:";
            // 
            // labelFolderChecked
            // 
            this.labelFolderChecked.Location = new System.Drawing.Point(188, 140);
            this.labelFolderChecked.Name = "labelFolderChecked";
            this.labelFolderChecked.Size = new System.Drawing.Size(371, 13);
            this.labelFolderChecked.TabIndex = 3;
            this.labelFolderChecked.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(422, 82);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Tag = "cancel";
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Директория для поиска";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Параметры поиска";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 519);
            this.Controls.Add(this.labelCountAll);
            this.Controls.Add(this.labelAllFiles);
            this.Controls.Add(this.labelFolderChecked);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelCountFound);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFoundFiles);
            this.Controls.Add(this.treeViewFolder);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxRegex);
            this.Controls.Add(this.textBoxDirectory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDirectory;
        private System.Windows.Forms.TextBox textBoxRegex;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TreeView treeViewFolder;
        private System.Windows.Forms.Label labelFoundFiles;
        private System.Windows.Forms.Label labelAllFiles;
        private System.Windows.Forms.Label labelCountFound;
        private System.Windows.Forms.Label labelCountAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFolderChecked;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

