using System.Diagnostics;
using System.Text;

namespace ProcessManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetProcessesInfo();

            comboBox1.DataSource = new ComboItem[]
            {
                new ComboItem { ID = 1, Text = "Lowest", Value = ThreadPriorityLevel.Lowest},
                new ComboItem { ID = 2, Text = "Normal", Value = ThreadPriorityLevel.Normal},
                new ComboItem { ID = 3, Text = "Idle", Value = ThreadPriorityLevel.Idle},
                new ComboItem { ID = 4, Text = "Highest", Value = ThreadPriorityLevel.Highest}
            };
        }
        public void GetProcessesInfo()
        {
            dataGridView1.ColumnCount = 4;

            dataGridView1.Columns[0].Name = "ProcessName";
            dataGridView1.Columns[1].Name = "MemoryTaken";
            dataGridView1.Columns[2].Name = "ThreadsCount";
            dataGridView1.Columns[3].Name = "ThreadPriority";

            var rows = ProcessUtilities.GetProcessesInfo();

            foreach (var item in rows)
            {
                dataGridView1.Rows.Add(item);
            }
        }

        private void runChromeButton_Click(object sender, EventArgs e)
        {
            ProcessUtilities.StartProcessByPathName(@"C:\Program Files\Google\Chrome\Application\chrome.exe");
        }

        private void runVSCodeButton_Click(object sender, EventArgs e)
        {
            ProcessUtilities.StartProcessByPathName(@"C:\Program Files\Microsoft VS Code\Code.exe");
        }

        private void stopProcessButton_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
                 dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {

                var processName = (string)dataGridView1.SelectedRows[0].Cells[0].Value;

                ProcessUtilities.StopProcessByName(processName);
            }
        }

        private void setPriorityOfChoosenThreadButton_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
                dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

           if (selectedRowCount > 0)
           {
                ComboItem value = (ComboItem)comboBox1.SelectedItem;

                var processName = (string)dataGridView1.SelectedRows[0].Cells[0].Value;

                var chosenProcess = Process.GetProcessesByName(processName);

                foreach (var process in chosenProcess)
                {
                    foreach (ProcessThread thread in process.Threads)
                    {
                        thread.PriorityLevel = value.Value;
                    }
                }

                GetProcessesInfo();
            }
        }

        private void runCalcButton_Click(object sender, EventArgs e)
        {
            ProcessUtilities.StartProcessByPathName("Calc.exe");
        }

        private void runMSWordButton_Click(object sender, EventArgs e)
        {
            ProcessUtilities.StartProcessByPathName("Winword.exe");
        }
    }
    class ComboItem
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public ThreadPriorityLevel Value { get; set; }
    }
}