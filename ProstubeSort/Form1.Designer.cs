namespace ProstubeSort
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.OutDataListBox = new System.Windows.Forms.ListBox();
            this.panel_all = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_ButtonExceptMy = new System.Windows.Forms.Panel();
            this.checkActBroker = new System.Windows.Forms.CheckBox();
            this.BrokerAudioCheck = new System.Windows.Forms.CheckBox();
            this.BrokerVideoCheck = new System.Windows.Forms.CheckBox();
            this.DocCheck = new System.Windows.Forms.CheckBox();
            this.PhotosCheck = new System.Windows.Forms.CheckBox();
            this.AudioCheck = new System.Windows.Forms.CheckBox();
            this.BrokerPhotosCheck = new System.Windows.Forms.CheckBox();
            this.TxtCheck = new System.Windows.Forms.CheckBox();
            this.ZipCheck = new System.Windows.Forms.CheckBox();
            this.VideoCheck = new System.Windows.Forms.CheckBox();
            this.button_sort = new System.Windows.Forms.Button();
            this.button_result = new System.Windows.Forms.Button();
            this.button_scan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_buttonFiles = new System.Windows.Forms.Panel();
            this.MyCheck = new System.Windows.Forms.CheckBox();
            this.MyBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.wayBox_result = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button_review = new System.Windows.Forms.Button();
            this.wayBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel_all.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_ButtonExceptMy.SuspendLayout();
            this.panel_buttonFiles.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(128, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Заполните данные для сортировки";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitHubToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(624, 30);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.gitHubToolStripMenuItem.Text = "GitHub";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // OutDataListBox
            // 
            this.OutDataListBox.FormattingEnabled = true;
            this.OutDataListBox.HorizontalExtent = 3000;
            this.OutDataListBox.HorizontalScrollbar = true;
            this.OutDataListBox.ItemHeight = 20;
            this.OutDataListBox.Location = new System.Drawing.Point(3, 473);
            this.OutDataListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OutDataListBox.Name = "OutDataListBox";
            this.OutDataListBox.Size = new System.Drawing.Size(610, 284);
            this.OutDataListBox.TabIndex = 11;
            // 
            // panel_all
            // 
            this.panel_all.Controls.Add(this.panel1);
            this.panel_all.Location = new System.Drawing.Point(6, 81);
            this.panel_all.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_all.Name = "panel_all";
            this.panel_all.Size = new System.Drawing.Size(618, 384);
            this.panel_all.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel_ButtonExceptMy);
            this.panel1.Controls.Add(this.button_sort);
            this.panel1.Controls.Add(this.button_result);
            this.panel1.Controls.Add(this.button_scan);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel_buttonFiles);
            this.panel1.Controls.Add(this.wayBox_result);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 379);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = " (Примечание: она должна быть пустая)";
            // 
            // panel_ButtonExceptMy
            // 
            this.panel_ButtonExceptMy.Controls.Add(this.checkActBroker);
            this.panel_ButtonExceptMy.Controls.Add(this.BrokerAudioCheck);
            this.panel_ButtonExceptMy.Controls.Add(this.BrokerVideoCheck);
            this.panel_ButtonExceptMy.Controls.Add(this.DocCheck);
            this.panel_ButtonExceptMy.Controls.Add(this.PhotosCheck);
            this.panel_ButtonExceptMy.Controls.Add(this.AudioCheck);
            this.panel_ButtonExceptMy.Controls.Add(this.BrokerPhotosCheck);
            this.panel_ButtonExceptMy.Controls.Add(this.TxtCheck);
            this.panel_ButtonExceptMy.Controls.Add(this.ZipCheck);
            this.panel_ButtonExceptMy.Controls.Add(this.VideoCheck);
            this.panel_ButtonExceptMy.Enabled = false;
            this.panel_ButtonExceptMy.Location = new System.Drawing.Point(14, 79);
            this.panel_ButtonExceptMy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_ButtonExceptMy.Name = "panel_ButtonExceptMy";
            this.panel_ButtonExceptMy.Size = new System.Drawing.Size(593, 71);
            this.panel_ButtonExceptMy.TabIndex = 12;
            // 
            // checkActBroker
            // 
            this.checkActBroker.AutoSize = true;
            this.checkActBroker.Location = new System.Drawing.Point(397, 37);
            this.checkActBroker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkActBroker.Name = "checkActBroker";
            this.checkActBroker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkActBroker.Size = new System.Drawing.Size(37, 24);
            this.checkActBroker.TabIndex = 10;
            this.checkActBroker.Text = "-";
            this.checkActBroker.UseVisualStyleBackColor = true;
            this.checkActBroker.CheckedChanged += new System.EventHandler(this.checkActBroker_CheckedChanged);
            // 
            // BrokerAudioCheck
            // 
            this.BrokerAudioCheck.AutoSize = true;
            this.BrokerAudioCheck.Enabled = false;
            this.BrokerAudioCheck.Location = new System.Drawing.Point(283, 37);
            this.BrokerAudioCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BrokerAudioCheck.Name = "BrokerAudioCheck";
            this.BrokerAudioCheck.Size = new System.Drawing.Size(119, 24);
            this.BrokerAudioCheck.TabIndex = 9;
            this.BrokerAudioCheck.Text = "Битые аудио";
            this.BrokerAudioCheck.UseVisualStyleBackColor = true;
            // 
            // BrokerVideoCheck
            // 
            this.BrokerVideoCheck.AutoSize = true;
            this.BrokerVideoCheck.Enabled = false;
            this.BrokerVideoCheck.Location = new System.Drawing.Point(168, 37);
            this.BrokerVideoCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BrokerVideoCheck.Name = "BrokerVideoCheck";
            this.BrokerVideoCheck.Size = new System.Drawing.Size(120, 24);
            this.BrokerVideoCheck.TabIndex = 8;
            this.BrokerVideoCheck.Text = "Битые видео";
            this.BrokerVideoCheck.UseVisualStyleBackColor = true;
            // 
            // DocCheck
            // 
            this.DocCheck.AutoSize = true;
            this.DocCheck.Location = new System.Drawing.Point(126, 4);
            this.DocCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DocCheck.Name = "DocCheck";
            this.DocCheck.Size = new System.Drawing.Size(109, 24);
            this.DocCheck.TabIndex = 2;
            this.DocCheck.Text = "Документы";
            this.DocCheck.UseVisualStyleBackColor = true;
            // 
            // PhotosCheck
            // 
            this.PhotosCheck.AutoSize = true;
            this.PhotosCheck.Location = new System.Drawing.Point(10, 4);
            this.PhotosCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PhotosCheck.Name = "PhotosCheck";
            this.PhotosCheck.Size = new System.Drawing.Size(117, 24);
            this.PhotosCheck.TabIndex = 0;
            this.PhotosCheck.Text = "Фотографии";
            this.PhotosCheck.UseVisualStyleBackColor = true;
            // 
            // AudioCheck
            // 
            this.AudioCheck.AutoSize = true;
            this.AudioCheck.Location = new System.Drawing.Point(241, 4);
            this.AudioCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AudioCheck.Name = "AudioCheck";
            this.AudioCheck.Size = new System.Drawing.Size(74, 24);
            this.AudioCheck.TabIndex = 3;
            this.AudioCheck.Text = "Аудио";
            this.AudioCheck.UseVisualStyleBackColor = true;
            // 
            // BrokerPhotosCheck
            // 
            this.BrokerPhotosCheck.AutoSize = true;
            this.BrokerPhotosCheck.Enabled = false;
            this.BrokerPhotosCheck.Location = new System.Drawing.Point(10, 35);
            this.BrokerPhotosCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BrokerPhotosCheck.Name = "BrokerPhotosCheck";
            this.BrokerPhotosCheck.Size = new System.Drawing.Size(163, 24);
            this.BrokerPhotosCheck.TabIndex = 7;
            this.BrokerPhotosCheck.Text = "Битые фотографии";
            this.BrokerPhotosCheck.UseVisualStyleBackColor = true;
            this.BrokerPhotosCheck.CheckedChanged += new System.EventHandler(this.BrokerPhotosCheck_CheckedChanged);
            // 
            // TxtCheck
            // 
            this.TxtCheck.AutoSize = true;
            this.TxtCheck.Location = new System.Drawing.Point(321, 4);
            this.TxtCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCheck.Name = "TxtCheck";
            this.TxtCheck.Size = new System.Drawing.Size(50, 24);
            this.TxtCheck.TabIndex = 4;
            this.TxtCheck.Text = "Txt";
            this.TxtCheck.UseVisualStyleBackColor = true;
            // 
            // ZipCheck
            // 
            this.ZipCheck.AutoSize = true;
            this.ZipCheck.Location = new System.Drawing.Point(463, 4);
            this.ZipCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ZipCheck.Name = "ZipCheck";
            this.ZipCheck.Size = new System.Drawing.Size(85, 24);
            this.ZipCheck.TabIndex = 6;
            this.ZipCheck.Text = "Архивы";
            this.ZipCheck.UseVisualStyleBackColor = true;
            // 
            // VideoCheck
            // 
            this.VideoCheck.AutoSize = true;
            this.VideoCheck.Location = new System.Drawing.Point(383, 4);
            this.VideoCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VideoCheck.Name = "VideoCheck";
            this.VideoCheck.Size = new System.Drawing.Size(74, 24);
            this.VideoCheck.TabIndex = 5;
            this.VideoCheck.Text = "Видео";
            this.VideoCheck.UseVisualStyleBackColor = true;
            // 
            // button_sort
            // 
            this.button_sort.Enabled = false;
            this.button_sort.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_sort.Location = new System.Drawing.Point(312, 315);
            this.button_sort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_sort.Name = "button_sort";
            this.button_sort.Size = new System.Drawing.Size(157, 49);
            this.button_sort.TabIndex = 6;
            this.button_sort.Text = "Сортировать";
            this.button_sort.UseVisualStyleBackColor = true;
            this.button_sort.Click += new System.EventHandler(this.button_sort_Click);
            // 
            // button_result
            // 
            this.button_result.Location = new System.Drawing.Point(514, 280);
            this.button_result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_result.Name = "button_result";
            this.button_result.Size = new System.Drawing.Size(86, 31);
            this.button_result.TabIndex = 4;
            this.button_result.Text = "Обзор";
            this.button_result.UseVisualStyleBackColor = true;
            this.button_result.Click += new System.EventHandler(this.button_result_Click);
            // 
            // button_scan
            // 
            this.button_scan.Enabled = false;
            this.button_scan.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_scan.Location = new System.Drawing.Point(141, 315);
            this.button_scan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_scan.Name = "button_scan";
            this.button_scan.Size = new System.Drawing.Size(157, 49);
            this.button_scan.TabIndex = 7;
            this.button_scan.Text = "Сканировать";
            this.button_scan.UseVisualStyleBackColor = true;
            this.button_scan.Click += new System.EventHandler(this.button_scan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(98, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Папка, в которую будут перемещены сортированные файлы";
            // 
            // panel_buttonFiles
            // 
            this.panel_buttonFiles.Controls.Add(this.MyCheck);
            this.panel_buttonFiles.Controls.Add(this.MyBox);
            this.panel_buttonFiles.Controls.Add(this.label4);
            this.panel_buttonFiles.Enabled = false;
            this.panel_buttonFiles.Location = new System.Drawing.Point(14, 79);
            this.panel_buttonFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_buttonFiles.Name = "panel_buttonFiles";
            this.panel_buttonFiles.Size = new System.Drawing.Size(590, 143);
            this.panel_buttonFiles.TabIndex = 5;
            // 
            // MyCheck
            // 
            this.MyCheck.AutoSize = true;
            this.MyCheck.Location = new System.Drawing.Point(363, 104);
            this.MyCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MyCheck.Name = "MyCheck";
            this.MyCheck.Size = new System.Drawing.Size(18, 17);
            this.MyCheck.TabIndex = 10;
            this.MyCheck.UseVisualStyleBackColor = true;
            this.MyCheck.CheckedChanged += new System.EventHandler(this.MyCheck_CheckedChanged);
            // 
            // MyBox
            // 
            this.MyBox.Enabled = false;
            this.MyBox.Location = new System.Drawing.Point(243, 99);
            this.MyBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MyBox.Name = "MyBox";
            this.MyBox.PlaceholderText = "    Пример: jar";
            this.MyBox.Size = new System.Drawing.Size(114, 27);
            this.MyBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Свое расширение *BETA";
            // 
            // wayBox_result
            // 
            this.wayBox_result.Location = new System.Drawing.Point(20, 280);
            this.wayBox_result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wayBox_result.Name = "wayBox_result";
            this.wayBox_result.ReadOnly = true;
            this.wayBox_result.Size = new System.Drawing.Size(487, 27);
            this.wayBox_result.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button_review);
            this.panel2.Controls.Add(this.wayBox);
            this.panel2.Location = new System.Drawing.Point(14, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 79);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(127, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Папка, в которой будет производиться сортировка";
            // 
            // button_review
            // 
            this.button_review.Location = new System.Drawing.Point(502, 36);
            this.button_review.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_review.Name = "button_review";
            this.button_review.Size = new System.Drawing.Size(86, 31);
            this.button_review.TabIndex = 0;
            this.button_review.Text = "Обзор";
            this.button_review.UseVisualStyleBackColor = true;
            this.button_review.Click += new System.EventHandler(this.button_review_Click);
            // 
            // wayBox
            // 
            this.wayBox.Location = new System.Drawing.Point(7, 36);
            this.wayBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wayBox.Name = "wayBox";
            this.wayBox.ReadOnly = true;
            this.wayBox.Size = new System.Drawing.Size(487, 27);
            this.wayBox.TabIndex = 1;
            this.wayBox.TextChanged += new System.EventHandler(this.wayBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProstubeSort.Properties.Resources.kisspng_electric_blue_graphic_design_angle_area_public_5ab062b5c26c20_6651072415215090457964;
            this.pictureBox1.Location = new System.Drawing.Point(534, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(624, 768);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OutDataListBox);
            this.Controls.Add(this.panel_all);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProstubeSort";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_all.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_ButtonExceptMy.ResumeLayout(false);
            this.panel_ButtonExceptMy.PerformLayout();
            this.panel_buttonFiles.ResumeLayout(false);
            this.panel_buttonFiles.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem gitHubToolStripMenuItem;
        private FolderBrowserDialog folderBrowserDialog1;
        private ListBox OutDataListBox;
        private Panel panel_all;
        private Panel panel1;
        private Button button_sort;
        private Button button_result;
        private Button button_scan;
        private Label label3;
        private Panel panel_buttonFiles;
        private TextBox MyBox;
        private Label label4;
        private CheckBox BrokerPhotosCheck;
        private CheckBox ZipCheck;
        private CheckBox VideoCheck;
        private CheckBox TxtCheck;
        private CheckBox AudioCheck;
        private CheckBox DocCheck;
        private CheckBox PhotosCheck;
        private TextBox wayBox_result;
        private Panel panel2;
        private Label label2;
        private Button button_review;
        private TextBox wayBox;
        private CheckBox MyCheck;
        private Panel panel_ButtonExceptMy;
        private CheckBox BrokerVideoCheck;
        private CheckBox BrokerAudioCheck;
        private CheckBox checkActBroker;
        private PictureBox pictureBox1;
        private Label label5;
    }
}