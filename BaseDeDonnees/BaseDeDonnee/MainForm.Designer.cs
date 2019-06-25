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
		private System.Windows.Forms.Label l_Statut;
		private System.Windows.Forms.GroupBox g_connexion;
		private System.Windows.Forms.Label l_server;
		private System.Windows.Forms.Label l_base;
		private System.Windows.Forms.Label l_user;
		private System.Windows.Forms.Label l_pass;
		private System.Windows.Forms.TextBox t_server;
		private System.Windows.Forms.TextBox t_base;
		private System.Windows.Forms.TextBox t_user;
		private System.Windows.Forms.TextBox t_pass;
		private System.Windows.Forms.Label l_tableTitre;
		private System.Windows.Forms.TextBox t_table;
		private System.Windows.Forms.GroupBox g_command;
		private System.Windows.Forms.Button t_send;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox t_colonne;
		
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
			this.l_Statut = new System.Windows.Forms.Label();
			this.g_connexion = new System.Windows.Forms.GroupBox();
			this.t_pass = new System.Windows.Forms.TextBox();
			this.t_user = new System.Windows.Forms.TextBox();
			this.t_base = new System.Windows.Forms.TextBox();
			this.t_server = new System.Windows.Forms.TextBox();
			this.l_base = new System.Windows.Forms.Label();
			this.l_pass = new System.Windows.Forms.Label();
			this.l_user = new System.Windows.Forms.Label();
			this.l_server = new System.Windows.Forms.Label();
			this.l_tableTitre = new System.Windows.Forms.Label();
			this.t_table = new System.Windows.Forms.TextBox();
			this.g_command = new System.Windows.Forms.GroupBox();
			this.t_send = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.t_colonne = new System.Windows.Forms.TextBox();
			this.g_connexion.SuspendLayout();
			this.g_command.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(274, 78);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(117, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Se Connecter";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// l_Statut
			// 
			this.l_Statut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.l_Statut.ForeColor = System.Drawing.Color.Red;
			this.l_Statut.Location = new System.Drawing.Point(421, 75);
			this.l_Statut.Name = "l_Statut";
			this.l_Statut.Size = new System.Drawing.Size(160, 29);
			this.l_Statut.TabIndex = 3;
			this.l_Statut.Text = "Vous êtes déconnecté";
			this.l_Statut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// g_connexion
			// 
			this.g_connexion.Controls.Add(this.t_pass);
			this.g_connexion.Controls.Add(this.button1);
			this.g_connexion.Controls.Add(this.t_user);
			this.g_connexion.Controls.Add(this.l_Statut);
			this.g_connexion.Controls.Add(this.t_base);
			this.g_connexion.Controls.Add(this.t_server);
			this.g_connexion.Controls.Add(this.l_base);
			this.g_connexion.Controls.Add(this.l_pass);
			this.g_connexion.Controls.Add(this.l_user);
			this.g_connexion.Controls.Add(this.l_server);
			this.g_connexion.Location = new System.Drawing.Point(12, 12);
			this.g_connexion.Name = "g_connexion";
			this.g_connexion.Size = new System.Drawing.Size(810, 125);
			this.g_connexion.TabIndex = 4;
			this.g_connexion.TabStop = false;
			this.g_connexion.Text = "Connexion";
			// 
			// t_pass
			// 
			this.t_pass.Location = new System.Drawing.Point(666, 25);
			this.t_pass.Name = "t_pass";
			this.t_pass.PasswordChar = '*';
			this.t_pass.Size = new System.Drawing.Size(100, 20);
			this.t_pass.TabIndex = 13;
			// 
			// t_user
			// 
			this.t_user.Location = new System.Drawing.Point(455, 25);
			this.t_user.Name = "t_user";
			this.t_user.Size = new System.Drawing.Size(100, 20);
			this.t_user.TabIndex = 12;
			// 
			// t_base
			// 
			this.t_base.Location = new System.Drawing.Point(252, 25);
			this.t_base.Name = "t_base";
			this.t_base.Size = new System.Drawing.Size(100, 20);
			this.t_base.TabIndex = 11;
			// 
			// t_server
			// 
			this.t_server.Location = new System.Drawing.Point(85, 25);
			this.t_server.Name = "t_server";
			this.t_server.Size = new System.Drawing.Size(100, 20);
			this.t_server.TabIndex = 10;
			// 
			// l_base
			// 
			this.l_base.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.l_base.Location = new System.Drawing.Point(201, 26);
			this.l_base.Name = "l_base";
			this.l_base.Size = new System.Drawing.Size(100, 23);
			this.l_base.TabIndex = 6;
			this.l_base.Text = "Base :";
			// 
			// l_pass
			// 
			this.l_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.l_pass.Location = new System.Drawing.Point(570, 26);
			this.l_pass.Name = "l_pass";
			this.l_pass.Size = new System.Drawing.Size(100, 23);
			this.l_pass.TabIndex = 9;
			this.l_pass.Text = "Mot de passe :";
			// 
			// l_user
			// 
			this.l_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.l_user.Location = new System.Drawing.Point(382, 26);
			this.l_user.Name = "l_user";
			this.l_user.Size = new System.Drawing.Size(100, 23);
			this.l_user.TabIndex = 8;
			this.l_user.Text = "Utilisateur :";
			// 
			// l_server
			// 
			this.l_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.l_server.Location = new System.Drawing.Point(19, 26);
			this.l_server.Name = "l_server";
			this.l_server.Size = new System.Drawing.Size(100, 23);
			this.l_server.TabIndex = 5;
			this.l_server.Text = "Serveur :";
			// 
			// l_tableTitre
			// 
			this.l_tableTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.l_tableTitre.Location = new System.Drawing.Point(6, 38);
			this.l_tableTitre.Name = "l_tableTitre";
			this.l_tableTitre.Size = new System.Drawing.Size(93, 44);
			this.l_tableTitre.TabIndex = 5;
			this.l_tableTitre.Text = "Table : (select)";
			// 
			// t_table
			// 
			this.t_table.Location = new System.Drawing.Point(140, 38);
			this.t_table.Name = "t_table";
			this.t_table.Size = new System.Drawing.Size(100, 20);
			this.t_table.TabIndex = 6;
			// 
			// g_command
			// 
			this.g_command.Controls.Add(this.label1);
			this.g_command.Controls.Add(this.t_colonne);
			this.g_command.Controls.Add(this.t_send);
			this.g_command.Controls.Add(this.l_tableTitre);
			this.g_command.Controls.Add(this.t_table);
			this.g_command.Enabled = false;
			this.g_command.Location = new System.Drawing.Point(12, 154);
			this.g_command.Name = "g_command";
			this.g_command.Size = new System.Drawing.Size(352, 135);
			this.g_command.TabIndex = 7;
			this.g_command.TabStop = false;
			this.g_command.Text = "Commande";
			// 
			// t_send
			// 
			this.t_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.t_send.Location = new System.Drawing.Point(252, 59);
			this.t_send.Name = "t_send";
			this.t_send.Size = new System.Drawing.Size(75, 23);
			this.t_send.TabIndex = 7;
			this.t_send.Text = "Envoyer";
			this.t_send.UseVisualStyleBackColor = true;
			this.t_send.Click += new System.EventHandler(this.b_envoi);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 85);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 36);
			this.label1.TabIndex = 8;
			this.label1.Text = "Colonne à compter : (from)";
			// 
			// t_colonne
			// 
			this.t_colonne.Location = new System.Drawing.Point(140, 85);
			this.t_colonne.Name = "t_colonne";
			this.t_colonne.Size = new System.Drawing.Size(100, 20);
			this.t_colonne.TabIndex = 9;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(834, 388);
			this.Controls.Add(this.g_command);
			this.Controls.Add(this.g_connexion);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Base De Données";
			this.g_connexion.ResumeLayout(false);
			this.g_connexion.PerformLayout();
			this.g_command.ResumeLayout(false);
			this.g_command.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
