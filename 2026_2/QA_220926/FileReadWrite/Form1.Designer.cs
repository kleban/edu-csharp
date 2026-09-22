namespace FileReadWrite
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
            buttonOpenCsv = new Button();
            listBoxViewData = new ListBox();
            buttonSaveJson = new Button();
            buttonOpenJSON = new Button();
            SuspendLayout();
            // 
            // buttonOpenCsv
            // 
            buttonOpenCsv.Location = new Point(28, 23);
            buttonOpenCsv.Name = "buttonOpenCsv";
            buttonOpenCsv.Size = new Size(117, 38);
            buttonOpenCsv.TabIndex = 0;
            buttonOpenCsv.Text = "OpenCSV";
            buttonOpenCsv.UseVisualStyleBackColor = true;
            buttonOpenCsv.Click += buttonOpenCsv_Click;
            // 
            // listBoxViewData
            // 
            listBoxViewData.FormattingEnabled = true;
            listBoxViewData.Location = new Point(28, 92);
            listBoxViewData.Name = "listBoxViewData";
            listBoxViewData.Size = new Size(165, 304);
            listBoxViewData.TabIndex = 1;
            // 
            // buttonSaveJson
            // 
            buttonSaveJson.Location = new Point(214, 23);
            buttonSaveJson.Name = "buttonSaveJson";
            buttonSaveJson.Size = new Size(117, 38);
            buttonSaveJson.TabIndex = 2;
            buttonSaveJson.Text = "Save JSON";
            buttonSaveJson.UseVisualStyleBackColor = true;
            buttonSaveJson.Click += buttonSaveJson_Click;
            // 
            // buttonOpenJSON
            // 
            buttonOpenJSON.Location = new Point(342, 206);
            buttonOpenJSON.Name = "buttonOpenJSON";
            buttonOpenJSON.Size = new Size(117, 38);
            buttonOpenJSON.TabIndex = 3;
            buttonOpenJSON.Text = "OpenJSON";
            buttonOpenJSON.UseVisualStyleBackColor = true;
            buttonOpenJSON.Click += buttonOpenJSON_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOpenJSON);
            Controls.Add(buttonSaveJson);
            Controls.Add(listBoxViewData);
            Controls.Add(buttonOpenCsv);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpenCsv;
        private ListBox listBoxViewData;
        private Button buttonSaveJson;
        private Button buttonOpenJSON;
    }
}
