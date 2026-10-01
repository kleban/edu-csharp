namespace Biz.WinApp
{
    partial class FormApp
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
            buttonOpenDataForParsing = new Button();
            listBoxBizData = new ListBox();
            buttonSaveToCSV = new Button();
            buttonClean = new Button();
            buttonFromCSV = new Button();
            buttonJSON = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // buttonOpenDataForParsing
            // 
            buttonOpenDataForParsing.Location = new Point(24, 24);
            buttonOpenDataForParsing.Name = "buttonOpenDataForParsing";
            buttonOpenDataForParsing.Size = new Size(184, 29);
            buttonOpenDataForParsing.TabIndex = 0;
            buttonOpenDataForParsing.Text = "Parse Data";
            buttonOpenDataForParsing.UseVisualStyleBackColor = true;
            buttonOpenDataForParsing.Click += buttonOpenDataForParsing_Click;
            // 
            // listBoxBizData
            // 
            listBoxBizData.FormattingEnabled = true;
            listBoxBizData.Location = new Point(24, 69);
            listBoxBizData.Name = "listBoxBizData";
            listBoxBizData.Size = new Size(184, 364);
            listBoxBizData.TabIndex = 1;
            // 
            // buttonSaveToCSV
            // 
            buttonSaveToCSV.Location = new Point(225, 69);
            buttonSaveToCSV.Name = "buttonSaveToCSV";
            buttonSaveToCSV.Size = new Size(105, 29);
            buttonSaveToCSV.TabIndex = 2;
            buttonSaveToCSV.Text = "To CSV";
            buttonSaveToCSV.UseVisualStyleBackColor = true;
            buttonSaveToCSV.Click += buttonSaveToCSV_Click;
            // 
            // buttonClean
            // 
            buttonClean.Location = new Point(225, 104);
            buttonClean.Name = "buttonClean";
            buttonClean.Size = new Size(105, 29);
            buttonClean.TabIndex = 3;
            buttonClean.Text = "Clean";
            buttonClean.UseVisualStyleBackColor = true;
            buttonClean.Click += buttonClean_Click;
            // 
            // buttonFromCSV
            // 
            buttonFromCSV.Location = new Point(225, 139);
            buttonFromCSV.Name = "buttonFromCSV";
            buttonFromCSV.Size = new Size(105, 29);
            buttonFromCSV.TabIndex = 4;
            buttonFromCSV.Text = "From CSV";
            buttonFromCSV.UseVisualStyleBackColor = true;
            buttonFromCSV.Click += buttonFromCSV_Click;
            // 
            // buttonJSON
            // 
            buttonJSON.Location = new Point(336, 69);
            buttonJSON.Name = "buttonJSON";
            buttonJSON.Size = new Size(105, 29);
            buttonJSON.TabIndex = 5;
            buttonJSON.Text = "To JSON";
            buttonJSON.UseVisualStyleBackColor = true;
            buttonJSON.Click += buttonJSON_Click;
            // 
            // button2
            // 
            button2.Location = new Point(336, 139);
            button2.Name = "button2";
            button2.Size = new Size(105, 29);
            button2.TabIndex = 6;
            button2.Text = "From CSV";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(buttonJSON);
            Controls.Add(buttonFromCSV);
            Controls.Add(buttonClean);
            Controls.Add(buttonSaveToCSV);
            Controls.Add(listBoxBizData);
            Controls.Add(buttonOpenDataForParsing);
            Name = "FormApp";
            Text = "Biz Data";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpenDataForParsing;
        private ListBox listBoxBizData;
        private Button buttonSaveToCSV;
        private Button buttonClean;
        private Button buttonFromCSV;
        private Button buttonJSON;
        private Button button2;
    }
}
