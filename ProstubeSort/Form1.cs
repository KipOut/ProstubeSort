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

        #region ����� ����� ��� ����������
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
                    WarningC();
                }
            }
        }
        private void button_result_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                wayBox_result.Text = folderBrowserDialog1.SelectedPath;
                if (wayBox_result.Text.StartsWith("C"))
                {
                    WarningC();
                }
            }
        }
        #endregion

        #region ������������
        private void button_scan_Click(object sender, EventArgs e)
        {
            OutDataListBox.Items.Clear();
            if (wayBox.Text.Length != 0)
            {
                #region ����������
                if (PhotosCheck.Checked)
                {
                    
                    string[] photos = { "*.png", "*.jpeg", "*.jpg", "*.bmp", "*.gif", "*.tif" };
                    foreach (string expansionPhotos in photos)
                    {
                        OutDataListBox.Items.Add("����������:");
                        foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", expansionPhotos, SearchOption.AllDirectories))
                        {
                            OutDataListBox.Items.Add(file);
                        }
                    }
                }
                #endregion

                #region ���������
                if (DocCheck.Checked)
                {
                    OutDataListBox.Items.Add("���������:");
                    string[] doc = { "*.doc", "*.docx", "*.odt" };
                    foreach (string expansionDoc in doc)
                    {
                        foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", expansionDoc, SearchOption.AllDirectories))
                        {
                            OutDataListBox.Items.Add(file);
                        }
                    }
                }
                #endregion

                #region ����������� �������
                if (TableCheck.Checked)
                {
                    OutDataListBox.Items.Add("����������� �������:");
                    string[] table = { "*.xlsx", "*.xls" };
                    foreach (string expansionTable in table)
                    {
                        foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", expansionTable, SearchOption.AllDirectories))
                        {
                            OutDataListBox.Items.Add(file);
                        }
                    }
                }
                #endregion

                #region Pdf ���������
                if (PdfCheck.Checked)
                {
                    OutDataListBox.Items.Add("Pdf ���������:");
                    foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", "*.pdf", SearchOption.AllDirectories))
                    {
                        OutDataListBox.Items.Add(file);
                    }
                }
                #endregion

                #region �����������
                if (PresentCheck.Checked)
                {
                    OutDataListBox.Items.Add("�����������:");
                    string[] present = { "*.ppt", "*.pptx", "*.odp" };
                    foreach (string expansionPresent in present)
                    {
                        foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", expansionPresent, SearchOption.AllDirectories))
                        {
                            OutDataListBox.Items.Add(file);
                        }
                    }
                }
                #endregion

                #region �����
                if (AudioCheck.Checked)
                {
                    OutDataListBox.Items.Add("�����:");
                    string[] BrokerAudio = { "*.mp3", "*.wav", "*.midi", "*.aac" };
                    foreach (string expansionMusic in BrokerAudio)
                    {
                        foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", expansionMusic, SearchOption.AllDirectories))
                        {
                            OutDataListBox.Items.Add(file);
                        }
                    }
                }
                #endregion

                #region TXT
                if (TxtCheck.Checked)
                {
                    OutDataListBox.Items.Add("Txt:");
                    foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", "*.txt", SearchOption.AllDirectories))
                    {
                        OutDataListBox.Items.Add(file);
                    }
                }
                #endregion

                #region �����
                if (VideoCheck.Checked)
                {
                    OutDataListBox.Items.Add("�����:");
                    string[] video = { "*.mp4", "*.avi", "*.mkv", "*.wmv", "*.mkv", "*.flv", "mpeg" };
                    foreach (string expansionVideo in video)
                    {
                        foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", expansionVideo, SearchOption.AllDirectories))
                        {
                            OutDataListBox.Items.Add(file);
                        }
                    }
                }
                #endregion

                #region ������
                if (ZipFilesCheck.Checked)
                {
                    OutDataListBox.Items.Add("������:");
                    string[] zipFiles = { "*.zip", "*.rar", "*.7z", "*.gzip" };
                    foreach (string expansionZipFiles in zipFiles)
                    {
                        foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", expansionZipFiles, SearchOption.AllDirectories))
                        {
                            OutDataListBox.Items.Add(file);
                        }
                    }
                }
                #endregion

                #region ����� ����������
                if (BrokerPhotosCheck.Checked)
                {
                    OutDataListBox.Items.Add("����� ����������:");
                    string[] BrokerPhotos = { "*.png", "*.jpeg", "*.jpg", "*.bmp", "*.gif", "*.tif" };
                    foreach (string typePhoto in BrokerPhotos)
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

                #region ���� ����������
                if (MyCheck.Checked)
                {
                    OutDataListBox.Items.Add($"{MyBox.Text}:");
                    foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", $"*.{MyBox.Text}", SearchOption.AllDirectories))
                    {
                        OutDataListBox.Items.Add(file);
                    }
                }
                #endregion

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

        #region ����������
        private void button_sort_Click(object sender, EventArgs e)
        {
            OutDataListBox.Items.Clear();
            if (wayBox.Text.Length != 0 && wayBox_result.Text.Length != 0)
            {
                #region ����������
                if (PhotosCheck.Checked)
                {
                    Directory.CreateDirectory($@"{wayBox_result.Text}\Photos");
                    OutDataListBox.Items.Add("����������:");
                    string[] photos = { "*.png", "*.jpeg", "*.jpg", "*.bmp", "*.gif", "*.tif" };
                    foreach (string expansionPhotos in photos)
                    {
                        foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", expansionPhotos, SearchOption.AllDirectories))
                        {
                            try
                            {
                                string result = Path.GetFileName(file);
                                File.Move(file, $@"{wayBox_result.Text}\Photos\{result}");
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
                #endregion

                #region ���������
                if (DocCheck.Checked)
                {
                    OutDataListBox.Items.Add("���������:");
                    Directory.CreateDirectory($@"{wayBox_result.Text}\Documents");
                    string[] doc = { "*.doc", "*.docx", "*.odt" };
                    foreach (string expansionDoc in doc)
                    {
                        foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", expansionDoc, SearchOption.AllDirectories))
                        {
                            try
                            {
                                string result = Path.GetFileName(file);
                                File.Move(file, $@"{wayBox_result.Text}\Documents\{result}");
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
                #endregion

                #region ����������� �������
                if (TableCheck.Checked)
                {
                    OutDataListBox.Items.Add("����������� �������:");
                    Directory.CreateDirectory($@"{wayBox_result.Text}\Spreadsheets");
                    string[] table = { "*.xlsx", "*.xls" };
                    foreach (string expansionTable in table)
                    {
                        foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", expansionTable, SearchOption.AllDirectories))
                        {
                            try
                            {
                                string result = Path.GetFileName(file);
                                File.Move(file, $@"{wayBox_result.Text}\Spreadsheets\{result}");
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
                #endregion

                #region Pdf ���������
                if (PdfCheck.Checked)
                {
                    OutDataListBox.Items.Add("Pdf ���������:");
                    Directory.CreateDirectory($@"{wayBox_result.Text}\Pdf-Document");
                    foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", "*.pdf", SearchOption.AllDirectories))
                    {
                        try
                        {
                            string result = Path.GetFileName(file);
                            File.Move(file, $@"{wayBox_result.Text}\Pdf-Document\{result}");
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
                #endregion

                #region �����������
                if (PresentCheck.Checked)
                {
                    Directory.CreateDirectory($@"{wayBox_result.Text}\Presentations");
                    OutDataListBox.Items.Add("�����������:");
                    string[] present = { "*.ppt", "*.pptx", "*.odp" };
                    foreach (string expansionPresent in present)
                    {
                        foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", expansionPresent, SearchOption.AllDirectories))
                        {
                            try
                            {
                                string result = Path.GetFileName(file);
                                File.Move(file, $@"{wayBox_result.Text}\Presentations\{result}");
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
                #endregion

                #region �����
                if (AudioCheck.Checked)
                {
                    Directory.CreateDirectory($@"{wayBox_result.Text}\Audio");
                    OutDataListBox.Items.Add("�����:");
                    string[] audio = { "*.mp3", "*.wav", "*.midi", "*.aac" };
                    foreach (string expansionAudio in audio)
                    {
                        foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", expansionAudio, SearchOption.AllDirectories))
                        {
                            try
                            {
                                string result = Path.GetFileName(file);
                                File.Move(file, $@"{wayBox_result.Text}\Audio\{result}");
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
                #endregion

                #region TXT
                if (TxtCheck.Checked)
                {
                    Directory.CreateDirectory($@"{wayBox_result.Text}\Txt");
                    OutDataListBox.Items.Add("Txt:");
                    foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", "*.txt", SearchOption.AllDirectories))
                    {
                        try
                        {
                            string result = Path.GetFileName(file);
                            File.Move(file, $@"{wayBox_result.Text}\Txt\{result}");
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
                #endregion

                #region �����
                if (VideoCheck.Checked)
                {
                    Directory.CreateDirectory($@"{wayBox_result.Text}\Video");
                    OutDataListBox.Items.Add("�����:");
                    string[] video = { "*.mp4", "*.avi", "*.mkv", "*.wmv", "*.mkv", "*.flv", "mpeg" };
                    foreach (string expansionVideo in video)
                    {
                        foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", expansionVideo, SearchOption.AllDirectories))
                        {
                            try
                            {
                                string result = Path.GetFileName(file);
                                File.Move(file, $@"{wayBox_result.Text}\Video\{result}");
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
                #endregion

                #region ������
                if (ZipFilesCheck.Checked)
                {
                    Directory.CreateDirectory($@"{wayBox_result.Text}\Archives");
                    OutDataListBox.Items.Add("������:");
                    string[] zipFiles = { "*.zip", "*.rar", "*.7z", "*.gzip" };
                    foreach (string expansionZipFiles in zipFiles)
                    {
                        foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", expansionZipFiles, SearchOption.AllDirectories))
                        {
                            try
                            {
                                string result = Path.GetFileName(file);
                                File.Move(file, $@"{wayBox_result.Text}\Archives\{result}");
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
                #endregion

                #region ����� ����������
                if (BrokerPhotosCheck.Checked)
                {
                    OutDataListBox.Items.Add("����� ����������:");
                    Directory.CreateDirectory($@"{wayBox_result.Text}\Broken photos");
                    string[] BrokerPhotos = { "*.png", "*.jpeg", "*.jpg", "*.bmp", "*.gif", "*.tif" };
                    foreach (string typePhoto in BrokerPhotos)
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
                                try
                                {
                                    string result = Path.GetFileName(file);
                                    File.Move(file, $@"{wayBox_result.Text}\Broken photos\{result}");
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

                #region ������� (psd)
                if (PsdCheck.Checked)
                {
                    OutDataListBox.Items.Add("������� (psd):");
                    Directory.CreateDirectory($@"{wayBox_result.Text}\Psd");
                    foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", "*.psd", SearchOption.AllDirectories))
                    {
                        try
                        {
                            string result = Path.GetFileName(file);
                            File.Move(file, $@"{wayBox_result.Text}\Psd\{result}");
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
                #endregion

                #region �������� �� ���������
                if (HtmlCheck.Checked)
                {
                    OutDataListBox.Items.Add("�������� �� ���������:");
                    Directory.CreateDirectory($@"{wayBox_result.Text}\Html");
                    string[] html = { "*.html", "*.htm", "*.mht" };
                    foreach (string expansionHtml in html)
                    {
                        foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", expansionHtml, SearchOption.AllDirectories))
                        {
                            try
                            {
                                string result = Path.GetFileName(file);
                                File.Move(file, $@"{wayBox_result.Text}\Html\{result}");
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
                #endregion

                #region ������� �����
                if (TorrentCheck.Checked)
                {
                    OutDataListBox.Items.Add("������� �����:");
                    Directory.CreateDirectory($@"{wayBox_result.Text}\TorrentFiles");
                    foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", "*.torrent", SearchOption.AllDirectories))
                    {
                        try
                        {
                            string result = Path.GetFileName(file);
                            File.Move(file, $@"{wayBox_result.Text}\TorrentFiles\{result}");
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
                #endregion

                #region ���� ����������
                if (MyCheck.Checked)
                {
                    OutDataListBox.Items.Add($"{MyBox}:");
                    Directory.CreateDirectory($@"{wayBox_result.Text}\{MyBox.Text}");
                    foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", $"*.{MyBox.Text}", SearchOption.AllDirectories))
                    {
                        try
                        {
                            string result = Path.GetFileName(file);
                            File.Move(file, $@"{wayBox_result.Text}\{MyBox.Text}\{result}");
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
                #endregion

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
                panel_ButtonExceptMy.Enabled = false;
                PhotosCheck.Checked = false;
                DocCheck.Checked = false;
                AudioCheck.Checked = false;
                TxtCheck.Checked = false;
                VideoCheck.Checked = false;
                ZipFilesCheck.Checked = false;
                BrokerPhotosCheck.Checked = false;
                MyBox.Enabled = true;
            }
            else
            {
                panel_ButtonExceptMy.Enabled = true;
                MyBox.Enabled = false;
                MyBox.Text = null;
            }
        }

        private void checkActBroker_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void wayBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BrokerPhotosCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (BrokerPhotosCheck.Checked)
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
    }
}