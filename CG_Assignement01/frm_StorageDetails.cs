using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Assignement01
{
    public partial class frm_StorageDetails : Form
    {
        double imageSize, audioSize, videoSize, docSize;

        private void Form1_Load(object sender, EventArgs e)
        {
           // PlotGraph();
        }

        private void PlotGraph1()
        {
           // //cartesianChart1.Series = new SeriesCollection
           // {
           //     new ColumnSeries
           //     {
           //         Title = "Space",

           //         Values = new ChartValues<double> { imageSize, audioSize, videoSize, docSize }
           //     }
           // };

           // //adding series will update and animate the chart automatically
           // //cartesianChart1.Series.Add(new ColumnSeries
           // //{
           // //    Title = "2016",
           // //    Values = new ChartValues<double> { 11, 56, 42 }
           // //});

           // //also adding values updates and animates the chart automatically
           // //cartesianChart1.Series[1].Values.Add(48d);

           // //cartesianChart1.AxisX.Add(new Axis
           // {
           //     //  Title = "Foramt",
           //     FontSize = 12,

           //     Labels = new[] { "Images", "Audios", "Videos", "Documents" }
           // });

           //// cartesianChart1.AxisY.Add(new Axis
           // {
           //     Title = "Space",
           //     FontSize = 12,
           //     //LabelFormatter = value => value.ToString("N")
           // });
        }

        public frm_StorageDetails()
        {
            InitializeComponent();
            imageSize = audioSize = videoSize = docSize = 0;
        }
        private static double GetSize(List<string> extensions, string dir)
        {
            try
            {
                double totalSize = 0;
                string[] files = Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories).Where(f => extensions.IndexOf(Path.GetExtension(f)) >= 0).ToArray();

                foreach (string file in files)
                {
                    if (File.Exists(file))
                    {
                        totalSize += new FileInfo(file).Length;
                    }
                }
                return totalSize;
            }
            catch (UnauthorizedAccessException)
            {
                Application.Exit();
                return -1;
            }

        }
        public void plotGraph()
        {
            chart1.Series.Clear();
            chart1.Visible = true;
            var images = chart1.Series.Add("Images");
            var audios = chart1.Series.Add("Audios");
            var videos = chart1.Series.Add("Videos");
            var documents = chart1.Series.Add("Documents");
            images.Points.AddXY("Data", imageSize / 1024);
            audios.Points.AddXY("Data", audioSize / 1024);
            videos.Points.AddXY("Data", videoSize / 1024);
            documents.Points.AddXY("Data", docSize / 1024);

            chart1.ResetAutoValues();


        }
        private void btn_browse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Cursor.Current = Cursors.WaitCursor;
                    txt_Directory.Text = fbd.SelectedPath;
                    imageSize = GetSize(new List<string> { ".JPG", ".jpg", ".jpeg", ".png", ".gif" }, fbd.SelectedPath);
                    audioSize = GetSize(new List<string> { ".mp3", ".wav", ".aac", ".flac", ".ogg" }, fbd.SelectedPath);
                    videoSize = GetSize(new List<string> { ".mp4", ".mov", ".mkv", ".avi", ".flv" }, fbd.SelectedPath);
                    docSize = GetSize(new List<string> { ".html", ".htm", ".pdf", ".xls", ".xlsx", ".ppt", ".pptx", ".txt", ".doc", ".docx" }, fbd.SelectedPath);
                    Cursor.Current = Cursors.Default;
                    audioSize = 0;
                    imageSize = (imageSize <= 0) ? imageSize =0 : imageSize / imageSize / (1024 * 1024);
                    audioSize = (audioSize <= 0) ? audioSize = 0 : audioSize / audioSize / (1024 * 1024);
                    videoSize = (videoSize <= 0) ? videoSize = 0 : videoSize / videoSize / (1024 * 1024);
                    docSize = (docSize <= 0) ? docSize = 0 : docSize / docSize / (1024 * 1024);

                    plotGraph();




                }
            }
        }
    }
}
