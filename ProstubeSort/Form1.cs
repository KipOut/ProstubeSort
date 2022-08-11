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
                button_scan.Enabled = true;
                button_sort.Enabled = true;
            }
        }
        private void button_result_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                wayBox_result.Text = folderBrowserDialog1.SelectedPath;
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

                #region Музыка
                if (MusicCheck.Checked)
                {
                    string[] music = { "*.mp3", "*.wav", "*.midi", "*.aac" };
                    foreach (string expansionMusic in music)
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
                if (PhotosCheck.Checked)
                {
                    string[] photos = { "*.png", "*.jpeg", "*.jpg", "*.bmp", "*.gif", "*.tif" };
                    //foreach (string file in Directory.EnumerateFiles($"{folderBrowserDialog1.SelectedPath}", SearchOption.AllDirectories))
                    {
                        try
                        {
                            //using (Bitmap jpg = new Bitmap(file))
                            {

                            }
                        }
                        catch (ArgumentException)
                        {
                            //OutDataListBox.Items.Add(file);
                        }
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

    }
}