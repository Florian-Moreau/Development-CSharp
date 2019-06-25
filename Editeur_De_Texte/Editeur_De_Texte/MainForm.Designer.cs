/*
 * Crée par SharpDevelop.
 * Utilisateur: flori
 * Date: 22/08/2018
 * Heure: 21:21
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace Editeur_De_Texte
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox t_principal;
		private System.Windows.Forms.ToolStrip ts_1;
		private System.Windows.Forms.ToolStripDropDownButton ts_fichier;
		private System.Windows.Forms.ToolStripMenuItem ts_ouvrir;
		private System.Windows.Forms.ToolStripMenuItem ts_sauvegarder;
		private System.Windows.Forms.ToolStripMenuItem ts_nettoyage;
		
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
			this.t_principal = new System.Windows.Forms.TextBox();
			this.ts_1 = new System.Windows.Forms.ToolStrip();
			this.ts_fichier = new System.Windows.Forms.ToolStripDropDownButton();
			this.ts_ouvrir = new System.Windows.Forms.ToolStripMenuItem();
			this.ts_sauvegarder = new System.Windows.Forms.ToolStripMenuItem();
			this.ts_nettoyage = new System.Windows.Forms.ToolStripMenuItem();
			this.ts_1.SuspendLayout();
			this.SuspendLayout();
			// 
			// t_principal
			// 
			this.t_principal.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.t_principal.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.t_principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.t_principal.Location = new System.Drawing.Point(0, 28);
			this.t_principal.Multiline = true;
			this.t_principal.Name = "t_principal";
			this.t_principal.Size = new System.Drawing.Size(434, 363);
			this.t_principal.TabIndex = 0;
			// 
			// ts_1
			// 
			this.ts_1.BackColor = System.Drawing.SystemColors.Control;
			this.ts_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ts_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.ts_fichier});
			this.ts_1.Location = new System.Drawing.Point(0, 0);
			this.ts_1.MinimumSize = new System.Drawing.Size(0, 0);
			this.ts_1.Name = "ts_1";
			this.ts_1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.ts_1.Size = new System.Drawing.Size(434, 25);
			this.ts_1.TabIndex = 1;
			// 
			// ts_fichier
			// 
			this.ts_fichier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.ts_fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.ts_ouvrir,
			this.ts_sauvegarder,
			this.ts_nettoyage});
			this.ts_fichier.Image = ((System.Drawing.Image)(resources.GetObject("ts_fichier.Image")));
			this.ts_fichier.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ts_fichier.Name = "ts_fichier";
			this.ts_fichier.Size = new System.Drawing.Size(58, 22);
			this.ts_fichier.Text = "Fichier";
			// 
			// ts_ouvrir
			// 
			this.ts_ouvrir.Name = "ts_ouvrir";
			this.ts_ouvrir.Size = new System.Drawing.Size(150, 22);
			this.ts_ouvrir.Text = "Ouvrir";
			this.ts_ouvrir.Click += new System.EventHandler(this.Ts_ouvrirClick);
			// 
			// ts_sauvegarder
			// 
			this.ts_sauvegarder.Name = "ts_sauvegarder";
			this.ts_sauvegarder.Size = new System.Drawing.Size(150, 22);
			this.ts_sauvegarder.Text = "Sauvegarder";
			this.ts_sauvegarder.Click += new System.EventHandler(this.Ts_sauvegarderClick);
			// 
			// ts_nettoyage
			// 
			this.ts_nettoyage.Name = "ts_nettoyage";
			this.ts_nettoyage.Size = new System.Drawing.Size(150, 22);
			this.ts_nettoyage.Text = "Nettoyage";
			this.ts_nettoyage.Click += new System.EventHandler(this.Ts_nettoyageClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 391);
			this.Controls.Add(this.ts_1);
			this.Controls.Add(this.t_principal);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Editeur de texte";
			this.ts_1.ResumeLayout(false);
			this.ts_1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
