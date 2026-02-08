namespace PhotoDemo
{
    partial class PlacesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlacesForm));
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            textBoxTitle = new TextBox();
            buttonOpen = new Button();
            buttonSave = new Button();
            labelPath = new Label();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(193, 319);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(228, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 281);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(228, 308);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(100, 23);
            textBoxTitle.TabIndex = 2;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(334, 308);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(75, 23);
            buttonOpen.TabIndex = 3;
            buttonOpen.Text = "Open Image";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(415, 308);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelPath
            // 
            labelPath.AutoSize = true;
            labelPath.Location = new Point(228, 343);
            labelPath.Name = "labelPath";
            labelPath.Size = new Size(38, 15);
            labelPath.TabIndex = 5;
            labelPath.Text = "label1";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(620, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(185, 175);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(678, 208);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Next >";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "giphy.gif");
            imageList1.Images.SetKeyName(1, "toa-heftiba-6bKpHAun4d8-unsplash.jpg");
            // 
            // PlacesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 370);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(labelPath);
            Controls.Add(buttonSave);
            Controls.Add(buttonOpen);
            Controls.Add(textBoxTitle);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Name = "PlacesForm";
            Text = "Form1";
            Load += PlacesForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private PictureBox pictureBox1;
        private TextBox textBoxTitle;
        private Button buttonOpen;
        private Button buttonSave;
        private Label labelPath;
        private PictureBox pictureBox2;
        private Button button1;
        private ImageList imageList1;
    }
}
