/*
 * Crée par SharpDevelop.
 * Créateur : Florian Moreau
 * Date: 8/16/2018
 */
namespace Pong
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox player2;
		private System.Windows.Forms.PictureBox ball;
		private System.Windows.Forms.PictureBox player1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label p2Score;
		private System.Windows.Forms.Label p1Score;
		
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
			this.components = new System.ComponentModel.Container();
			this.player2 = new System.Windows.Forms.PictureBox();
			this.ball = new System.Windows.Forms.PictureBox();
			this.player1 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.p2Score = new System.Windows.Forms.Label();
			this.p1Score = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
			this.SuspendLayout();
			// 
			// player2
			// 
			this.player2.BackColor = System.Drawing.Color.Red;
			this.player2.Location = new System.Drawing.Point(324, 12);
			this.player2.Name = "player2";
			this.player2.Size = new System.Drawing.Size(150, 25);
			this.player2.TabIndex = 0;
			this.player2.TabStop = false;
			// 
			// ball
			// 
			this.ball.BackColor = System.Drawing.Color.Black;
			this.ball.Location = new System.Drawing.Point(390, 201);
			this.ball.Name = "ball";
			this.ball.Size = new System.Drawing.Size(30, 30);
			this.ball.TabIndex = 1;
			this.ball.TabStop = false;
			// 
			// player1
			// 
			this.player1.BackColor = System.Drawing.Color.DodgerBlue;
			this.player1.Location = new System.Drawing.Point(324, 468);
			this.player1.Name = "player1";
			this.player1.Size = new System.Drawing.Size(150, 25);
			this.player1.TabIndex = 2;
			this.player1.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// p2Score
			// 
			this.p2Score.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.p2Score.Location = new System.Drawing.Point(12, 14);
			this.p2Score.Name = "p2Score";
			this.p2Score.Size = new System.Drawing.Size(97, 49);
			this.p2Score.TabIndex = 3;
			this.p2Score.Text = "0";
			// 
			// p1Score
			// 
			this.p1Score.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.p1Score.Location = new System.Drawing.Point(12, 444);
			this.p1Score.Name = "p1Score";
			this.p1Score.Size = new System.Drawing.Size(118, 49);
			this.p1Score.TabIndex = 4;
			this.p1Score.Text = "0";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(877, 505);
			this.Controls.Add(this.p1Score);
			this.Controls.Add(this.p2Score);
			this.Controls.Add(this.player1);
			this.Controls.Add(this.ball);
			this.Controls.Add(this.player2);
			this.Name = "MainForm";
			this.Text = "Pong";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyUp);
			((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
