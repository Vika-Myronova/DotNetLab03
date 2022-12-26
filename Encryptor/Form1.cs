using System.Diagnostics;

namespace Encryptor
{
    public partial class Form1 : Form
    {
        public string FileContent { get; set; } = string.Empty;
        public string FileName { get; set; }
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            resultTextBox.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync("Encrypt");
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var timer = new Stopwatch();

            timer.Start();

            var result = FileEncryptor.Encrypt(FileContent, textBox1.Text, backgroundWorker1);

            timer.Stop();

            TimeSpan timeTaken = timer.Elapsed;

            string foo = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");

            timeTakenLabel.Text = foo;

            e.Result = result;
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            resultTextBox.Text = e.Result.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string sourcePath = openFileDialog1.FileName;

                FileContent = File.ReadAllText(sourcePath);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}