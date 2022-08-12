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
                    string[] doc = { "*.doc", "*.docx", "*.pptx", "*.odp", "*.xlsx", "*.pdf" };
                    foreach (string expansionDoc in doc)
                    {
                        foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", expansionDoc, SearchOption.AllDirectories))
                        {
                            OutDataListBox.Items.Add(file);
                        }
                    }
                }
                #endregion

                #region �����
                if (AudioCheck.Checked)
                {
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
                    foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", "*.txt", SearchOption.AllDirectories))
                    {
                        OutDataListBox.Items.Add(file);
                    }
                }
                #endregion

                #region �����
                if (VideoCheck.Checked)
                {
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
                if (ZipCheck.Checked)
                {
                    string[] zip = { "*.zip", "*.rar", "*.7z", "*.gzip" };
                    foreach (string expansionZip in zip)
                    {
                        foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", expansionZip, SearchOption.AllDirectories))
                        {
                            OutDataListBox.Items.Add(file);
                        }
                    }
                }
                #endregion

                #region ����� ����������
                if (BrokerPhotosCheck.Checked)
                {
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

                #region ����� �����
                if (BrokerVideoCheck.Checked)
                {
                    string[] BrokerVideo = { "*.mp4", "*.avi", "*.mkv", "*.wmv", "*.mkv", "*.flv", "mpeg" };
                    foreach (string typePhoto in BrokerVideo)
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

                #region ����� �����
                if (BrokerVideoCheck.Checked)
                {
                    string[] BrokerAudio = {  };
                    foreach (string typePhoto in BrokerAudio)
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
                    foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", $"*.{MyBox.Text}", SearchOption.AllDirectories))
                    {
                        OutDataListBox.Items.Add(file);
                    }
                }
                #endregion

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
                #endregion

                #region ������
                #endregion

                #region TXT
                #endregion

                #region �����
                #endregion

                #region ������
                #endregion

                #region ����� ����������
                #endregion

                #region ����� �����
                #endregion
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
                ZipCheck.Checked = false;
                BrokerAudioCheck.Checked = false;
                BrokerVideoCheck.Checked = false;
                BrokerPhotosCheck.Checked = false;
                MyBox.Enabled = true;
                checkActBroker.Checked = false;
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
            if (checkActBroker.Checked)
            {
                PhotosCheck.Checked = false;
                DocCheck.Checked = false;
                AudioCheck.Checked = false;
                TxtCheck.Checked = false;
                VideoCheck.Checked = false;
                ZipCheck.Checked = false;
                PhotosCheck.Enabled = false;
                DocCheck.Enabled = false;
                AudioCheck.Enabled = false;
                TxtCheck.Enabled = false;
                VideoCheck.Enabled = false;
                ZipCheck.Enabled = false;
                BrokerAudioCheck.Enabled = true;
                BrokerVideoCheck.Enabled = true;
                BrokerPhotosCheck.Enabled = true;
                MyCheck.Checked = false;
                MyBox.Enabled = false;
                MyBox.Text = null;
            }
            else
            {
                PhotosCheck.Enabled = true;
                DocCheck.Enabled = true;
                AudioCheck.Enabled = true;
                TxtCheck.Enabled = true;
                VideoCheck.Enabled = true;
                ZipCheck.Enabled = true;
                BrokerAudioCheck.Enabled = false;
                BrokerVideoCheck.Enabled = false;
                BrokerPhotosCheck.Enabled = false;
                BrokerAudioCheck.Checked = false;
                BrokerVideoCheck.Checked = false;
                BrokerPhotosCheck.Checked = false;
            }
        }

        private void wayBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BrokerPhotosCheck_CheckedChanged(object sender, EventArgs e)
        {
            File.Move($@"C:\Users\netbo\Desktop\Test\434.txt", $@"C:\Users\netbo\Desktop\Test\Photos\434.txt");
        }
    }
}