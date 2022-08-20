using System.Media;

namespace ProstubeSort
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region �������������� �� ������������� ���������� C
        void WarningC()
        {
            SystemSounds.Hand.Play();
            DialogResult nameBox = MessageBox.Show("������������ �������� ����������?", "���������",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            if (nameBox == DialogResult.No)
                wayBox.Text = null;
            if (nameBox == DialogResult.Yes)
                MessageBox.Show("��� ��������������� ��������� �� ���", "���������",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);
        }
        #endregion

        #region ����� ����� ��� ����������/������������
        private void button_review_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                wayBox.Text = folderBrowserDialog1.SelectedPath;
                panel_buttonFiles.Enabled = true;
                panel_ButtonExceptMy.Enabled = true;
                button_scan.Enabled = true;
                button_sort.Enabled = true;
                if (wayBox.Text.StartsWith("C"))
                {
                    if (notificC_Check.Checked == true)
                    {
                        WarningC();
                    }
                }
            }
        }
        private void button_result_Click(object sender, EventArgs e)
        {
            folderBrowserDialog2 = new FolderBrowserDialog();
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                wayBox_result.Text = folderBrowserDialog2.SelectedPath;
                if (wayBox_result.Text.StartsWith("C"))
                {
                    if (notificC_Check.Checked == true)
                    {
                        WarningC();
                    }
                }
            }
        }
        #endregion

        #region ������� ������������
        void ScanF(CheckBox nameCheck, string[] extensionsFiles, string nameItems)
        {
            if (nameCheck.Checked)
            {
                OutDataListBox.Items.Add($"{nameItems}:");
                foreach (string expansionPhotos in extensionsFiles)
                {
                    foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", expansionPhotos, SearchOption.AllDirectories))
                    {
                        OutDataListBox.Items.Add(file);
                    }
                }
            }
        }
        #endregion

        #region ������� ����������
        void SortF(string nameFolder, CheckBox nameCheck, string[] extensionsFiles, string nameItems)
        {
            if (nameCheck.Checked)
            {
                Directory.CreateDirectory($@"{wayBox_result.Text}\{nameFolder}");
                OutDataListBox.Items.Add($"{nameItems}");
                foreach (string expansionPhotos in extensionsFiles)
                {
                    foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", expansionPhotos, SearchOption.AllDirectories))
                    {
                        try
                        {
                            string result = Path.GetFileName(file);
                            File.Move(file, $@"{wayBox_result.Text}\{nameFolder}\{result}");
                            OutDataListBox.Items.Add($"�������: {file}");
                        }
                        catch
                        {
                            OutDataListBox.Items.Add($"������: {file}");
                            string result = Path.GetFileName(file);
                            SystemSounds.Hand.Play();
                            DialogResult nameBox = MessageBox.Show($"� ����� ���������� ��� ���� ���� {result}", "���������",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button1);
                        }
                    }
                }
            }
        }
        #endregion

        #region ������ ������������
        private void button_scan_Click(object sender, EventArgs e)
        {
            OutDataListBox.Items.Clear();
            if (wayBox.Text.Length != 0)
            {
                string[] photos = { "*.png", "*.jpeg", "*.jpg", "*.bmp", "*.gif", "*.tif" };
                ScanF(PhotosCheck, photos, "����������");

                string[] doc = { "*.doc", "*.docx", "*.odt" };
                ScanF(DocCheck, doc, "���������");

                string[] table = { "*.xlsx", "*.xls" };
                ScanF(TableCheck, table, "����������� �������");

                string[] pdf = { "*.pdf" };
                ScanF(PdfCheck, pdf, "Pdf ���������");

                string[] present = { "*.ppt", "*.pptx", "*.odp" };
                ScanF(PresentCheck, present, "�����������");

                string[] audio = { "*.mp3", "*.wav", "*.midi", "*.aac" };
                ScanF(AudioCheck, audio, "�����");

                string[] txt = { "*.txt" };
                ScanF(TxtCheck, txt, "Txt");

                string[] video = { "*.mp4", "*.avi", "*.mkv", "*.wmv", "*.mkv", "*.flv", "mpeg" };
                ScanF(VideoCheck, video, "�����");

                string[] zipFiles = { "*.zip", "*.rar", "*.7z", "*.gzip" };
                ScanF(ZipFilesCheck, zipFiles, "������");

                string[] psd = { "*.psd" };
                ScanF(PsdCheck, psd, "�������(psd)");

                string[] html = { "*.html", "*.htm", "*.mht" };
                ScanF(HtmlCheck, html, "�������� �� ���������");

                string[] torrent = { "*.torrent" };
                ScanF(TorrentCheck, torrent, "������� �����");

                #region ����� ����������
                if (BrokenPhotosCheck.Checked)
                {
                    OutDataListBox.Items.Add("����� ����������:");
                    string[] BrokenPhotos = { "*.png", "*.jpeg", "*.jpg", "*.bmp", "*.gif", "*.tif" };
                    foreach (string typePhoto in BrokenPhotos)
                    {
                        foreach (string file in Directory.EnumerateFiles(folderBrowserDialog1.SelectedPath, typePhoto, SearchOption.AllDirectories))
                        {
                            try
                            {
                                using (Bitmap type = new Bitmap(file))
                                {
                                }
                            }
                            catch (ArgumentException)
                            {
                                OutDataListBox.Items.Add(file);
                            }
                        }
                    }
                }
                #endregion

                string[] myExt = { $"*.{MyBox.Text}" };
                ScanF(MyCheck, myExt, MyBox.Text);

                if (OutDataListBox.Items.Count == 0)
                {
                    OutDataListBox.Items.Add("����� � ����� ����������� �� �������");
                }
            }
            else
            {
                SystemSounds.Hand.Play();
                DialogResult nameBox = MessageBox.Show("�� ������� ����������", "���������",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }

        }
        #endregion

        #region ������ ����������
        private void button_sort_Click(object sender, EventArgs e)
        {
            OutDataListBox.Items.Clear();
            if (wayBox.Text.Length != 0 && wayBox_result.Text.Length != 0)
            {
                string[] photos = { "*.png", "*.jpeg", "*.jpg", "*.bmp", "*.gif", "*.tif" };
                SortF(textFolder_photos.Text, PhotosCheck, photos, "����������");

                string[] doc = { "*.doc", "*.docx", "*.odt" };
                SortF(textFolder_Doc.Text, DocCheck, doc, "���������");

                string[] table = { "*.xlsx", "*.xls" };
                SortF(textFolderSpreadsheets.Text, TableCheck, table, "����������� �������");

                string[] pdf = { "*.pdf" };
                SortF(textFolder_pdf.Text, PdfCheck, pdf, "Pdf ���������");

                string[] present = { "*.ppt", "*.pptx", "*.odp" };
                SortF(textFolderPresentations.Text, PresentCheck, present, "�����������");

                string[] audio = { "*.mp3", "*.wav", "*.midi", "*.aac" };
                SortF(textFolder_audio.Text, AudioCheck, audio, "�����");

                string[] txt = { "*.txt" };
                SortF(textFolderTxt.Text, TxtCheck, txt, "Txt");

                string[] video = { "*.mp4", "*.avi", "*.mkv", "*.wmv", "*.mkv", "*.flv", "mpeg" };
                SortF(textFolder_Video.Text, VideoCheck, video, "�����");

                string[] zipFiles = { "*.zip", "*.rar", "*.7z", "*.gzip" };
                SortF(textFolderZipFiles.Text, ZipFilesCheck, zipFiles, "������");

                string[] psd = { "*.psd" };
                SortF(textFolderPsd.Text, PsdCheck, psd, "�������(psd)");

                string[] html = { "*.html", "*.htm", "*.mht" };
                SortF(textFolderHtml.Text, HtmlCheck, html, "�������� �� ���������");

                string[] torrent = { "*.torrent" };
                SortF(textFolderTorrent.Text, TorrentCheck, torrent, "������� �����");

                #region ����� ����������
                if (BrokenPhotosCheck.Checked)
                {
                    Directory.CreateDirectory($@"{wayBox_result.Text}\{textFolderBrokenPhotos.Text}");
                    OutDataListBox.Items.Add("����� ����������:");
                    string[] BrokenPhotos = { "*.png", "*.jpeg", "*.jpg", "*.bmp", "*.gif", "*.tif" };
                    foreach (string typePhoto in BrokenPhotos)
                    {
                        foreach (string file in Directory.EnumerateFiles(folderBrowserDialog1.SelectedPath, typePhoto, SearchOption.AllDirectories))
                        {
                            try
                            {
                                using (Bitmap type = new Bitmap(file))
                                {
                                }
                            }
                            catch
                            {
                                try
                                {
                                    string result = Path.GetFileName(file);
                                    File.Move(file, $@"{wayBox_result.Text}\{textFolderBrokenPhotos.Text}\{result}");
                                    OutDataListBox.Items.Add($"�������: {file}");
                                }
                                catch
                                {
                                    OutDataListBox.Items.Add($"������: {file}");
                                    string result = Path.GetFileName(file);
                                    SystemSounds.Hand.Play();
                                    DialogResult nameBox = MessageBox.Show($"� ����� ���������� ��� ���� ���� {result}", "���������",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning,
                                        MessageBoxDefaultButton.Button1);
                                }
                            }
                        }
                    }
                }
                #endregion

                string[] myEx = { $"*.{MyBox.Text}" };
                SortF(MyBox.Text, MyCheck, myEx, MyBox.Text);

                if (OutDataListBox.Items.Count == 0)
                {
                    OutDataListBox.Items.Add("����� � ����� ����������� �� �������");
                }
            }
            else
            {
                SystemSounds.Hand.Play();
                DialogResult nameBox = MessageBox.Show("�� ������� ����������", "���������",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }

        #endregion

        private void MyCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (MyCheck.Checked)
            {
                CheckBox[] ailR = { PhotosCheck, DocCheck, AudioCheck, ZipFilesCheck, HtmlCheck, PdfCheck,
                TableCheck, VideoCheck, TorrentCheck, PsdCheck, PresentCheck, TxtCheck, BrokenPhotosCheck, AllCheck };
                foreach (CheckBox r in ailR)
                {
                    r.Checked = false;
                }
                panel_ButtonExceptMy.Enabled = false;
                MyBox.Enabled = true;
                AllCheck.Enabled = false;
            }
            else
            {
                panel_ButtonExceptMy.Enabled = true;
                MyBox.Enabled = false;
                MyBox.Text = null;
                AllCheck.Enabled = true;
            }
        }
        private void BrokerPhotosCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (BrokenPhotosCheck.Checked)
            {
                PhotosCheck.Checked = false;
                PhotosCheck.Enabled = false;
                MyCheck.Checked = false;
                MyBox.Enabled = false;
                MyBox.Text = null;
            }
            else
            {
                PhotosCheck.Enabled = true;
                MyBox.Enabled = true;
            }
        }

        private void AllCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox[] ailR = { PhotosCheck, DocCheck, AudioCheck, ZipFilesCheck, HtmlCheck, PdfCheck, 
                TableCheck, VideoCheck, TorrentCheck, PsdCheck, PresentCheck, TxtCheck };
            if (AllCheck.Checked == true)
            {
                foreach (CheckBox r in ailR)
                {
                    r.Checked = true;
                }
            }
            else
            {
                foreach (CheckBox r in ailR)
                {
                    r.Checked = false;
                }
            }
        }

        private void advanced_settings_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            OutDataListBox.Visible = false;
            heading.Visible = false;
            panel_setting.Visible = true;
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            OutDataListBox.Visible = true;
            heading.Visible = true;
            panel_setting.Visible = false;
        }

        private void panel_setting_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}