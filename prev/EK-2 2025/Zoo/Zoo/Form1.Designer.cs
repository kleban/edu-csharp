namespace Zoo
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
            listBoxAnimals = new ListBox();
            buttonAddAnimal = new Button();
            listBoxAviaries = new ListBox();
            buttonAddAviary = new Button();
            button1 = new Button();
            listBoxThisAviaryAnimals = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // listBoxAnimals
            // 
            listBoxAnimals.FormattingEnabled = true;
            listBoxAnimals.Location = new Point(24, 28);
            listBoxAnimals.Name = "listBoxAnimals";
            listBoxAnimals.Size = new Size(163, 289);
            listBoxAnimals.TabIndex = 0;
            // 
            // buttonAddAnimal
            // 
            buttonAddAnimal.Location = new Point(193, 28);
            buttonAddAnimal.Name = "buttonAddAnimal";
            buttonAddAnimal.Size = new Size(133, 23);
            buttonAddAnimal.TabIndex = 1;
            buttonAddAnimal.Text = "Add Animal";
            buttonAddAnimal.UseVisualStyleBackColor = true;
            buttonAddAnimal.Click += buttonAddAnimal_Click;
            // 
            // listBoxAviaries
            // 
            listBoxAviaries.FormattingEnabled = true;
            listBoxAviaries.Location = new Point(332, 28);
            listBoxAviaries.Name = "listBoxAviaries";
            listBoxAviaries.Size = new Size(163, 289);
            listBoxAviaries.TabIndex = 2;
            // 
            // buttonAddAviary
            // 
            buttonAddAviary.Location = new Point(501, 28);
            buttonAddAviary.Name = "buttonAddAviary";
            buttonAddAviary.Size = new Size(103, 23);
            buttonAddAviary.TabIndex = 3;
            buttonAddAviary.Text = "Add Aviary";
            buttonAddAviary.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(223, 148);
            button1.Name = "button1";
            button1.Size = new Size(70, 23);
            button1.TabIndex = 4;
            button1.Text = ">>";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBoxThisAviaryAnimals
            // 
            listBoxThisAviaryAnimals.FormattingEnabled = true;
            listBoxThisAviaryAnimals.Location = new Point(501, 57);
            listBoxThisAviaryAnimals.Name = "listBoxThisAviaryAnimals";
            listBoxThisAviaryAnimals.Size = new Size(186, 139);
            listBoxThisAviaryAnimals.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(501, 202);
            button2.Name = "button2";
            button2.Size = new Size(186, 23);
            button2.TabIndex = 6;
            button2.Text = "Remove from Aviary";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 343);
            Controls.Add(button2);
            Controls.Add(listBoxThisAviaryAnimals);
            Controls.Add(button1);
            Controls.Add(buttonAddAviary);
            Controls.Add(listBoxAviaries);
            Controls.Add(buttonAddAnimal);
            Controls.Add(listBoxAnimals);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxAnimals;
        private Button buttonAddAnimal;
        private ListBox listBoxAviaries;
        private Button buttonAddAviary;
        private Button button1;
        private ListBox listBoxThisAviaryAnimals;
        private Button button2;
    }
}
