namespace CG_Assignement01
{
    partial class frm_ImageDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ImagePath = new System.Windows.Forms.TextBox();
            this.btn_Load = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab_Name = new System.Windows.Forms.Label();
            this.lab_Type = new System.Windows.Forms.Label();
            this.lab_Path = new System.Windows.Forms.Label();
            this.lab_Width = new System.Windows.Forms.Label();
            this.lab_Height = new System.Windows.Forms.Label();
            this.Lab_Resolution = new System.Windows.Forms.Label();
            this.lab_PixelDensity = new System.Windows.Forms.Label();
            this.lab_PixelDepth = new System.Windows.Forms.Label();
            this.lab_CreationDate = new System.Windows.Forms.Label();
            this.lab_ModificationDate = new System.Windows.Forms.Label();
            this.lab_ImageSize = new System.Windows.Forms.Label();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image:";
            // 
            // txt_ImagePath
            // 
            this.txt_ImagePath.Location = new System.Drawing.Point(79, 23);
            this.txt_ImagePath.Name = "txt_ImagePath";
            this.txt_ImagePath.Size = new System.Drawing.Size(550, 26);
            this.txt_ImagePath.TabIndex = 1;
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(647, 23);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(96, 26);
            this.btn_Load.TabIndex = 2;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab_ImageSize);
            this.groupBox1.Controls.Add(this.lab_ModificationDate);
            this.groupBox1.Controls.Add(this.lab_CreationDate);
            this.groupBox1.Controls.Add(this.lab_PixelDepth);
            this.groupBox1.Controls.Add(this.lab_PixelDensity);
            this.groupBox1.Controls.Add(this.Lab_Resolution);
            this.groupBox1.Controls.Add(this.lab_Height);
            this.groupBox1.Controls.Add(this.lab_Width);
            this.groupBox1.Controls.Add(this.lab_Path);
            this.groupBox1.Controls.Add(this.lab_Type);
            this.groupBox1.Controls.Add(this.lab_Name);
            this.groupBox1.Location = new System.Drawing.Point(16, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 367);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Properties";
            this.groupBox1.Visible = false;
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Location = new System.Drawing.Point(18, 35);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(53, 20);
            this.lab_Name.TabIndex = 4;
            this.lab_Name.Text = "label2";
            // 
            // lab_Type
            // 
            this.lab_Type.AutoSize = true;
            this.lab_Type.Location = new System.Drawing.Point(18, 62);
            this.lab_Type.Name = "lab_Type";
            this.lab_Type.Size = new System.Drawing.Size(53, 20);
            this.lab_Type.TabIndex = 5;
            this.lab_Type.Text = "label3";
            // 
            // lab_Path
            // 
            this.lab_Path.AutoSize = true;
            this.lab_Path.Location = new System.Drawing.Point(18, 89);
            this.lab_Path.Name = "lab_Path";
            this.lab_Path.Size = new System.Drawing.Size(53, 20);
            this.lab_Path.TabIndex = 5;
            this.lab_Path.Text = "label3";
            // 
            // lab_Width
            // 
            this.lab_Width.AutoSize = true;
            this.lab_Width.Location = new System.Drawing.Point(18, 116);
            this.lab_Width.Name = "lab_Width";
            this.lab_Width.Size = new System.Drawing.Size(53, 20);
            this.lab_Width.TabIndex = 5;
            this.lab_Width.Text = "label3";
            // 
            // lab_Height
            // 
            this.lab_Height.AutoSize = true;
            this.lab_Height.Location = new System.Drawing.Point(18, 143);
            this.lab_Height.Name = "lab_Height";
            this.lab_Height.Size = new System.Drawing.Size(53, 20);
            this.lab_Height.TabIndex = 5;
            this.lab_Height.Text = "label3";
            // 
            // Lab_Resolution
            // 
            this.Lab_Resolution.AutoSize = true;
            this.Lab_Resolution.Location = new System.Drawing.Point(18, 170);
            this.Lab_Resolution.Name = "Lab_Resolution";
            this.Lab_Resolution.Size = new System.Drawing.Size(53, 20);
            this.Lab_Resolution.TabIndex = 5;
            this.Lab_Resolution.Text = "label3";
            // 
            // lab_PixelDensity
            // 
            this.lab_PixelDensity.AutoSize = true;
            this.lab_PixelDensity.Location = new System.Drawing.Point(18, 197);
            this.lab_PixelDensity.Name = "lab_PixelDensity";
            this.lab_PixelDensity.Size = new System.Drawing.Size(53, 20);
            this.lab_PixelDensity.TabIndex = 5;
            this.lab_PixelDensity.Text = "label3";
            // 
            // lab_PixelDepth
            // 
            this.lab_PixelDepth.AutoSize = true;
            this.lab_PixelDepth.Location = new System.Drawing.Point(18, 224);
            this.lab_PixelDepth.Name = "lab_PixelDepth";
            this.lab_PixelDepth.Size = new System.Drawing.Size(53, 20);
            this.lab_PixelDepth.TabIndex = 5;
            this.lab_PixelDepth.Text = "label3";
            // 
            // lab_CreationDate
            // 
            this.lab_CreationDate.AutoSize = true;
            this.lab_CreationDate.Location = new System.Drawing.Point(18, 251);
            this.lab_CreationDate.Name = "lab_CreationDate";
            this.lab_CreationDate.Size = new System.Drawing.Size(53, 20);
            this.lab_CreationDate.TabIndex = 6;
            this.lab_CreationDate.Text = "label3";
            // 
            // lab_ModificationDate
            // 
            this.lab_ModificationDate.AutoSize = true;
            this.lab_ModificationDate.Location = new System.Drawing.Point(18, 278);
            this.lab_ModificationDate.Name = "lab_ModificationDate";
            this.lab_ModificationDate.Size = new System.Drawing.Size(53, 20);
            this.lab_ModificationDate.TabIndex = 6;
            this.lab_ModificationDate.Text = "label3";
            // 
            // lab_ImageSize
            // 
            this.lab_ImageSize.AutoSize = true;
            this.lab_ImageSize.Location = new System.Drawing.Point(18, 307);
            this.lab_ImageSize.Name = "lab_ImageSize";
            this.lab_ImageSize.Size = new System.Drawing.Size(53, 20);
            this.lab_ImageSize.TabIndex = 6;
            this.lab_ImageSize.Text = "label3";
            // 
            // pb_Image
            // 
            this.pb_Image.Location = new System.Drawing.Point(492, 60);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(251, 158);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Image.TabIndex = 4;
            this.pb_Image.TabStop = false;
            // 
            // frm_ImageDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 458);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.txt_ImagePath);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_ImageDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Properties";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ImagePath;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lab_ImageSize;
        private System.Windows.Forms.Label lab_ModificationDate;
        private System.Windows.Forms.Label lab_CreationDate;
        private System.Windows.Forms.Label lab_PixelDepth;
        private System.Windows.Forms.Label lab_PixelDensity;
        private System.Windows.Forms.Label Lab_Resolution;
        private System.Windows.Forms.Label lab_Height;
        private System.Windows.Forms.Label lab_Width;
        private System.Windows.Forms.Label lab_Path;
        private System.Windows.Forms.Label lab_Type;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.PictureBox pb_Image;
    }
}