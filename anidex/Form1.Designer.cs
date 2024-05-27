namespace anidex
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
            btnRecherche = new Button();
            btnAjouter = new Button();
            btnModifier = new Button();
            btnSuprimer = new Button();
            btnQuizz = new Button();
            SuspendLayout();
            // 
            // btnRecherche
            // 
            btnRecherche.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecherche.Location = new Point(59, 57);
            btnRecherche.Name = "btnRecherche";
            btnRecherche.Size = new Size(180, 80);
            btnRecherche.TabIndex = 2;
            btnRecherche.Text = "🔎  Recherche avancée";
            btnRecherche.UseVisualStyleBackColor = true;
            btnRecherche.Click += btnRecherche_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAjouter.Location = new Point(447, 635);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(180, 80);
            btnAjouter.TabIndex = 4;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            btnModifier.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModifier.Location = new Point(841, 635);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(180, 80);
            btnModifier.TabIndex = 5;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSuprimer
            // 
            btnSuprimer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSuprimer.Location = new Point(1227, 635);
            btnSuprimer.Name = "btnSuprimer";
            btnSuprimer.Size = new Size(180, 80);
            btnSuprimer.TabIndex = 6;
            btnSuprimer.Text = "Supprimer";
            btnSuprimer.UseVisualStyleBackColor = true;
            // 
            // btnQuizz
            // 
            btnQuizz.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuizz.Location = new Point(1528, 57);
            btnQuizz.Name = "btnQuizz";
            btnQuizz.Size = new Size(180, 80);
            btnQuizz.TabIndex = 7;
            btnQuizz.Text = "Mini Quizz";
            btnQuizz.UseVisualStyleBackColor = true;
            btnQuizz.Click += btnQuizz_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1728, 796);
            Controls.Add(btnQuizz);
            Controls.Add(btnSuprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(btnRecherche);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRecherche;
        private Button btnAjouter;
        private Button btnModifier;
        private Button btnSuprimer;
        private Button btnQuizz;
    }
}
