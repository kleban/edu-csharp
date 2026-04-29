namespace DataReadWright
{
    partial class Form1
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
            listBoxGroup = new ListBox();
            buttonOpen = new Button();
            buttonSave = new Button();
            buttonOpenCsv = new Button();
            buttonSaveCsv = new Button();
            buttonOpenJson = new Button();
            buttonSaveJson = new Button();
            buttonSaveXlsx = new Button();
            buttonOpenXlsx = new Button();
            SuspendLayout();
            // 
            // listBoxGroup
            // 
            listBoxGroup.FormattingEnabled = true;
            listBoxGroup.Location = new Point(22, 21);
            listBoxGroup.Name = "listBoxGroup";
            listBoxGroup.Size = new Size(273, 404);
            listBoxGroup.TabIndex = 0;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(318, 21);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(94, 29);
            buttonOpen.TabIndex = 1;
            buttonOpen.Text = "Open .txt";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(435, 21);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save .txt";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonOpenCsv
            // 
            buttonOpenCsv.Location = new Point(318, 71);
            buttonOpenCsv.Name = "buttonOpenCsv";
            buttonOpenCsv.Size = new Size(94, 29);
            buttonOpenCsv.TabIndex = 3;
            buttonOpenCsv.Text = "Open .csv";
            buttonOpenCsv.UseVisualStyleBackColor = true;
            buttonOpenCsv.Click += buttonOpenCsv_Click;
            // 
            // buttonSaveCsv
            // 
            buttonSaveCsv.Location = new Point(435, 71);
            buttonSaveCsv.Name = "buttonSaveCsv";
            buttonSaveCsv.Size = new Size(94, 29);
            buttonSaveCsv.TabIndex = 4;
            buttonSaveCsv.Text = "Save .csv";
            buttonSaveCsv.UseVisualStyleBackColor = true;
            buttonSaveCsv.Click += buttonSaveCsv_Click;
            // 
            // buttonOpenJson
            // 
            buttonOpenJson.Location = new Point(318, 122);
            buttonOpenJson.Name = "buttonOpenJson";
            buttonOpenJson.Size = new Size(94, 29);
            buttonOpenJson.TabIndex = 5;
            buttonOpenJson.Text = "Open .json";
            buttonOpenJson.UseVisualStyleBackColor = true;
            buttonOpenJson.Click += buttonOpenJson_Click;
            // 
            // buttonSaveJson
            // 
            buttonSaveJson.Location = new Point(435, 122);
            buttonSaveJson.Name = "buttonSaveJson";
            buttonSaveJson.Size = new Size(94, 29);
            buttonSaveJson.TabIndex = 6;
            buttonSaveJson.Text = "Save .json";
            buttonSaveJson.UseVisualStyleBackColor = true;
            buttonSaveJson.Click += buttonSaveJson_Click;
            // 
            // buttonSaveXlsx
            // 
            buttonSaveXlsx.Location = new Point(435, 174);
            buttonSaveXlsx.Name = "buttonSaveXlsx";
            buttonSaveXlsx.Size = new Size(94, 29);
            buttonSaveXlsx.TabIndex = 8;
            buttonSaveXlsx.Text = "Save .xlsx";
            buttonSaveXlsx.UseVisualStyleBackColor = true;
            buttonSaveXlsx.Click += buttonSaveXlsx_Click;
            // 
            // buttonOpenXlsx
            // 
            buttonOpenXlsx.Location = new Point(318, 174);
            buttonOpenXlsx.Name = "buttonOpenXlsx";
            buttonOpenXlsx.Size = new Size(94, 29);
            buttonOpenXlsx.TabIndex = 7;
            buttonOpenXlsx.Text = "Open .xlsx";
            buttonOpenXlsx.UseVisualStyleBackColor = true;
            buttonOpenXlsx.Click += buttonOpenXlsx_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSaveXlsx);
            Controls.Add(buttonOpenXlsx);
            Controls.Add(buttonSaveJson);
            Controls.Add(buttonOpenJson);
            Controls.Add(buttonSaveCsv);
            Controls.Add(buttonOpenCsv);
            Controls.Add(buttonSave);
            Controls.Add(buttonOpen);
            Controls.Add(listBoxGroup);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxGroup;
        private Button buttonOpen;
        private Button buttonSave;
        private Button buttonOpenCsv;
        private Button buttonSaveCsv;
        private Button buttonOpenJson;
        private Button buttonSaveJson;
        private Button buttonSaveXlsx;
        private Button buttonOpenXlsx;
    }
}
