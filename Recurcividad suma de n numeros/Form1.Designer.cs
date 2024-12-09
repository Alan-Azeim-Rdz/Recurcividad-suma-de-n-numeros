namespace Recurcividad_suma_de_n_numeros
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
            label1 = new Label();
            BtnAdd = new Button();
            TextNum = new TextBox();
            ListViewDataRecurcive = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 45);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 0;
            label1.Text = "Introdusca un numero";
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(117, 108);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(75, 23);
            BtnAdd.TabIndex = 1;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // TextNum
            // 
            TextNum.Location = new Point(65, 79);
            TextNum.Name = "TextNum";
            TextNum.Size = new Size(176, 23);
            TextNum.TabIndex = 2;
            // 
            // ListViewDataRecurcive
            // 
            ListViewDataRecurcive.Location = new Point(279, 12);
            ListViewDataRecurcive.Name = "ListViewDataRecurcive";
            ListViewDataRecurcive.Size = new Size(124, 304);
            ListViewDataRecurcive.TabIndex = 3;
            ListViewDataRecurcive.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 353);
            Controls.Add(ListViewDataRecurcive);
            Controls.Add(TextNum);
            Controls.Add(BtnAdd);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnAdd;
        private TextBox TextNum;
        private ListView ListViewDataRecurcive;
    }
}
