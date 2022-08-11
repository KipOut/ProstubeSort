namespace ProstubeSort
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_review_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                wayBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            
        }
    }
}