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
		private System.Windows.Forms.TextBox t_date;
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
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
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
			this.t_date = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.l_Statut = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.t_commentaire = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.t_etablissement = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.t_section = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
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
			this.groupBox1.Controls.Add(this.t_date);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(496, 323);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Etudiant";
			// 
			// t_mail
			// 
			this.t_mail.Location = new System.Drawing.Point(223, 247);
			this.t_mail.Name = "t_mail";
			this.t_mail.Size = new System.Drawing.Size(222, 22);
			this.t_mail.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(171, 250);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 19);
			this.label7.TabIndex = 17;
			this.label7.Text = "Email";
			// 
			// t_code
			// 
			this.t_code.Location = new System.Drawing.Point(223, 209);
			this.t_code.Name = "t_code";
			this.t_code.Size = new System.Drawing.Size(222, 22);
			this.t_code.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(128, 209);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(89, 22);
			this.label6.TabIndex = 15;
			this.label6.Text = "Code Postal";
			// 
			// t_ville
			// 
			this.t_ville.Location = new System.Drawing.Point(223, 169);
			this.t_ville.Name = "t_ville";
			this.t_ville.Size = new System.Drawing.Size(222, 22);
			this.t_ville.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(178, 173);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 16);
			this.label5.TabIndex = 13;
			this.label5.Text = "Ville";
			// 
			// rb_Female
			// 
			this.rb_Female.Location = new System.Drawing.Point(377, 92);
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
			this.rb_Male.Location = new System.Drawing.Point(257, 92);
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
			this.label4.Location = new System.Drawing.Point(178, 94);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 21);
			this.label4.TabIndex = 6;
			this.label4.Text = "Sexe";
			// 
			// t_nom
			// 
			this.t_nom.Location = new System.Drawing.Point(223, 57);
			this.t_nom.Name = "t_nom";
			this.t_nom.Size = new System.Drawing.Size(222, 22);
			this.t_nom.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(178, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Nom";
			// 
			// t_date
			// 
			this.t_date.AccessibleDescription = "";
			this.t_date.Location = new System.Drawing.Point(223, 130);
			this.t_date.Name = "t_date";
			this.t_date.Size = new System.Drawing.Size(222, 22);
			this.t_date.TabIndex = 5;
			this.t_date.Text = "jj/mm/aaaa";
			this.t_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
			this.label2.Location = new System.Drawing.Point(85, 130);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Date De Naissance";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(80, 118);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(116, 23);
			this.button2.TabIndex = 2;
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
			this.groupBox2.Controls.Add(this.t_commentaire);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.t_etablissement);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.t_section);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(527, 13);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(459, 322);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Scolaire";
			// 
			// t_commentaire
			// 
			this.t_commentaire.Location = new System.Drawing.Point(159, 160);
			this.t_commentaire.Multiline = true;
			this.t_commentaire.Name = "t_commentaire";
			this.t_commentaire.Size = new System.Drawing.Size(244, 152);
			this.t_commentaire.TabIndex = 11;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(59, 225);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(94, 16);
			this.label10.TabIndex = 23;
			this.label10.Text = "Commentaire";
			// 
			// t_etablissement
			// 
			this.t_etablissement.Location = new System.Drawing.Point(159, 92);
			this.t_etablissement.Name = "t_etablissement";
			this.t_etablissement.Size = new System.Drawing.Size(244, 22);
			this.t_etablissement.TabIndex = 10;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(59, 95);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(94, 19);
			this.label9.TabIndex = 21;
			this.label9.Text = "Etablissement";
			// 
			// t_section
			// 
			this.t_section.Location = new System.Drawing.Point(159, 24);
			this.t_section.Name = "t_section";
			this.t_section.Size = new System.Drawing.Size(244, 22);
			this.t_section.TabIndex = 9;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(46, 28);
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
			this.groupBox3.Location = new System.Drawing.Point(389, 370);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(261, 147);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Commande";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(998, 529);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Formulaire";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
