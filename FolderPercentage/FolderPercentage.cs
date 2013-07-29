using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FolderPercentage
{
    public partial class FolderPercentage : Form
    {
        private string folder;
        public FolderPercentage(string[] arg)
        {
            InitializeComponent();
            if (arg.Length > 0)
            {
                folder = arg[0];
            }
            else
            {
                if (TselectFolder.ShowDialog() == DialogResult.OK)
                {
                    folder = TselectFolder.SelectedPath;
                }
            }
        }

        private void FolderPercentage_Load(object sender, EventArgs e)
        {
            if (folder == null || !Directory.Exists(folder))
            {
                MessageBox.Show("Не указана папка");
                Application.Exit();
                return;
            }
            Text = "Размер папки: " + folder;
            TworkBack.RunWorkerAsync();
        }

        private void SetTextSafe(Label text, string newText)
        {
            if (text.InvokeRequired) text.Invoke(new Action<string>((s) => text.Text = s), newText);
                else text.Text = newText;
        }

        private void Work_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int i = 0;
            double sized = 0;
            double current = 0;
            string[] a = Directory.GetDirectories(folder);
            foreach (string name in a)
            {
                try
                {
                    var info = new DirectoryInfo(name);
                    SetTextSafe(Tanalyze, "Анализ папки: " + info.Name);
                    double size = info.EnumerateFiles("*", SearchOption.AllDirectories).Sum(fi => fi.Length)/1048576;
                    sized += Math.Round(size, 2);
                    if (size > 75)
                    {
                        Tchart.Invoke(new Action<double>((Add) => Tchart.Series[0].Points.Add(Add)), size);
                        Tchart.Invoke(new Action<string>((TextLabel) => Tchart.Series[0].Points[i].Label = TextLabel), size + " Мб");
                        Tchart.Invoke(new Action<string>((LegendLabel) => Tchart.Series[0].Points[i].LegendText = LegendLabel), info.Name + " - " + size + " Мб");
                        i++;
                    }
                    SetTextSafe(Folder, "Всего: " + Math.Round((sized/1024), 2) + " Гб");
                    current += 1;
                    double percent = (current / a.Length) * 100;
                    SetTextSafe(Done, Math.Round(percent, 1) + "%");
                }
                catch (Exception)
                {

                }
            }
            SetTextSafe(Done, "Готово");
            SetTextSafe(Tanalyze, "");
        }
    }
}
