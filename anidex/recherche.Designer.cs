namespace anidex
{
    partial class recherche
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
            listBox6 = new ListBox();
            listBox5 = new ListBox();
            listBox4 = new ListBox();
            listBox3 = new ListBox();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            lblTitre = new Label();
            SuspendLayout();
            // 
            // listBox6
            // 
            listBox6.FormattingEnabled = true;
            listBox6.ItemHeight = 15;
            listBox6.Location = new Point(484, 269);
            listBox6.Name = "listBox6";
            listBox6.Size = new Size(120, 34);
            listBox6.TabIndex = 20;
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 15;
            listBox5.Location = new Point(180, 269);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(120, 34);
            listBox5.TabIndex = 19;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(484, 196);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(120, 34);
            listBox4.TabIndex = 18;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(180, 196);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(120, 34);
            listBox3.TabIndex = 17;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(484, 130);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 34);
            listBox2.TabIndex = 16;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(180, 130);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 34);
            listBox1.TabIndex = 15;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Algerian", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitre.Location = new Point(96, 34);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(594, 54);
            lblTitre.TabIndex = 14;
            lblTitre.Text = "La recherche avancée";
            // 
            // recherche
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 862);
            Controls.Add(listBox6);
            Controls.Add(listBox5);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(lblTitre);
            Name = "recherche";
            Text = "recherche";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox6;
        private ListBox listBox5;
        private ListBox listBox4;
        private ListBox listBox3;
        private ListBox listBox2;
        private ListBox listBox1;
        private Label lblTitre;
    }
}