/*
 * Crée par SharpDevelop.
 * Créateur : Florian Moreau
 * Date: 8/15/2018
 */
namespace Calculatrice
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox t_nombreA;
		private System.Windows.Forms.TextBox t_nombreB;
		private System.Windows.Forms.TextBox t_resultat;
		private System.Windows.Forms.Button b_Addition;
		private System.Windows.Forms.Button b_Soustraction;
		private System.Windows.Forms.Button b_Multiplication;
		private System.Windows.Forms.Button b_Division;
		private System.Windows.Forms.Button b_Pourcentage;
		
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
			this.t_nombreA = new System.Windows.Forms.TextBox();
			this.t_nombreB = new System.Windows.Forms.TextBox();
			this.t_resultat = new System.Windows.Forms.TextBox();
			this.b_Addition = new System.Windows.Forms.Button();
			this.b_Soustraction = new System.Windows.Forms.Button();
			this.b_Multiplication = new System.Windows.Forms.Button();
			this.b_Division = new System.Windows.Forms.Button();
			this.b_Pourcentage = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// t_nombreA
			// 
			this.t_nombreA.BackColor = System.Drawing.SystemColors.Info;
			this.t_nombreA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.t_nombreA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.t_nombreA.Location = new System.Drawing.Point(43, 32);
			this.t_nombreA.Name = "t_nombreA";
			this.t_nombreA.Size = new System.Drawing.Size(195, 38);
			this.t_nombreA.TabIndex = 0;
			this.t_nombreA.Text = "0";
			this.t_nombreA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// t_nombreB
			// 
			this.t_nombreB.BackColor = System.Drawing.SystemColors.Info;
			this.t_nombreB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.t_nombreB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.t_nombreB.Location = new System.Drawing.Point(43, 118);
			this.t_nombreB.Name = "t_nombreB";
			this.t_nombreB.Size = new System.Drawing.Size(195, 38);
			this.t_nombreB.TabIndex = 1;
			this.t_nombreB.Text = "0";
			this.t_nombreB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// t_resultat
			// 
			this.t_resultat.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.t_resultat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.t_resultat.Enabled = false;
			this.t_resultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.t_resultat.ForeColor = System.Drawing.Color.DarkGreen;
			this.t_resultat.HideSelection = false;
			this.t_resultat.Location = new System.Drawing.Point(43, 207);
			this.t_resultat.Name = "t_resultat";
			this.t_resultat.ReadOnly = true;
			this.t_resultat.Size = new System.Drawing.Size(195, 44);
			this.t_resultat.TabIndex = 2;
			this.t_resultat.Text = "0";
			this.t_resultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// b_Addition
			// 
			this.b_Addition.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.b_Addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.b_Addition.Location = new System.Drawing.Point(52, 78);
			this.b_Addition.Name = "b_Addition";
			this.b_Addition.Size = new System.Drawing.Size(31, 34);
			this.b_Addition.TabIndex = 3;
			this.b_Addition.Text = "+";
			this.b_Addition.UseVisualStyleBackColor = false;
			this.b_Addition.Click += new System.EventHandler(this.b_Add);
			// 
			// b_Soustraction
			// 
			this.b_Soustraction.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.b_Soustraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.b_Soustraction.Location = new System.Drawing.Point(89, 78);
			this.b_Soustraction.Name = "b_Soustraction";
			this.b_Soustraction.Size = new System.Drawing.Size(31, 34);
			this.b_Soustraction.TabIndex = 4;
			this.b_Soustraction.Text = "-";
			this.b_Soustraction.UseVisualStyleBackColor = false;
			this.b_Soustraction.Click += new System.EventHandler(this.b_Sub);
			// 
			// b_Multiplication
			// 
			this.b_Multiplication.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.b_Multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.b_Multiplication.Location = new System.Drawing.Point(126, 78);
			this.b_Multiplication.Name = "b_Multiplication";
			this.b_Multiplication.Size = new System.Drawing.Size(31, 34);
			this.b_Multiplication.TabIndex = 5;
			this.b_Multiplication.Text = "*";
			this.b_Multiplication.UseVisualStyleBackColor = false;
			this.b_Multiplication.Click += new System.EventHandler(this.b_Mult);
			// 
			// b_Division
			// 
			this.b_Division.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.b_Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.b_Division.Location = new System.Drawing.Point(163, 78);
			this.b_Division.Name = "b_Division";
			this.b_Division.Size = new System.Drawing.Size(31, 34);
			this.b_Division.TabIndex = 6;
			this.b_Division.Text = "/";
			this.b_Division.UseVisualStyleBackColor = false;
			this.b_Division.Click += new System.EventHandler(this.b_Div);
			// 
			// b_Pourcentage
			// 
			this.b_Pourcentage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.b_Pourcentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.b_Pourcentage.Location = new System.Drawing.Point(200, 78);
			this.b_Pourcentage.Name = "b_Pourcentage";
			this.b_Pourcentage.Size = new System.Drawing.Size(31, 34);
			this.b_Pourcentage.TabIndex = 7;
			this.b_Pourcentage.Text = "%";
			this.b_Pourcentage.UseVisualStyleBackColor = false;
			this.b_Pourcentage.Click += new System.EventHandler(this.b_Pour);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(291, 345);
			this.Controls.Add(this.b_Pourcentage);
			this.Controls.Add(this.b_Division);
			this.Controls.Add(this.b_Multiplication);
			this.Controls.Add(this.b_Soustraction);
			this.Controls.Add(this.b_Addition);
			this.Controls.Add(this.t_resultat);
			this.Controls.Add(this.t_nombreB);
			this.Controls.Add(this.t_nombreA);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Calculatrice";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
