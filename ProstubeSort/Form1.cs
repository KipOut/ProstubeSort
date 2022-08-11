namespace ProstubeSort
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        #region Выбор папки для сортировки
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
                    MessageBox.Show("Нельзя выбирать корневые папки!");
                    wayBox.Text = null;
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
                    MessageBox.Show("Нельзя выбирать корневые папки!");
                    wayBox_result.Text = null;
                }
            }
        }
        #endregion

        #region Сканирование
        private void button_scan_Click(object sender, EventArgs e)
        {
            OutDataListBox.Items.Clear();
            if (wayBox.Text.Length != 0)
            {
                #region Фотографии
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

                #region Документы
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

                #region Аудио
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

                #region Видео
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

                #region Архивы
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

                #region Битые фотографии
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

                #region Битые видео
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

                #region Битые аудио
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

                #region Свое расширение
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
                MessageBox.Show("Ошибка");
            }

        }
        #endregion

        #region Сортировка
        private void button_sort_Click(object sender, EventArgs e)
        {
            #region Фотографии
            #endregion

            #region Документы
            #endregion

            #region Музыка
            #endregion

            #region TXT
            #endregion

            #region Видео
            #endregion

            #region Архивы
            #endregion

            #region Битые фотографии
            #endregion
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
    }
}