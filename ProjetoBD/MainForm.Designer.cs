/*
 * Created by SharpDevelop.
 * User: tgomes
 * Date: 30/10/2017
 * Time: 15:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProjetoBD
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_senha = new System.Windows.Forms.TextBox();
			this.btn_login = new System.Windows.Forms.Button();
			this.txt_usuario = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(46, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Login";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(46, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Password";
			// 
			// txt_senha
			// 
			this.txt_senha.Location = new System.Drawing.Point(117, 85);
			this.txt_senha.Name = "txt_senha";
			this.txt_senha.PasswordChar = '*';
			this.txt_senha.Size = new System.Drawing.Size(100, 20);
			this.txt_senha.TabIndex = 2;
			this.txt_senha.TextChanged += new System.EventHandler(this.Txt_senhaTextChanged);
			// 
			// btn_login
			// 
			this.btn_login.Location = new System.Drawing.Point(46, 169);
			this.btn_login.Name = "btn_login";
			this.btn_login.Size = new System.Drawing.Size(75, 23);
			this.btn_login.TabIndex = 3;
			this.btn_login.Text = "Acessar";
			this.btn_login.UseVisualStyleBackColor = true;
			this.btn_login.Click += new System.EventHandler(this.Btn_loginClick);
			// 
			// txt_usuario
			// 
			this.txt_usuario.Location = new System.Drawing.Point(117, 40);
			this.txt_usuario.Name = "txt_usuario";
			this.txt_usuario.Size = new System.Drawing.Size(100, 20);
			this.txt_usuario.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(336, 247);
			this.Controls.Add(this.txt_usuario);
			this.Controls.Add(this.btn_login);
			this.Controls.Add(this.txt_senha);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "ProjetoBD";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btn_login;
		private System.Windows.Forms.TextBox txt_senha;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_usuario;
	}
}
