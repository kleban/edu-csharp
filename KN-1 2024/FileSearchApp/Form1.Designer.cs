namespace FileSearchApp
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
            _treeView = new TreeView();
            buttonSearch = new Button();
            textBoxMask = new TextBox();
            listBoxFiles = new ListBox();
            SuspendLayout();
            // 
            // _treeView
            // 
            _treeView.Dock = DockStyle.Left;
            _treeView.Location = new Point(0, 0);
            _treeView.Name = "_treeView";
            _treeView.Size = new Size(332, 512);
            _treeView.TabIndex = 0;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(353, 64);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(124, 48);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxMask
            // 
            textBoxMask.Location = new Point(353, 21);
            textBoxMask.Name = "textBoxMask";
            textBoxMask.Size = new Size(240, 27);
            textBoxMask.TabIndex = 2;
            // 
            // listBoxFiles
            // 
            listBoxFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxFiles.FormattingEnabled = true;
            listBoxFiles.Location = new Point(353, 131);
            listBoxFiles.Name = "listBoxFiles";
            listBoxFiles.Size = new Size(490, 364);
            listBoxFiles.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 512);
            Controls.Add(listBoxFiles);
            Controls.Add(textBoxMask);
            Controls.Add(buttonSearch);
            Controls.Add(_treeView);
            Name = "Form1";
            Text = "H:\\Vartovy\\Vartovy.Authority.UI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView _treeView;
        private Button buttonSearch;
        private TextBox textBoxMask;
        private ListBox listBoxFiles;
    }
}
