namespace ReadWriteProductsDemo
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
            listBoxProducts = new ListBox();
            buttonOpen = new Button();
            buttonAdd = new Button();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // listBoxProducts
            // 
            listBoxProducts.Dock = DockStyle.Left;
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.Location = new Point(0, 0);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(305, 450);
            listBoxProducts.TabIndex = 0;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(325, 21);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(112, 34);
            buttonOpen.TabIndex = 1;
            buttonOpen.Text = "Open";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(325, 72);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(112, 34);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(325, 126);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 34);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(buttonAdd);
            Controls.Add(buttonOpen);
            Controls.Add(listBoxProducts);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxProducts;
        private Button buttonOpen;
        private Button buttonAdd;
        private Button buttonSave;
    }
}
