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
            this.heading = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advanced_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.языкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.OutDataListBox = new System.Windows.Forms.ListBox();
            this.panel_all = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_ButtonExceptMy = new System.Windows.Forms.Panel();
            this.PresentCheck = new System.Windows.Forms.CheckBox();
            this.PdfCheck = new System.Windows.Forms.CheckBox();
            this.TableCheck = new System.Windows.Forms.CheckBox();
            this.TorrentCheck = new System.Windows.Forms.CheckBox();
            this.HtmlCheck = new System.Windows.Forms.CheckBox();
            this.PsdCheck = new System.Windows.Forms.CheckBox();
            this.DocCheck = new System.Windows.Forms.CheckBox();
            this.PhotosCheck = new System.Windows.Forms.CheckBox();
            this.AudioCheck = new System.Windows.Forms.CheckBox();
            this.BrokenPhotosCheck = new System.Windows.Forms.CheckBox();
            this.TxtCheck = new System.Windows.Forms.CheckBox();
            this.ZipFilesCheck = new System.Windows.Forms.CheckBox();
            this.VideoCheck = new System.Windows.Forms.CheckBox();
            this.button_sort = new System.Windows.Forms.Button();
            this.button_result = new System.Windows.Forms.Button();
            this.button_scan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_buttonFiles = new System.Windows.Forms.Panel();
            this.AllCheck = new System.Windows.Forms.CheckBox();
            this.MyCheck = new System.Windows.Forms.CheckBox();
            this.MyBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.wayBox_result = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button_review = new System.Windows.Forms.Button();
            this.wayBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_setting = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textFolderBrokenPhotos = new System.Windows.Forms.TextBox();
            this.textFolderSpreadsheets = new System.Windows.Forms.TextBox();
            this.textFolderPresentations = new System.Windows.Forms.TextBox();
            this.textFolderTorrent = new System.Windows.Forms.TextBox();
            this.textFolderHtml = new System.Windows.Forms.TextBox();
            this.textFolderZipFiles = new System.Windows.Forms.TextBox();
            this.textFolderTxt = new System.Windows.Forms.TextBox();
            this.textFolderPsd = new System.Windows.Forms.TextBox();
            this.textFolder_pdf = new System.Windows.Forms.TextBox();
            this.textFolder_Video = new System.Windows.Forms.TextBox();
            this.textFolder_Doc = new System.Windows.Forms.TextBox();
            this.textFolder_audio = new System.Windows.Forms.TextBox();
            this.textFolder_photos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.notificC_Check = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            this.panel_all.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_ButtonExceptMy.SuspendLayout();
            this.panel_buttonFiles.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_setting.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // heading
            // 
            this.heading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.heading.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.heading.Location = new System.Drawing.Point(107, 30);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(410, 32);
            this.heading.TabIndex = 2;
            this.heading.Text = "Заполните данные для сортировки";
            this.heading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.advanced_settings,
            this.языкToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(624, 30);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.mainToolStripMenuItem.Text = "Главная";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // advanced_settings
            // 
            this.advanced_settings.Name = "advanced_settings";
            this.advanced_settings.Size = new System.Drawing.Size(198, 24);
            this.advanced_settings.Text = "Расширенные настройки";
            this.advanced_settings.Click += new System.EventHandler(this.advanced_settings_Click);
            // 
            // языкToolStripMenuItem
            // 
            this.языкToolStripMenuItem.Name = "языкToolStripMenuItem";
            this.языкToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.языкToolStripMenuItem.Text = "Язык";
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
            this.OutDataListBox.Location = new System.Drawing.Point(6, 517);
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
            this.panel_all.Size = new System.Drawing.Size(618, 428);
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
            this.panel1.Size = new System.Drawing.Size(618, 424);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = " (Примечание: она должна быть пустая)";
            // 
            // panel_ButtonExceptMy
            // 
            this.panel_ButtonExceptMy.Controls.Add(this.PresentCheck);
            this.panel_ButtonExceptMy.Controls.Add(this.PdfCheck);
            this.panel_ButtonExceptMy.Controls.Add(this.TableCheck);
            this.panel_ButtonExceptMy.Controls.Add(this.TorrentCheck);
            this.panel_ButtonExceptMy.Controls.Add(this.HtmlCheck);
            this.panel_ButtonExceptMy.Controls.Add(this.PsdCheck);
            this.panel_ButtonExceptMy.Controls.Add(this.DocCheck);
            this.panel_ButtonExceptMy.Controls.Add(this.PhotosCheck);
            this.panel_ButtonExceptMy.Controls.Add(this.AudioCheck);
            this.panel_ButtonExceptMy.Controls.Add(this.BrokenPhotosCheck);
            this.panel_ButtonExceptMy.Controls.Add(this.TxtCheck);
            this.panel_ButtonExceptMy.Controls.Add(this.ZipFilesCheck);
            this.panel_ButtonExceptMy.Controls.Add(this.VideoCheck);
            this.panel_ButtonExceptMy.Enabled = false;
            this.panel_ButtonExceptMy.Location = new System.Drawing.Point(14, 79);
            this.panel_ButtonExceptMy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_ButtonExceptMy.Name = "panel_ButtonExceptMy";
            this.panel_ButtonExceptMy.Size = new System.Drawing.Size(593, 131);
            this.panel_ButtonExceptMy.TabIndex = 12;
            // 
            // PresentCheck
            // 
            this.PresentCheck.AutoSize = true;
            this.PresentCheck.Location = new System.Drawing.Point(463, 36);
            this.PresentCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PresentCheck.Name = "PresentCheck";
            this.PresentCheck.Size = new System.Drawing.Size(124, 24);
            this.PresentCheck.TabIndex = 16;
            this.PresentCheck.Text = "Презентации";
            this.PresentCheck.UseVisualStyleBackColor = true;
            // 
            // PdfCheck
            // 
            this.PdfCheck.AutoSize = true;
            this.PdfCheck.Location = new System.Drawing.Point(318, 36);
            this.PdfCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PdfCheck.Name = "PdfCheck";
            this.PdfCheck.Size = new System.Drawing.Size(139, 24);
            this.PdfCheck.TabIndex = 15;
            this.PdfCheck.Text = "PDF-документы";
            this.PdfCheck.UseVisualStyleBackColor = true;
            // 
            // TableCheck
            // 
            this.TableCheck.AutoSize = true;
            this.TableCheck.Location = new System.Drawing.Point(124, 36);
            this.TableCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TableCheck.Name = "TableCheck";
            this.TableCheck.Size = new System.Drawing.Size(188, 24);
            this.TableCheck.TabIndex = 14;
            this.TableCheck.Text = "Электронные таблицы";
            this.TableCheck.UseVisualStyleBackColor = true;
            // 
            // TorrentCheck
            // 
            this.TorrentCheck.AutoSize = true;
            this.TorrentCheck.Location = new System.Drawing.Point(354, 68);
            this.TorrentCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TorrentCheck.Name = "TorrentCheck";
            this.TorrentCheck.Size = new System.Drawing.Size(139, 24);
            this.TorrentCheck.TabIndex = 13;
            this.TorrentCheck.Text = "Торрент файлы";
            this.TorrentCheck.UseVisualStyleBackColor = true;
            // 
            // HtmlCheck
            // 
            this.HtmlCheck.AutoSize = true;
            this.HtmlCheck.Location = new System.Drawing.Point(149, 68);
            this.HtmlCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HtmlCheck.Name = "HtmlCheck";
            this.HtmlCheck.Size = new System.Drawing.Size(197, 24);
            this.HtmlCheck.TabIndex = 12;
            this.HtmlCheck.Text = "Cтраницы из интернета";
            this.HtmlCheck.UseVisualStyleBackColor = true;
            // 
            // PsdCheck
            // 
            this.PsdCheck.AutoSize = true;
            this.PsdCheck.Location = new System.Drawing.Point(9, 68);
            this.PsdCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PsdCheck.Name = "PsdCheck";
            this.PsdCheck.Size = new System.Drawing.Size(134, 24);
            this.PsdCheck.TabIndex = 11;
            this.PsdCheck.Text = "Фотошоп (psd)";
            this.PsdCheck.UseVisualStyleBackColor = true;
            // 
            // DocCheck
            // 
            this.DocCheck.AutoSize = true;
            this.DocCheck.Location = new System.Drawing.Point(10, 36);
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
            this.AudioCheck.Location = new System.Drawing.Point(132, 4);
            this.AudioCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AudioCheck.Name = "AudioCheck";
            this.AudioCheck.Size = new System.Drawing.Size(74, 24);
            this.AudioCheck.TabIndex = 3;
            this.AudioCheck.Text = "Аудио";
            this.AudioCheck.UseVisualStyleBackColor = true;
            // 
            // BrokenPhotosCheck
            // 
            this.BrokenPhotosCheck.AutoSize = true;
            this.BrokenPhotosCheck.Location = new System.Drawing.Point(7, 100);
            this.BrokenPhotosCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BrokenPhotosCheck.Name = "BrokenPhotosCheck";
            this.BrokenPhotosCheck.Size = new System.Drawing.Size(163, 24);
            this.BrokenPhotosCheck.TabIndex = 7;
            this.BrokenPhotosCheck.Text = "Битые фотографии";
            this.BrokenPhotosCheck.UseVisualStyleBackColor = true;
            this.BrokenPhotosCheck.CheckedChanged += new System.EventHandler(this.BrokerPhotosCheck_CheckedChanged);
            // 
            // TxtCheck
            // 
            this.TxtCheck.AutoSize = true;
            this.TxtCheck.Location = new System.Drawing.Point(212, 4);
            this.TxtCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCheck.Name = "TxtCheck";
            this.TxtCheck.Size = new System.Drawing.Size(50, 24);
            this.TxtCheck.TabIndex = 4;
            this.TxtCheck.Text = "Txt";
            this.TxtCheck.UseVisualStyleBackColor = true;
            // 
            // ZipFilesCheck
            // 
            this.ZipFilesCheck.AutoSize = true;
            this.ZipFilesCheck.Location = new System.Drawing.Point(354, 4);
            this.ZipFilesCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ZipFilesCheck.Name = "ZipFilesCheck";
            this.ZipFilesCheck.Size = new System.Drawing.Size(85, 24);
            this.ZipFilesCheck.TabIndex = 6;
            this.ZipFilesCheck.Text = "Архивы";
            this.ZipFilesCheck.UseVisualStyleBackColor = true;
            // 
            // VideoCheck
            // 
            this.VideoCheck.AutoSize = true;
            this.VideoCheck.Location = new System.Drawing.Point(274, 4);
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
            this.button_sort.Location = new System.Drawing.Point(314, 361);
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
            this.button_result.Location = new System.Drawing.Point(516, 326);
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
            this.button_scan.Location = new System.Drawing.Point(143, 361);
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
            this.label3.Location = new System.Drawing.Point(100, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Папка, в которую будут перемещены сортированные файлы";
            // 
            // panel_buttonFiles
            // 
            this.panel_buttonFiles.Controls.Add(this.AllCheck);
            this.panel_buttonFiles.Controls.Add(this.MyCheck);
            this.panel_buttonFiles.Controls.Add(this.MyBox);
            this.panel_buttonFiles.Controls.Add(this.label4);
            this.panel_buttonFiles.Enabled = false;
            this.panel_buttonFiles.Location = new System.Drawing.Point(14, 79);
            this.panel_buttonFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_buttonFiles.Name = "panel_buttonFiles";
            this.panel_buttonFiles.Size = new System.Drawing.Size(590, 189);
            this.panel_buttonFiles.TabIndex = 5;
            // 
            // AllCheck
            // 
            this.AllCheck.AutoSize = true;
            this.AllCheck.Location = new System.Drawing.Point(7, 148);
            this.AllCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AllCheck.Name = "AllCheck";
            this.AllCheck.Size = new System.Drawing.Size(210, 24);
            this.AllCheck.TabIndex = 17;
            this.AllCheck.Text = "Выбрать все расширения";
            this.AllCheck.UseVisualStyleBackColor = true;
            this.AllCheck.CheckedChanged += new System.EventHandler(this.AllCheck_CheckedChanged);
            // 
            // MyCheck
            // 
            this.MyCheck.AutoSize = true;
            this.MyCheck.Location = new System.Drawing.Point(358, 164);
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
            this.MyBox.Location = new System.Drawing.Point(238, 159);
            this.MyBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MyBox.MaxLength = 20;
            this.MyBox.Name = "MyBox";
            this.MyBox.PlaceholderText = "    Пример: jar";
            this.MyBox.Size = new System.Drawing.Size(114, 27);
            this.MyBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Свое расширение *BETA";
            // 
            // wayBox_result
            // 
            this.wayBox_result.Location = new System.Drawing.Point(22, 326);
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
            this.panel2.Size = new System.Drawing.Size(593, 71);
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
            // panel_setting
            // 
            this.panel_setting.Controls.Add(this.panel4);
            this.panel_setting.Controls.Add(this.panel3);
            this.panel_setting.Controls.Add(this.label1);
            this.panel_setting.Location = new System.Drawing.Point(6, 33);
            this.panel_setting.Name = "panel_setting";
            this.panel_setting.Size = new System.Drawing.Size(615, 779);
            this.panel_setting.TabIndex = 13;
            this.panel_setting.Visible = false;
            this.panel_setting.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_setting_Paint);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textFolderBrokenPhotos);
            this.panel4.Controls.Add(this.textFolderSpreadsheets);
            this.panel4.Controls.Add(this.textFolderPresentations);
            this.panel4.Controls.Add(this.textFolderTorrent);
            this.panel4.Controls.Add(this.textFolderHtml);
            this.panel4.Controls.Add(this.textFolderZipFiles);
            this.panel4.Controls.Add(this.textFolderTxt);
            this.panel4.Controls.Add(this.textFolderPsd);
            this.panel4.Controls.Add(this.textFolder_pdf);
            this.panel4.Controls.Add(this.textFolder_Video);
            this.panel4.Controls.Add(this.textFolder_Doc);
            this.panel4.Controls.Add(this.textFolder_audio);
            this.panel4.Controls.Add(this.textFolder_photos);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(3, 93);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(607, 187);
            this.panel4.TabIndex = 5;
            // 
            // textFolderBrokenPhotos
            // 
            this.textFolderBrokenPhotos.Location = new System.Drawing.Point(187, 152);
            this.textFolderBrokenPhotos.Name = "textFolderBrokenPhotos";
            this.textFolderBrokenPhotos.Size = new System.Drawing.Size(221, 27);
            this.textFolderBrokenPhotos.TabIndex = 13;
            this.textFolderBrokenPhotos.Text = "Broken Photos";
            this.textFolderBrokenPhotos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textFolderSpreadsheets
            // 
            this.textFolderSpreadsheets.Location = new System.Drawing.Point(461, 108);
            this.textFolderSpreadsheets.Name = "textFolderSpreadsheets";
            this.textFolderSpreadsheets.Size = new System.Drawing.Size(140, 27);
            this.textFolderSpreadsheets.TabIndex = 12;
            this.textFolderSpreadsheets.Text = "Spreadsheets";
            this.textFolderSpreadsheets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textFolderPresentations
            // 
            this.textFolderPresentations.Location = new System.Drawing.Point(310, 108);
            this.textFolderPresentations.Name = "textFolderPresentations";
            this.textFolderPresentations.Size = new System.Drawing.Size(140, 27);
            this.textFolderPresentations.TabIndex = 11;
            this.textFolderPresentations.Text = "Presentations";
            this.textFolderPresentations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textFolderTorrent
            // 
            this.textFolderTorrent.Location = new System.Drawing.Point(160, 108);
            this.textFolderTorrent.Name = "textFolderTorrent";
            this.textFolderTorrent.Size = new System.Drawing.Size(140, 27);
            this.textFolderTorrent.TabIndex = 10;
            this.textFolderTorrent.Text = "Torrent";
            this.textFolderTorrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textFolderHtml
            // 
            this.textFolderHtml.Location = new System.Drawing.Point(7, 108);
            this.textFolderHtml.Name = "textFolderHtml";
            this.textFolderHtml.Size = new System.Drawing.Size(140, 27);
            this.textFolderHtml.TabIndex = 9;
            this.textFolderHtml.Text = "Html";
            this.textFolderHtml.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textFolderZipFiles
            // 
            this.textFolderZipFiles.Location = new System.Drawing.Point(461, 75);
            this.textFolderZipFiles.Name = "textFolderZipFiles";
            this.textFolderZipFiles.Size = new System.Drawing.Size(140, 27);
            this.textFolderZipFiles.TabIndex = 8;
            this.textFolderZipFiles.Text = "Archives";
            this.textFolderZipFiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textFolderTxt
            // 
            this.textFolderTxt.Location = new System.Drawing.Point(461, 42);
            this.textFolderTxt.Name = "textFolderTxt";
            this.textFolderTxt.Size = new System.Drawing.Size(140, 27);
            this.textFolderTxt.TabIndex = 7;
            this.textFolderTxt.Text = "Txt";
            this.textFolderTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textFolderPsd
            // 
            this.textFolderPsd.Location = new System.Drawing.Point(310, 42);
            this.textFolderPsd.Name = "textFolderPsd";
            this.textFolderPsd.Size = new System.Drawing.Size(140, 27);
            this.textFolderPsd.TabIndex = 6;
            this.textFolderPsd.Text = "Psd-photoshop";
            this.textFolderPsd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textFolder_pdf
            // 
            this.textFolder_pdf.Location = new System.Drawing.Point(310, 75);
            this.textFolder_pdf.Name = "textFolder_pdf";
            this.textFolder_pdf.Size = new System.Drawing.Size(140, 27);
            this.textFolder_pdf.TabIndex = 5;
            this.textFolder_pdf.Text = "Pdf-Document";
            this.textFolder_pdf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textFolder_Video
            // 
            this.textFolder_Video.Location = new System.Drawing.Point(160, 75);
            this.textFolder_Video.Name = "textFolder_Video";
            this.textFolder_Video.Size = new System.Drawing.Size(140, 27);
            this.textFolder_Video.TabIndex = 4;
            this.textFolder_Video.Text = "Video";
            this.textFolder_Video.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textFolder_Doc
            // 
            this.textFolder_Doc.Location = new System.Drawing.Point(160, 42);
            this.textFolder_Doc.Name = "textFolder_Doc";
            this.textFolder_Doc.Size = new System.Drawing.Size(140, 27);
            this.textFolder_Doc.TabIndex = 3;
            this.textFolder_Doc.Text = "Documents";
            this.textFolder_Doc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textFolder_audio
            // 
            this.textFolder_audio.Location = new System.Drawing.Point(7, 75);
            this.textFolder_audio.Name = "textFolder_audio";
            this.textFolder_audio.Size = new System.Drawing.Size(140, 27);
            this.textFolder_audio.TabIndex = 2;
            this.textFolder_audio.Text = "Audio";
            this.textFolder_audio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textFolder_photos
            // 
            this.textFolder_photos.Location = new System.Drawing.Point(7, 42);
            this.textFolder_photos.Name = "textFolder_photos";
            this.textFolder_photos.Size = new System.Drawing.Size(140, 27);
            this.textFolder_photos.TabIndex = 1;
            this.textFolder_photos.Text = "Photos";
            this.textFolder_photos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(235, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Названия папок";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.notificC_Check);
            this.panel3.Location = new System.Drawing.Point(3, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 44);
            this.panel3.TabIndex = 4;
            // 
            // notificC_Check
            // 
            this.notificC_Check.AutoSize = true;
            this.notificC_Check.Checked = true;
            this.notificC_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.notificC_Check.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.notificC_Check.Location = new System.Drawing.Point(98, 4);
            this.notificC_Check.Name = "notificC_Check";
            this.notificC_Check.Size = new System.Drawing.Size(431, 32);
            this.notificC_Check.TabIndex = 0;
            this.notificC_Check.Tag = "1";
            this.notificC_Check.Text = "Предупреждать об использовании диска C";
            this.notificC_Check.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(164, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Расширенные настройки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(624, 814);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_setting);
            this.Controls.Add(this.OutDataListBox);
            this.Controls.Add(this.panel_all);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.heading);
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
            this.panel_setting.ResumeLayout(false);
            this.panel_setting.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label heading;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainToolStripMenuItem;
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
        private CheckBox BrokenPhotosCheck;
        private CheckBox ZipFilesCheck;
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
        private PictureBox pictureBox1;
        private Label label5;
        private CheckBox PsdCheck;
        private CheckBox HtmlCheck;
        private CheckBox TorrentCheck;
        private CheckBox TableCheck;
        private CheckBox PresentCheck;
        private CheckBox PdfCheck;
        private CheckBox AllCheck;
        private ToolStripMenuItem языкToolStripMenuItem;
        private ToolStripMenuItem advanced_settings;
        private Panel panel_setting;
        private Label label1;
        private Panel panel3;
        private CheckBox notificC_Check;
        private Panel panel4;
        private Label label6;
        private TextBox textFolder_photos;
        private TextBox textFolder_audio;
        private TextBox textFolder_Doc;
        private TextBox textFolder_Video;
        private TextBox textFolder_pdf;
        private TextBox textFolderPsd;
        private TextBox textFolderTxt;
        private TextBox textFolderZipFiles;
        private TextBox textFolderHtml;
        private TextBox textFolderTorrent;
        private TextBox textFolderPresentations;
        private TextBox textFolderSpreadsheets;
        private TextBox textFolderBrokenPhotos;
        private FolderBrowserDialog folderBrowserDialog2;
    }
}