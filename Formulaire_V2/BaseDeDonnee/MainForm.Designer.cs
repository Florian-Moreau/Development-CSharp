/*
 * Crée par SharpDevelop.
 * Créateur : Florian Moreau
 * Date: 8/17/2018
 */
namespace BaseDeDonnees
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label l_Statut;
		private System.Windows.Forms.RadioButton rb_Female;
		private System.Windows.Forms.RadioButton rb_Male;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox t_nom;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox t_mail;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox t_code;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox t_ville;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox t_commentaire;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox t_etablissement;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox t_section;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label l_mail;
		private System.Windows.Forms.Label l_code;
		private System.Windows.Forms.Label l_ville;
		private System.Windows.Forms.Label l_naissance;
		private System.Windows.Forms.Label l_sexe;
		private System.Windows.Forms.Label l_nom;
		private System.Windows.Forms.Label l_prenom;
		private System.Windows.Forms.Label l_etablissement;
		private System.Windows.Forms.Label l_section;
		private System.Windows.Forms.Label l_inscris;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button b_refresh;
		private System.Windows.Forms.DateTimePicker t_date;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.PictureBox jpo;
		private System.Windows.Forms.PictureBox academie;
		private System.Windows.Forms.PictureBox ab;
		private System.Windows.Forms.Label Copyright;
		private System.Windows.Forms.Button b_fin;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.t_date = new System.Windows.Forms.DateTimePicker();
			this.l_mail = new System.Windows.Forms.Label();
			this.l_code = new System.Windows.Forms.Label();
			this.l_ville = new System.Windows.Forms.Label();
			this.l_naissance = new System.Windows.Forms.Label();
			this.l_sexe = new System.Windows.Forms.Label();
			this.l_nom = new System.Windows.Forms.Label();
			this.l_prenom = new System.Windows.Forms.Label();
			this.t_mail = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.t_code = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.t_ville = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.rb_Female = new System.Windows.Forms.RadioButton();
			this.rb_Male = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.t_nom = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.l_Statut = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.l_etablissement = new System.Windows.Forms.Label();
			this.l_section = new System.Windows.Forms.Label();
			this.t_commentaire = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.t_etablissement = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.t_section = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.l_inscris = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.b_refresh = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.jpo = new System.Windows.Forms.PictureBox();
			this.academie = new System.Windows.Forms.PictureBox();
			this.ab = new System.Windows.Forms.PictureBox();
			this.Copyright = new System.Windows.Forms.Label();
			this.b_fin = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.jpo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.academie)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ab)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Location = new System.Drawing.Point(79, 21);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(117, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Se Connecter";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
			this.groupBox1.Controls.Add(this.t_date);
			this.groupBox1.Controls.Add(this.l_mail);
			this.groupBox1.Controls.Add(this.l_code);
			this.groupBox1.Controls.Add(this.l_ville);
			this.groupBox1.Controls.Add(this.l_naissance);
			this.groupBox1.Controls.Add(this.l_sexe);
			this.groupBox1.Controls.Add(this.l_nom);
			this.groupBox1.Controls.Add(this.l_prenom);
			this.groupBox1.Controls.Add(this.t_mail);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.t_code);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.t_ville);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.rb_Female);
			this.groupBox1.Controls.Add(this.rb_Male);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.t_nom);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 316);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(491, 458);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Etudiant";
			// 
			// t_date
			// 
			this.t_date.CustomFormat = "MM-dd-yyyy";
			this.t_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.t_date.Location = new System.Drawing.Point(223, 197);
			this.t_date.Name = "t_date";
			this.t_date.Size = new System.Drawing.Size(222, 22);
			this.t_date.TabIndex = 5;
			// 
			// l_mail
			// 
			this.l_mail.Location = new System.Drawing.Point(223, 419);
			this.l_mail.Name = "l_mail";
			this.l_mail.Size = new System.Drawing.Size(222, 23);
			this.l_mail.TabIndex = 24;
			// 
			// l_code
			// 
			this.l_code.Location = new System.Drawing.Point(223, 343);
			this.l_code.Name = "l_code";
			this.l_code.Size = new System.Drawing.Size(222, 23);
			this.l_code.TabIndex = 23;
			// 
			// l_ville
			// 
			this.l_ville.Location = new System.Drawing.Point(223, 283);
			this.l_ville.Name = "l_ville";
			this.l_ville.Size = new System.Drawing.Size(222, 23);
			this.l_ville.TabIndex = 22;
			// 
			// l_naissance
			// 
			this.l_naissance.Location = new System.Drawing.Point(223, 224);
			this.l_naissance.Name = "l_naissance";
			this.l_naissance.Size = new System.Drawing.Size(222, 23);
			this.l_naissance.TabIndex = 21;
			// 
			// l_sexe
			// 
			this.l_sexe.Location = new System.Drawing.Point(223, 168);
			this.l_sexe.Name = "l_sexe";
			this.l_sexe.Size = new System.Drawing.Size(222, 23);
			this.l_sexe.TabIndex = 20;
			// 
			// l_nom
			// 
			this.l_nom.Location = new System.Drawing.Point(223, 118);
			this.l_nom.Name = "l_nom";
			this.l_nom.Size = new System.Drawing.Size(222, 23);
			this.l_nom.TabIndex = 19;
			// 
			// l_prenom
			// 
			this.l_prenom.Location = new System.Drawing.Point(223, 58);
			this.l_prenom.Name = "l_prenom";
			this.l_prenom.Size = new System.Drawing.Size(222, 23);
			this.l_prenom.TabIndex = 18;
			// 
			// t_mail
			// 
			this.t_mail.Location = new System.Drawing.Point(223, 394);
			this.t_mail.Name = "t_mail";
			this.t_mail.Size = new System.Drawing.Size(222, 22);
			this.t_mail.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(171, 397);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 19);
			this.label7.TabIndex = 17;
			this.label7.Text = "Email";
			// 
			// t_code
			// 
			this.t_code.Location = new System.Drawing.Point(223, 318);
			this.t_code.Name = "t_code";
			this.t_code.Size = new System.Drawing.Size(222, 22);
			this.t_code.TabIndex = 7;
			this.t_code.Validated += new System.EventHandler(this.t_codeP);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(128, 318);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(89, 22);
			this.label6.TabIndex = 15;
			this.label6.Text = "Code Postal";
			// 
			// t_ville
			// 
			this.t_ville.Location = new System.Drawing.Point(223, 258);
			this.t_ville.Name = "t_ville";
			this.t_ville.Size = new System.Drawing.Size(222, 22);
			this.t_ville.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(178, 262);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 16);
			this.label5.TabIndex = 13;
			this.label5.Text = "Ville";
			// 
			// rb_Female
			// 
			this.rb_Female.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rb_Female.Location = new System.Drawing.Point(377, 144);
			this.rb_Female.Name = "rb_Female";
			this.rb_Female.Size = new System.Drawing.Size(40, 21);
			this.rb_Female.TabIndex = 4;
			this.rb_Female.TabStop = true;
			this.rb_Female.Text = "F";
			this.rb_Female.UseVisualStyleBackColor = true;
			this.rb_Female.Click += new System.EventHandler(this.rb_female);
			// 
			// rb_Male
			// 
			this.rb_Male.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rb_Male.Location = new System.Drawing.Point(257, 144);
			this.rb_Male.Name = "rb_Male";
			this.rb_Male.Size = new System.Drawing.Size(40, 21);
			this.rb_Male.TabIndex = 3;
			this.rb_Male.TabStop = true;
			this.rb_Male.Text = "M";
			this.rb_Male.UseVisualStyleBackColor = true;
			this.rb_Male.Click += new System.EventHandler(this.rb_male);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(178, 146);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 21);
			this.label4.TabIndex = 6;
			this.label4.Text = "Sexe";
			// 
			// t_nom
			// 
			this.t_nom.Location = new System.Drawing.Point(223, 95);
			this.t_nom.Name = "t_nom";
			this.t_nom.Size = new System.Drawing.Size(222, 22);
			this.t_nom.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(178, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Nom";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(223, 29);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(222, 22);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(161, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Prénom";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(85, 199);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Date De Naissance";
			// 
			// button2
			// 
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Location = new System.Drawing.Point(80, 118);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(116, 23);
			this.button2.TabIndex = 12;
			this.button2.Text = "Envoyer";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// l_Statut
			// 
			this.l_Statut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.l_Statut.ForeColor = System.Drawing.Color.Red;
			this.l_Statut.Location = new System.Drawing.Point(47, 65);
			this.l_Statut.Name = "l_Statut";
			this.l_Statut.Size = new System.Drawing.Size(182, 29);
			this.l_Statut.TabIndex = 3;
			this.l_Statut.Text = "Vous êtes déconnecté";
			this.l_Statut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.l_etablissement);
			this.groupBox2.Controls.Add(this.l_section);
			this.groupBox2.Controls.Add(this.t_commentaire);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.t_etablissement);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.t_section);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(775, 316);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(463, 457);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Scolaire";
			// 
			// l_etablissement
			// 
			this.l_etablissement.Location = new System.Drawing.Point(159, 169);
			this.l_etablissement.Name = "l_etablissement";
			this.l_etablissement.Size = new System.Drawing.Size(244, 23);
			this.l_etablissement.TabIndex = 26;
			// 
			// l_section
			// 
			this.l_section.Location = new System.Drawing.Point(159, 53);
			this.l_section.Name = "l_section";
			this.l_section.Size = new System.Drawing.Size(244, 23);
			this.l_section.TabIndex = 25;
			// 
			// t_commentaire
			// 
			this.t_commentaire.Location = new System.Drawing.Point(159, 258);
			this.t_commentaire.Multiline = true;
			this.t_commentaire.Name = "t_commentaire";
			this.t_commentaire.Size = new System.Drawing.Size(244, 152);
			this.t_commentaire.TabIndex = 11;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(59, 323);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(94, 16);
			this.label10.TabIndex = 23;
			this.label10.Text = "Commentaire";
			// 
			// t_etablissement
			// 
			this.t_etablissement.Location = new System.Drawing.Point(159, 144);
			this.t_etablissement.Name = "t_etablissement";
			this.t_etablissement.Size = new System.Drawing.Size(244, 22);
			this.t_etablissement.TabIndex = 10;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(59, 147);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(94, 19);
			this.label9.TabIndex = 21;
			this.label9.Text = "Etablissement";
			// 
			// t_section
			// 
			this.t_section.Location = new System.Drawing.Point(159, 28);
			this.t_section.Name = "t_section";
			this.t_section.Size = new System.Drawing.Size(244, 22);
			this.t_section.TabIndex = 9;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(46, 32);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(107, 18);
			this.label8.TabIndex = 19;
			this.label8.Text = "Section Actuelle";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button1);
			this.groupBox3.Controls.Add(this.button2);
			this.groupBox3.Controls.Add(this.l_Statut);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(509, 447);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(261, 147);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Commande";
			// 
			// l_inscris
			// 
			this.l_inscris.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.l_inscris.Location = new System.Drawing.Point(248, 46);
			this.l_inscris.Name = "l_inscris";
			this.l_inscris.Size = new System.Drawing.Size(86, 40);
			this.l_inscris.TabIndex = 6;
			this.l_inscris.Text = "None";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(6, 53);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(236, 33);
			this.label12.TabIndex = 7;
			this.label12.Text = "Nombre de personnes déjà inscrites : ";
			// 
			// b_refresh
			// 
			this.b_refresh.Enabled = false;
			this.b_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.b_refresh.Location = new System.Drawing.Point(147, 89);
			this.b_refresh.Name = "b_refresh";
			this.b_refresh.Size = new System.Drawing.Size(75, 23);
			this.b_refresh.TabIndex = 13;
			this.b_refresh.Text = "Refresh";
			this.b_refresh.UseVisualStyleBackColor = true;
			this.b_refresh.Click += new System.EventHandler(this.B_refreshClick);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Controls.Add(this.b_refresh);
			this.groupBox4.Controls.Add(this.l_inscris);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(468, 780);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(367, 152);
			this.groupBox4.TabIndex = 14;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Infos";
			// 
			// jpo
			// 
			this.jpo.Image = ((System.Drawing.Image)(resources.GetObject("jpo.Image")));
			this.jpo.Location = new System.Drawing.Point(375, 12);
			this.jpo.Name = "jpo";
			this.jpo.Size = new System.Drawing.Size(553, 284);
			this.jpo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.jpo.TabIndex = 15;
			this.jpo.TabStop = false;
			// 
			// academie
			// 
			this.academie.Image = ((System.Drawing.Image)(resources.GetObject("academie.Image")));
			this.academie.Location = new System.Drawing.Point(12, 12);
			this.academie.Name = "academie";
			this.academie.Size = new System.Drawing.Size(260, 190);
			this.academie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.academie.TabIndex = 16;
			this.academie.TabStop = false;
			// 
			// ab
			// 
			this.ab.Image = ((System.Drawing.Image)(resources.GetObject("ab.Image")));
			this.ab.Location = new System.Drawing.Point(975, 12);
			this.ab.Name = "ab";
			this.ab.Size = new System.Drawing.Size(263, 192);
			this.ab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.ab.TabIndex = 17;
			this.ab.TabStop = false;
			// 
			// Copyright
			// 
			this.Copyright.Location = new System.Drawing.Point(12, 909);
			this.Copyright.Name = "Copyright";
			this.Copyright.Size = new System.Drawing.Size(170, 23);
			this.Copyright.TabIndex = 18;
			this.Copyright.Text = "Florian Moreau © Copyright 2018";
			// 
			// b_fin
			// 
			this.b_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.b_fin.Location = new System.Drawing.Point(615, 750);
			this.b_fin.Name = "b_fin";
			this.b_fin.Size = new System.Drawing.Size(75, 23);
			this.b_fin.TabIndex = 14;
			this.b_fin.Text = "Quitter";
			this.b_fin.UseVisualStyleBackColor = true;
			this.b_fin.Click += new System.EventHandler(this.B_finClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1250, 749);
			this.Controls.Add(this.b_fin);
			this.Controls.Add(this.Copyright);
			this.Controls.Add(this.ab);
			this.Controls.Add(this.academie);
			this.Controls.Add(this.jpo);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Formulaire";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.jpo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.academie)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ab)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
