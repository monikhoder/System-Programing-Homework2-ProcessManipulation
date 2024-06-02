using System.Diagnostics;

namespace ProcessManipulations
{
    public partial class Form1 : Form
    {
        List<Process> processList = [];
        public Form1()
        {
            InitializeComponent();
            loadAssemblies();
        }
        void loadAssemblies()
        {
            available_assemblies.Items.Clear();
            var exclude = Application.ExecutablePath.Split('/', '\\').Last();
            foreach (var name in Directory.GetFiles(Application.StartupPath))
            {
                if (name.EndsWith(".exe") && !name.EndsWith(exclude))
                {
                    available_assemblies.Items.Add(name.Split('/', '\\').Last());
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            if (available_assemblies.SelectedItem != null)
            {
                var name = available_assemblies.SelectedItem.ToString();
                var proc = Process.Start($"{name}");
                processList.Add(proc);
                available_assemblies.Items.RemoveAt(available_assemblies.SelectedIndex);
                started_assemblies.Items.Add($"{name}");
                proc.EnableRaisingEvents = true;
                proc.Exited += Proc_exit;
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (started_assemblies.SelectedItem != null)
            {
                var name = started_assemblies.SelectedItem.ToString();
                processList[started_assemblies.SelectedIndex].Kill();
            }
        }
        private void Proc_exit(object? sender, EventArgs e)
        {
            Process proc = sender as Process;
            int index = processList.IndexOf(proc);
            var name = started_assemblies.Items[index].ToString();
            started_assemblies.Invoke(() =>
            {
                started_assemblies.Items.RemoveAt(index);
                available_assemblies.Items.Add($"{name}");
            });
            processList.Remove(proc);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            if (started_assemblies.SelectedIndex != -1)
            {
                processList[started_assemblies.SelectedIndex].Refresh();
            }
        }

        private void run_calc_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }
    }
}
