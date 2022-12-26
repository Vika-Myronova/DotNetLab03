using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessManager
{
    public static class ProcessUtilities
    {
        public static void StartProcessByPathName(string pathName)
        {
            Process.Start(pathName);
        }

        public static void StopProcessByName(string name)
        {
            var chosenProcess = Process.GetProcessesByName(name);

            foreach (var process in chosenProcess)
            {
                process.Kill();
            }
        }

        public static string[][] GetProcessesInfo()
        {
            List<string[]> result = new();

            foreach (var process in Process.GetProcesses())
            {
                var name = process.ProcessName;
                var memoryTaken = process.PagedMemorySize64;
                var threadsCount = process.Threads.Count;

                StringBuilder sb = new StringBuilder();

                foreach (ProcessThread thread in process.Threads)
                {
                    sb.Append($" {thread.CurrentPriority}");
                }

                string[] row = new string[] { name, memoryTaken.ToString(), threadsCount.ToString(), sb.ToString() };

                result.Add(row);
            }

            return result.ToArray();
        }
    }
}
