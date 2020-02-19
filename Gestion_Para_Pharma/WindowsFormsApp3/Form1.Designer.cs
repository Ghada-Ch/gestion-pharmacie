namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dglisteClients = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbGamme = new System.Windows.Forms.GroupBox();
            this.lbAutreG = new System.Windows.Forms.Label();
            this.textbAutreGamme = new System.Windows.Forms.TextBox();
            this.checkedListGammes = new System.Windows.Forms.CheckedListBox();
            this.gbInteret = new System.Windows.Forms.GroupBox();
            this.lbAutreI = new System.Windows.Forms.Label();
            this.textbAutreInteret = new System.Windows.Forms.TextBox();
            this.checkedListInterets = new System.Windows.Forms.CheckedListBox();
            this.gbRemarque = new System.Windows.Forms.GroupBox();
            this.txtbRemarque = new System.Windows.Forms.RichTextBox();
            this.checkBoxEmail = new System.Windows.Forms.CheckBox();
            this.checkBoxSMS = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labCode = new System.Windows.Forms.Label();
            this.txtbCode = new System.Windows.Forms.TextBox();
            this.dpikDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.labCivilite = new System.Windows.Forms.Label();
            this.labDateNaissance = new System.Windows.Forms.Label();
            this.txtbCivilite = new System.Windows.Forms.TextBox();
            this.labfacebook = new System.Windows.Forms.Label();
            this.labemail = new System.Windows.Forms.Label();
            this.labAdresse = new System.Windows.Forms.Label();
            this.txtbTel = new System.Windows.Forms.TextBox();
            this.txtbAdresse = new System.Windows.Forms.TextBox();
            this.labtel = new System.Windows.Forms.Label();
            this.labPrenom = new System.Windows.Forms.Label();
            this.labNom = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.txtbNom = new System.Windows.Forms.TextBox();
            this.txtbPrenom = new System.Windows.Forms.TextBox();
            this.txtbFacebook = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butQuitter = new System.Windows.Forms.Button();
            this.butConfirmer = new System.Windows.Forms.Button();
            this.buSupprimer = new System.Windows.Forms.Button();
            this.butModifier = new System.Windows.Forms.Button();
            this.butAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dglisteClients)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbGamme.SuspendLayout();
            this.gbInteret.SuspendLayout();
            this.gbRemarque.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dglisteClients
            // 
            this.dglisteClients.AllowUserToOrderColumns = true;
            this.dglisteClients.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dglisteClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglisteClients.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dglisteClients.Location = new System.Drawing.Point(12, 139);
            this.dglisteClients.Name = "dglisteClients";
            this.dglisteClients.Size = new System.Drawing.Size(492, 150);
            this.dglisteClients.TabIndex = 0;
            this.dglisteClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dglisteClients_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(46, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(289, 76);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(110, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Code Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prenom";
            // 
            // gbGamme
            // 
            this.gbGamme.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbGamme.BackColor = System.Drawing.Color.Transparent;
            this.gbGamme.Controls.Add(this.lbAutreG);
            this.gbGamme.Controls.Add(this.textbAutreGamme);
            this.gbGamme.Controls.Add(this.checkedListGammes);
            this.gbGamme.Location = new System.Drawing.Point(550, 236);
            this.gbGamme.Name = "gbGamme";
            this.gbGamme.Padding = new System.Windows.Forms.Padding(10, 50, 10, 10);
            this.gbGamme.Size = new System.Drawing.Size(149, 246);
            this.gbGamme.TabIndex = 2;
            this.gbGamme.TabStop = false;
            this.gbGamme.Text = "Gamme";
            // 
            // lbAutreG
            // 
            this.lbAutreG.AutoSize = true;
            this.lbAutreG.BackColor = System.Drawing.Color.White;
            this.lbAutreG.Location = new System.Drawing.Point(15, 210);
            this.lbAutreG.Name = "lbAutreG";
            this.lbAutreG.Size = new System.Drawing.Size(32, 13);
            this.lbAutreG.TabIndex = 23;
            this.lbAutreG.Text = "Autre";
            // 
            // textbAutreGamme
            // 
            this.textbAutreGamme.Location = new System.Drawing.Point(48, 205);
            this.textbAutreGamme.Name = "textbAutreGamme";
            this.textbAutreGamme.Size = new System.Drawing.Size(85, 20);
            this.textbAutreGamme.TabIndex = 7;
            // 
            // checkedListGammes
            // 
            this.checkedListGammes.BackColor = System.Drawing.Color.White;
            this.checkedListGammes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkedListGammes.FormattingEnabled = true;
            this.checkedListGammes.Location = new System.Drawing.Point(12, 34);
            this.checkedListGammes.Name = "checkedListGammes";
            this.checkedListGammes.Size = new System.Drawing.Size(127, 199);
            this.checkedListGammes.TabIndex = 1;
            this.checkedListGammes.SelectedIndexChanged += new System.EventHandler(this.checkedListGammes_SelectedIndexChanged);
            // 
            // gbInteret
            // 
            this.gbInteret.BackColor = System.Drawing.Color.Transparent;
            this.gbInteret.Controls.Add(this.lbAutreI);
            this.gbInteret.Controls.Add(this.textbAutreInteret);
            this.gbInteret.Controls.Add(this.checkedListInterets);
            this.gbInteret.Location = new System.Drawing.Point(712, 236);
            this.gbInteret.Name = "gbInteret";
            this.gbInteret.Size = new System.Drawing.Size(144, 246);
            this.gbInteret.TabIndex = 3;
            this.gbInteret.TabStop = false;
            this.gbInteret.Text = "Interet";
            // 
            // lbAutreI
            // 
            this.lbAutreI.AutoSize = true;
            this.lbAutreI.BackColor = System.Drawing.Color.White;
            this.lbAutreI.Location = new System.Drawing.Point(12, 204);
            this.lbAutreI.Name = "lbAutreI";
            this.lbAutreI.Size = new System.Drawing.Size(32, 13);
            this.lbAutreI.TabIndex = 22;
            this.lbAutreI.Text = "Autre";
            // 
            // textbAutreInteret
            // 
            this.textbAutreInteret.Location = new System.Drawing.Point(44, 199);
            this.textbAutreInteret.Name = "textbAutreInteret";
            this.textbAutreInteret.Size = new System.Drawing.Size(85, 20);
            this.textbAutreInteret.TabIndex = 6;
            // 
            // checkedListInterets
            // 
            this.checkedListInterets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkedListInterets.FormattingEnabled = true;
            this.checkedListInterets.Location = new System.Drawing.Point(9, 31);
            this.checkedListInterets.Name = "checkedListInterets";
            this.checkedListInterets.Size = new System.Drawing.Size(125, 199);
            this.checkedListInterets.TabIndex = 2;
            this.checkedListInterets.SelectedIndexChanged += new System.EventHandler(this.checkedListInterets_SelectedIndexChanged);
            // 
            // gbRemarque
            // 
            this.gbRemarque.BackColor = System.Drawing.Color.Transparent;
            this.gbRemarque.Controls.Add(this.txtbRemarque);
            this.gbRemarque.Location = new System.Drawing.Point(874, 236);
            this.gbRemarque.Name = "gbRemarque";
            this.gbRemarque.Size = new System.Drawing.Size(349, 152);
            this.gbRemarque.TabIndex = 4;
            this.gbRemarque.TabStop = false;
            this.gbRemarque.Text = "Remarque Suggetion";
            // 
            // txtbRemarque
            // 
            this.txtbRemarque.Location = new System.Drawing.Point(13, 19);
            this.txtbRemarque.Name = "txtbRemarque";
            this.txtbRemarque.Size = new System.Drawing.Size(329, 109);
            this.txtbRemarque.TabIndex = 1;
            this.txtbRemarque.Text = "";
            // 
            // checkBoxEmail
            // 
            this.checkBoxEmail.AutoSize = true;
            this.checkBoxEmail.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEmail.Location = new System.Drawing.Point(862, 394);
            this.checkBoxEmail.Name = "checkBoxEmail";
            this.checkBoxEmail.Size = new System.Drawing.Size(401, 17);
            this.checkBoxEmail.TabIndex = 2;
            this.checkBoxEmail.Text = "j\'accepte de recevoir des informations et des offres de ParaPharmacie par Email";
            this.checkBoxEmail.UseVisualStyleBackColor = false;
            // 
            // checkBoxSMS
            // 
            this.checkBoxSMS.AutoSize = true;
            this.checkBoxSMS.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxSMS.Location = new System.Drawing.Point(863, 422);
            this.checkBoxSMS.Name = "checkBoxSMS";
            this.checkBoxSMS.Size = new System.Drawing.Size(399, 17);
            this.checkBoxSMS.TabIndex = 5;
            this.checkBoxSMS.Text = "j\'accepte de recevoir des informations et des offres de ParaPharmacie par SMS";
            this.checkBoxSMS.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.labCode);
            this.groupBox5.Controls.Add(this.txtbCode);
            this.groupBox5.Controls.Add(this.dpikDateNaissance);
            this.groupBox5.Controls.Add(this.labCivilite);
            this.groupBox5.Controls.Add(this.labDateNaissance);
            this.groupBox5.Controls.Add(this.txtbCivilite);
            this.groupBox5.Controls.Add(this.labfacebook);
            this.groupBox5.Controls.Add(this.labemail);
            this.groupBox5.Controls.Add(this.labAdresse);
            this.groupBox5.Controls.Add(this.txtbTel);
            this.groupBox5.Controls.Add(this.txtbAdresse);
            this.groupBox5.Controls.Add(this.labtel);
            this.groupBox5.Controls.Add(this.labPrenom);
            this.groupBox5.Controls.Add(this.labNom);
            this.groupBox5.Controls.Add(this.txtbEmail);
            this.groupBox5.Controls.Add(this.txtbNom);
            this.groupBox5.Controls.Add(this.txtbPrenom);
            this.groupBox5.Controls.Add(this.txtbFacebook);
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Location = new System.Drawing.Point(550, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(705, 206);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Information Client";
            // 
            // labCode
            // 
            this.labCode.AutoSize = true;
            this.labCode.Location = new System.Drawing.Point(15, 30);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(32, 13);
            this.labCode.TabIndex = 21;
            this.labCode.Text = "Code";
            // 
            // txtbCode
            // 
            this.txtbCode.Location = new System.Drawing.Point(7, 56);
            this.txtbCode.Name = "txtbCode";
            this.txtbCode.Size = new System.Drawing.Size(83, 20);
            this.txtbCode.TabIndex = 20;
            // 
            // dpikDateNaissance
            // 
            this.dpikDateNaissance.Location = new System.Drawing.Point(6, 108);
            this.dpikDateNaissance.Name = "dpikDateNaissance";
            this.dpikDateNaissance.Size = new System.Drawing.Size(165, 20);
            this.dpikDateNaissance.TabIndex = 19;
            // 
            // labCivilite
            // 
            this.labCivilite.AutoSize = true;
            this.labCivilite.Location = new System.Drawing.Point(439, 30);
            this.labCivilite.Name = "labCivilite";
            this.labCivilite.Size = new System.Drawing.Size(35, 13);
            this.labCivilite.TabIndex = 18;
            this.labCivilite.Text = "Cvilite";
            // 
            // labDateNaissance
            // 
            this.labDateNaissance.AutoSize = true;
            this.labDateNaissance.Location = new System.Drawing.Point(38, 82);
            this.labDateNaissance.Name = "labDateNaissance";
            this.labDateNaissance.Size = new System.Drawing.Size(80, 13);
            this.labDateNaissance.TabIndex = 17;
            this.labDateNaissance.Text = "DateNaissance";
            // 
            // txtbCivilite
            // 
            this.txtbCivilite.Location = new System.Drawing.Point(387, 56);
            this.txtbCivilite.Name = "txtbCivilite";
            this.txtbCivilite.Size = new System.Drawing.Size(133, 20);
            this.txtbCivilite.TabIndex = 16;
            // 
            // labfacebook
            // 
            this.labfacebook.AutoSize = true;
            this.labfacebook.Location = new System.Drawing.Point(326, 141);
            this.labfacebook.Name = "labfacebook";
            this.labfacebook.Size = new System.Drawing.Size(55, 13);
            this.labfacebook.TabIndex = 15;
            this.labfacebook.Text = "Facebook";
            // 
            // labemail
            // 
            this.labemail.AutoSize = true;
            this.labemail.Location = new System.Drawing.Point(82, 144);
            this.labemail.Name = "labemail";
            this.labemail.Size = new System.Drawing.Size(73, 13);
            this.labemail.TabIndex = 13;
            this.labemail.Text = "Adresse Email";
            // 
            // labAdresse
            // 
            this.labAdresse.AutoSize = true;
            this.labAdresse.Location = new System.Drawing.Point(395, 82);
            this.labAdresse.Name = "labAdresse";
            this.labAdresse.Size = new System.Drawing.Size(45, 13);
            this.labAdresse.TabIndex = 12;
            this.labAdresse.Text = "Adresse";
            // 
            // txtbTel
            // 
            this.txtbTel.Location = new System.Drawing.Point(187, 108);
            this.txtbTel.Name = "txtbTel";
            this.txtbTel.Size = new System.Drawing.Size(133, 20);
            this.txtbTel.TabIndex = 11;
            this.txtbTel.TextChanged += new System.EventHandler(this.txtbTel_TextChanged);
            // 
            // txtbAdresse
            // 
            this.txtbAdresse.Location = new System.Drawing.Point(332, 108);
            this.txtbAdresse.Name = "txtbAdresse";
            this.txtbAdresse.Size = new System.Drawing.Size(190, 20);
            this.txtbAdresse.TabIndex = 10;
            // 
            // labtel
            // 
            this.labtel.AutoSize = true;
            this.labtel.Location = new System.Drawing.Point(219, 82);
            this.labtel.Name = "labtel";
            this.labtel.Size = new System.Drawing.Size(58, 13);
            this.labtel.TabIndex = 6;
            this.labtel.Text = "Telephone";
            // 
            // labPrenom
            // 
            this.labPrenom.AutoSize = true;
            this.labPrenom.Location = new System.Drawing.Point(286, 30);
            this.labPrenom.Name = "labPrenom";
            this.labPrenom.Size = new System.Drawing.Size(43, 13);
            this.labPrenom.TabIndex = 8;
            this.labPrenom.Text = "Prenom";
            // 
            // labNom
            // 
            this.labNom.AutoSize = true;
            this.labNom.Location = new System.Drawing.Point(144, 30);
            this.labNom.Name = "labNom";
            this.labNom.Size = new System.Drawing.Size(29, 13);
            this.labNom.TabIndex = 9;
            this.labNom.Text = "Nom";
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(18, 170);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(200, 20);
            this.txtbEmail.TabIndex = 6;
            // 
            // txtbNom
            // 
            this.txtbNom.Location = new System.Drawing.Point(104, 56);
            this.txtbNom.Name = "txtbNom";
            this.txtbNom.Size = new System.Drawing.Size(124, 20);
            this.txtbNom.TabIndex = 4;
            // 
            // txtbPrenom
            // 
            this.txtbPrenom.Location = new System.Drawing.Point(249, 56);
            this.txtbPrenom.Name = "txtbPrenom";
            this.txtbPrenom.Size = new System.Drawing.Size(124, 20);
            this.txtbPrenom.TabIndex = 3;
            // 
            // txtbFacebook
            // 
            this.txtbFacebook.Location = new System.Drawing.Point(262, 170);
            this.txtbFacebook.Name = "txtbFacebook";
            this.txtbFacebook.Size = new System.Drawing.Size(201, 20);
            this.txtbFacebook.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(538, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // butQuitter
            // 
            this.butQuitter.Location = new System.Drawing.Point(1141, 459);
            this.butQuitter.Name = "butQuitter";
            this.butQuitter.Size = new System.Drawing.Size(75, 23);
            this.butQuitter.TabIndex = 7;
            this.butQuitter.Text = "Quitter";
            this.butQuitter.UseVisualStyleBackColor = true;
            this.butQuitter.Click += new System.EventHandler(this.butQuitter_Click_1);
            // 
            // butConfirmer
            // 
            this.butConfirmer.Location = new System.Drawing.Point(1046, 459);
            this.butConfirmer.Name = "butConfirmer";
            this.butConfirmer.Size = new System.Drawing.Size(75, 23);
            this.butConfirmer.TabIndex = 8;
            this.butConfirmer.Text = "Confirmer";
            this.butConfirmer.UseVisualStyleBackColor = true;
            this.butConfirmer.Click += new System.EventHandler(this.butConfirmer_Click);
            // 
            // buSupprimer
            // 
            this.buSupprimer.Location = new System.Drawing.Point(363, 423);
            this.buSupprimer.Name = "buSupprimer";
            this.buSupprimer.Size = new System.Drawing.Size(75, 23);
            this.buSupprimer.TabIndex = 9;
            this.buSupprimer.Text = "Supprimer";
            this.buSupprimer.UseVisualStyleBackColor = true;
            this.buSupprimer.Click += new System.EventHandler(this.buSupprimer_Click);
            // 
            // butModifier
            // 
            this.butModifier.Location = new System.Drawing.Point(229, 423);
            this.butModifier.Name = "butModifier";
            this.butModifier.Size = new System.Drawing.Size(75, 23);
            this.butModifier.TabIndex = 10;
            this.butModifier.Text = "Modifier";
            this.butModifier.UseVisualStyleBackColor = true;
            this.butModifier.Click += new System.EventHandler(this.butModifier_Click);
            // 
            // butAjouter
            // 
            this.butAjouter.Location = new System.Drawing.Point(95, 423);
            this.butAjouter.Name = "butAjouter";
            this.butAjouter.Size = new System.Drawing.Size(75, 23);
            this.butAjouter.TabIndex = 11;
            this.butAjouter.Text = "Ajouter";
            this.butAjouter.UseVisualStyleBackColor = true;
            this.butAjouter.Click += new System.EventHandler(this.butAjouter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1267, 494);
            this.Controls.Add(this.butAjouter);
            this.Controls.Add(this.butModifier);
            this.Controls.Add(this.buSupprimer);
            this.Controls.Add(this.butConfirmer);
            this.Controls.Add(this.butQuitter);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.checkBoxSMS);
            this.Controls.Add(this.checkBoxEmail);
            this.Controls.Add(this.gbRemarque);
            this.Controls.Add(this.gbInteret);
            this.Controls.Add(this.gbGamme);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dglisteClients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ParaPharmacie";
            ((System.ComponentModel.ISupportInitialize)(this.dglisteClients)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbGamme.ResumeLayout(false);
            this.gbGamme.PerformLayout();
            this.gbInteret.ResumeLayout(false);
            this.gbInteret.PerformLayout();
            this.gbRemarque.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dglisteClients;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbGamme;
        private System.Windows.Forms.GroupBox gbInteret;
        private System.Windows.Forms.GroupBox gbRemarque;
        private System.Windows.Forms.RichTextBox txtbRemarque;
        private System.Windows.Forms.CheckBox checkBoxEmail;
        private System.Windows.Forms.CheckBox checkBoxSMS;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dpikDateNaissance;
        private System.Windows.Forms.Label labCivilite;
        private System.Windows.Forms.Label labDateNaissance;
        private System.Windows.Forms.TextBox txtbCivilite;
        private System.Windows.Forms.Label labfacebook;
        private System.Windows.Forms.Label labemail;
        private System.Windows.Forms.Label labAdresse;
        private System.Windows.Forms.TextBox txtbTel;
        private System.Windows.Forms.TextBox txtbAdresse;
        private System.Windows.Forms.Label labtel;
        private System.Windows.Forms.Label labPrenom;
        private System.Windows.Forms.Label labNom;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.TextBox txtbNom;
        private System.Windows.Forms.TextBox txtbPrenom;
        private System.Windows.Forms.TextBox txtbFacebook;
        private System.Windows.Forms.Button butQuitter;
        private System.Windows.Forms.Button butConfirmer;
        private System.Windows.Forms.Button buSupprimer;
        private System.Windows.Forms.Button butModifier;
        private System.Windows.Forms.Button butAjouter;
        private System.Windows.Forms.Label labCode;
        private System.Windows.Forms.TextBox txtbCode;
        private System.Windows.Forms.CheckedListBox checkedListGammes;
        private System.Windows.Forms.CheckedListBox checkedListInterets;
        private System.Windows.Forms.TextBox textbAutreGamme;
        private System.Windows.Forms.TextBox textbAutreInteret;
        private System.Windows.Forms.Label lbAutreG;
        private System.Windows.Forms.Label lbAutreI;
    }
}

