namespace anidex
{
    partial class miniQuizz
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
            btnValider = new Button();
            txtReponse = new TextBox();
            lblInfoRace = new Label();
            lblInfoActiviter = new Label();
            lblInfoNbYeux = new Label();
            lblInfoNbPattes = new Label();
            label3 = new Label();
            lblInfoAlimentation = new Label();
            lblRace = new Label();
            lblActiviter = new Label();
            lblNbYeux = new Label();
            lblNbPatte = new Label();
            lblAlimentation = new Label();
            btnIndice = new Button();
            btnQuitter = new Button();
            lblTitre = new Label();
            SuspendLayout();
            // 
            // btnValider
            // 
            btnValider.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnValider.Location = new Point(521, 655);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(180, 80);
            btnValider.TabIndex = 34;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = true;
            // 
            // txtReponse
            // 
            txtReponse.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtReponse.Location = new Point(108, 530);
            txtReponse.Name = "txtReponse";
            txtReponse.Size = new Size(500, 29);
            txtReponse.TabIndex = 20;
            txtReponse.TextAlign = HorizontalAlignment.Center;
            // 
            // lblInfoRace
            // 
            lblInfoRace.AutoSize = true;
            lblInfoRace.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfoRace.Location = new Point(370, 422);
            lblInfoRace.Name = "lblInfoRace";
            lblInfoRace.Size = new Size(176, 18);
            lblInfoRace.TabIndex = 33;
            lblInfoRace.Tag = "info5";
            lblInfoRace.Text = "info non dissponible";
            lblInfoRace.Visible = false;
            // 
            // lblInfoActiviter
            // 
            lblInfoActiviter.AutoSize = true;
            lblInfoActiviter.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfoActiviter.Location = new Point(370, 351);
            lblInfoActiviter.Name = "lblInfoActiviter";
            lblInfoActiviter.Size = new Size(176, 18);
            lblInfoActiviter.TabIndex = 32;
            lblInfoActiviter.Tag = "info4";
            lblInfoActiviter.Text = "info non dissponible";
            lblInfoActiviter.Visible = false;
            // 
            // lblInfoNbYeux
            // 
            lblInfoNbYeux.AutoSize = true;
            lblInfoNbYeux.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfoNbYeux.Location = new Point(370, 285);
            lblInfoNbYeux.Name = "lblInfoNbYeux";
            lblInfoNbYeux.Size = new Size(176, 18);
            lblInfoNbYeux.TabIndex = 31;
            lblInfoNbYeux.Tag = "info3";
            lblInfoNbYeux.Text = "info non dissponible";
            lblInfoNbYeux.Visible = false;
            // 
            // lblInfoNbPattes
            // 
            lblInfoNbPattes.AutoSize = true;
            lblInfoNbPattes.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfoNbPattes.Location = new Point(370, 217);
            lblInfoNbPattes.Name = "lblInfoNbPattes";
            lblInfoNbPattes.Size = new Size(176, 18);
            lblInfoNbPattes.TabIndex = 30;
            lblInfoNbPattes.Tag = "info2";
            lblInfoNbPattes.Text = "info non dissponible";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(370, 217);
            label3.Name = "label3";
            label3.Size = new Size(0, 18);
            label3.TabIndex = 29;
            label3.Tag = "info2";
            // 
            // lblInfoAlimentation
            // 
            lblInfoAlimentation.AutoSize = true;
            lblInfoAlimentation.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfoAlimentation.Location = new Point(370, 149);
            lblInfoAlimentation.Name = "lblInfoAlimentation";
            lblInfoAlimentation.Size = new Size(176, 18);
            lblInfoAlimentation.TabIndex = 28;
            lblInfoAlimentation.Tag = "info1";
            lblInfoAlimentation.Text = "info non dissponible";
            // 
            // lblRace
            // 
            lblRace.AutoSize = true;
            lblRace.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRace.Location = new Point(307, 422);
            lblRace.Name = "lblRace";
            lblRace.Size = new Size(57, 18);
            lblRace.TabIndex = 27;
            lblRace.Tag = "info5";
            lblRace.Text = "race :";
            lblRace.Visible = false;
            // 
            // lblActiviter
            // 
            lblActiviter.AutoSize = true;
            lblActiviter.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblActiviter.Location = new Point(199, 351);
            lblActiviter.Name = "lblActiviter";
            lblActiviter.Size = new Size(165, 18);
            lblActiviter.TabIndex = 26;
            lblActiviter.Tag = "info4";
            lblActiviter.Text = "moment d'activité :";
            lblActiviter.Visible = false;
            // 
            // lblNbYeux
            // 
            lblNbYeux.AutoSize = true;
            lblNbYeux.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNbYeux.Location = new Point(228, 285);
            lblNbYeux.Name = "lblNbYeux";
            lblNbYeux.Size = new Size(136, 18);
            lblNbYeux.TabIndex = 25;
            lblNbYeux.Tag = "info3";
            lblNbYeux.Text = "nombre d'yeux :";
            lblNbYeux.Visible = false;
            // 
            // lblNbPatte
            // 
            lblNbPatte.AutoSize = true;
            lblNbPatte.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNbPatte.Location = new Point(209, 217);
            lblNbPatte.Name = "lblNbPatte";
            lblNbPatte.Size = new Size(155, 18);
            lblNbPatte.TabIndex = 24;
            lblNbPatte.Tag = "info2";
            lblNbPatte.Text = "nombre de patte :";
            // 
            // lblAlimentation
            // 
            lblAlimentation.AutoSize = true;
            lblAlimentation.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlimentation.Location = new Point(235, 149);
            lblAlimentation.Name = "lblAlimentation";
            lblAlimentation.Size = new Size(129, 18);
            lblAlimentation.TabIndex = 23;
            lblAlimentation.Tag = "info1";
            lblAlimentation.Text = "alimentation :";
            // 
            // btnIndice
            // 
            btnIndice.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIndice.Location = new Point(280, 655);
            btnIndice.Name = "btnIndice";
            btnIndice.Size = new Size(180, 80);
            btnIndice.TabIndex = 19;
            btnIndice.Text = "Indice";
            btnIndice.UseVisualStyleBackColor = true;
            btnIndice.Click += btnIndice_Click;
            // 
            // btnQuitter
            // 
            btnQuitter.DialogResult = DialogResult.Cancel;
            btnQuitter.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuitter.Location = new Point(36, 655);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(180, 80);
            btnQuitter.TabIndex = 21;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = true;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Algerian", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitre.Location = new Point(251, 28);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(235, 54);
            lblTitre.TabIndex = 35;
            lblTitre.Text = "Mini Quiz";
            // 
            // miniQuizz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 782);
            Controls.Add(lblTitre);
            Controls.Add(btnValider);
            Controls.Add(txtReponse);
            Controls.Add(lblInfoRace);
            Controls.Add(lblInfoActiviter);
            Controls.Add(lblInfoNbYeux);
            Controls.Add(lblInfoNbPattes);
            Controls.Add(label3);
            Controls.Add(lblInfoAlimentation);
            Controls.Add(lblRace);
            Controls.Add(lblActiviter);
            Controls.Add(lblNbYeux);
            Controls.Add(lblNbPatte);
            Controls.Add(lblAlimentation);
            Controls.Add(btnIndice);
            Controls.Add(btnQuitter);
            Name = "miniQuizz";
            Text = "miniQuizz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnValider;
        private TextBox txtReponse;
        private Label lblInfoRace;
        private Label lblInfoActiviter;
        private Label lblInfoNbYeux;
        private Label lblInfoNbPattes;
        private Label label3;
        private Label lblInfoAlimentation;
        private Label lblRace;
        private Label lblActiviter;
        private Label lblNbYeux;
        private Label lblNbPatte;
        private Label lblAlimentation;
        private Button btnIndice;
        private Button btnQuitter;
        private Label lblTitre;
    }
}