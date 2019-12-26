namespace GUI_Parser_KES
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.fldPath = new System.Windows.Forms.TextBox();
            this.butSelectFile = new System.Windows.Forms.Button();
            this.fldListPath = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.butExportFile = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tltCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Путь до XML-лога";
            // 
            // fldPath
            // 
            this.fldPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fldPath.Location = new System.Drawing.Point(15, 51);
            this.fldPath.Name = "fldPath";
            this.fldPath.Size = new System.Drawing.Size(555, 20);
            this.fldPath.TabIndex = 1;
            // 
            // butSelectFile
            // 
            this.butSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butSelectFile.Location = new System.Drawing.Point(604, 49);
            this.butSelectFile.Name = "butSelectFile";
            this.butSelectFile.Size = new System.Drawing.Size(75, 23);
            this.butSelectFile.TabIndex = 2;
            this.butSelectFile.Text = "Обзор";
            this.butSelectFile.UseVisualStyleBackColor = true;
            // 
            // fldListPath
            // 
            this.fldListPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fldListPath.Location = new System.Drawing.Point(15, 95);
            this.fldListPath.Multiline = true;
            this.fldListPath.Name = "fldListPath";
            this.fldListPath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.fldListPath.Size = new System.Drawing.Size(664, 302);
            this.fldListPath.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tltCounter});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(705, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // butExportFile
            // 
            this.butExportFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butExportFile.Location = new System.Drawing.Point(564, 408);
            this.butExportFile.Name = "butExportFile";
            this.butExportFile.Size = new System.Drawing.Size(115, 23);
            this.butExportFile.TabIndex = 5;
            this.butExportFile.Text = "Экспортировать";
            this.butExportFile.UseVisualStyleBackColor = true;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "Количество строк:";
            // 
            // tltCounter
            // 
            this.tltCounter.Name = "tltCounter";
            this.tltCounter.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 461);
            this.Controls.Add(this.butExportFile);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.fldListPath);
            this.Controls.Add(this.butSelectFile);
            this.Controls.Add(this.fldPath);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Парсер XML-лога (исключений Касперского)";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fldPath;
        private System.Windows.Forms.Button butSelectFile;
        private System.Windows.Forms.TextBox fldListPath;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button butExportFile;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tltCounter;
    }
}

