namespace Minions
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
            idTextBox = new TextBox();
            nameTextBox = new TextBox();
            ageTextBox = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // idTextBox
            // 
            idTextBox.Font = new Font("Tahoma", 12F);
            idTextBox.Location = new Point(12, 64);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(100, 27);
            idTextBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Tahoma", 12F);
            nameTextBox.Location = new Point(146, 64);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 27);
            nameTextBox.TabIndex = 1;
            // 
            // ageTextBox
            // 
            ageTextBox.Font = new Font("Tahoma", 12F);
            ageTextBox.Location = new Point(12, 141);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(100, 27);
            ageTextBox.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Tahoma", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(146, 141);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 27);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F);
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(22, 19);
            label1.TabIndex = 4;
            label1.Text = "id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.Location = new Point(146, 41);
            label2.Name = "label2";
            label2.Size = new Size(48, 19);
            label2.TabIndex = 5;
            label2.Text = "name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(34, 19);
            label3.TabIndex = 6;
            label3.Text = "age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F);
            label4.Location = new Point(146, 116);
            label4.Name = "label4";
            label4.Size = new Size(44, 19);
            label4.TabIndex = 7;
            label4.Text = "town";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(62, 220);
            button1.Name = "button1";
            button1.Size = new Size(155, 70);
            button1.TabIndex = 8;
            button1.Text = "Add new minion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 302);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(ageTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(idTextBox);
            Name = "Form1";
            Text = "Minions";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idTextBox;
        private TextBox nameTextBox;
        private TextBox ageTextBox;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}
