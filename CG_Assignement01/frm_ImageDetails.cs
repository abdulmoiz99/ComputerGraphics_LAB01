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
    public partial class frm_ImageDetails : Form
    {
        public frm_ImageDetails()
        {
            InitializeComponent();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            LoadImageDetails();
        }

        private void LoadImageDetails()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            dialog.InitialDirectory = @"C:\";
            dialog.Title = "Select Image";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    groupBox1.Visible = true;
                    txt_ImagePath.Text = dialog.FileName;
                    Image img = Image.FromFile(dialog.FileName);
                    FileInfo fi = new FileInfo(dialog.FileName);
                    pb_Image.Image = img;
                    lab_Name.Text = "Name: " + dialog.FileName.Substring(dialog.FileName.LastIndexOf('\\') + 1);
                    lab_Type.Text = "Type: " + dialog.FileName.Substring(dialog.FileName.LastIndexOf('.') + 1);
                    lab_Path.Text = "Path: " + dialog.FileName.Substring(0, dialog.FileName.LastIndexOf('\\'));
                    lab_Width.Text = "Width: " + img.Width.ToString();
                    lab_Height.Text = "Height: " + img.Height.ToString();
                    Lab_Resolution.Text = "Resolution: " + img.Width + " x " + img.Height;
                    lab_PixelDensity.Text = "Pixel Density: " + img.HorizontalResolution + " dpi";
                    lab_PixelDepth.Text = "Pixel Depth" + Image.GetPixelFormatSize(img.PixelFormat).ToString();
                    lab_CreationDate.Text = "Creation Date: " + File.GetCreationTime(dialog.FileName).ToLongDateString();
                    lab_ModificationDate.Text = "Modification Date: " + File.GetLastWriteTime(dialog.FileName).ToLongDateString();
                    lab_ImageSize.Text = "Size" + ((fi.Length >= 1048576) ? (fi.Length / 1024f) / 1024f + " MB" : (fi.Length / 1024f) + " KB");
                }
                catch (Exception)
                {
                    // LoadNullValues();
                }

            }
        }
    }
}
