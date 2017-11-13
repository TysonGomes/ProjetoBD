/*
 * Created by SharpDevelop.
 * User: tgomes
 * Date: 31/10/2017
 * Time: 10:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProjetoBD
{
	partial class Cad_usuario
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
			this.label3 = new System.Windows.Forms.Label();
			this.txt_ra = new System.Windows.Forms.TextBox();
			this.txt_nome = new System.Windows.Forms.TextBox();
			this.txt_email = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_senha = new System.Windows.Forms.TextBox();
			this.txt_cfm_senha = new System.Windows.Forms.TextBox();
			this.btn_cad = new System.Windows.Forms.Button();
			this.grbx_tp_usr = new System.Windows.Forms.GroupBox();
			this.rdbtn_prof = new System.Windows.Forms.RadioButton();
			this.rdbtn_aluno = new System.Windows.Forms.RadioButton();
			this.gp_bx_status = new System.Windows.Forms.GroupBox();
			this.rdbtn_inativo = new System.Windows.Forms.RadioButton();
			this.rdbtn_ativo = new System.Windows.Forms.RadioButton();
			this.btn_alte = new System.Windows.Forms.Button();
			this.grbx_tp_usr.SuspendLayout();
			this.gp_bx_status.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "RA";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nome";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Email";
			// 
			// txt_ra
			// 
			this.txt_ra.Location = new System.Drawing.Point(60, 28);
			this.txt_ra.Name = "txt_ra";
			this.txt_ra.Size = new System.Drawing.Size(164, 20);
			this.txt_ra.TabIndex = 3;
			// 
			// txt_nome
			// 
			this.txt_nome.Location = new System.Drawing.Point(60, 57);
			this.txt_nome.Name = "txt_nome";
			this.txt_nome.Size = new System.Drawing.Size(164, 20);
			this.txt_nome.TabIndex = 4;
			// 
			// txt_email
			// 
			this.txt_email.Location = new System.Drawing.Point(60, 90);
			this.txt_email.Name = "txt_email";
			this.txt_email.Size = new System.Drawing.Size(164, 20);
			this.txt_email.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Senha";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(195, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Confirma senha";
			// 
			// txt_senha
			// 
			this.txt_senha.Location = new System.Drawing.Point(12, 154);
			this.txt_senha.Name = "txt_senha";
			this.txt_senha.PasswordChar = '*';
			this.txt_senha.Size = new System.Drawing.Size(164, 20);
			this.txt_senha.TabIndex = 10;
			// 
			// txt_cfm_senha
			// 
			this.txt_cfm_senha.Location = new System.Drawing.Point(195, 154);
			this.txt_cfm_senha.Name = "txt_cfm_senha";
			this.txt_cfm_senha.PasswordChar = '*';
			this.txt_cfm_senha.Size = new System.Drawing.Size(175, 20);
			this.txt_cfm_senha.TabIndex = 11;
			// 
			// btn_cad
			// 
			this.btn_cad.Location = new System.Drawing.Point(12, 205);
			this.btn_cad.Name = "btn_cad";
			this.btn_cad.Size = new System.Drawing.Size(75, 23);
			this.btn_cad.TabIndex = 12;
			this.btn_cad.Text = "Cadastrar";
			this.btn_cad.UseVisualStyleBackColor = true;
			this.btn_cad.Click += new System.EventHandler(this.Btn_cadClick);
			// 
			// grbx_tp_usr
			// 
			this.grbx_tp_usr.Controls.Add(this.rdbtn_prof);
			this.grbx_tp_usr.Controls.Add(this.rdbtn_aluno);
			this.grbx_tp_usr.Location = new System.Drawing.Point(253, 12);
			this.grbx_tp_usr.Name = "grbx_tp_usr";
			this.grbx_tp_usr.Size = new System.Drawing.Size(222, 83);
			this.grbx_tp_usr.TabIndex = 13;
			this.grbx_tp_usr.TabStop = false;
			this.grbx_tp_usr.Text = "Tipo Usuario";
			this.grbx_tp_usr.Enter += new System.EventHandler(this.GroupBox1Enter);
			// 
			// rdbtn_prof
			// 
			this.rdbtn_prof.Location = new System.Drawing.Point(13, 48);
			this.rdbtn_prof.Name = "rdbtn_prof";
			this.rdbtn_prof.Size = new System.Drawing.Size(104, 24);
			this.rdbtn_prof.TabIndex = 1;
			this.rdbtn_prof.TabStop = true;
			this.rdbtn_prof.Text = "professor";
			this.rdbtn_prof.UseVisualStyleBackColor = true;
			// 
			// rdbtn_aluno
			// 
			this.rdbtn_aluno.Location = new System.Drawing.Point(13, 19);
			this.rdbtn_aluno.Name = "rdbtn_aluno";
			this.rdbtn_aluno.Size = new System.Drawing.Size(104, 24);
			this.rdbtn_aluno.TabIndex = 0;
			this.rdbtn_aluno.TabStop = true;
			this.rdbtn_aluno.Text = "Aluno";
			this.rdbtn_aluno.UseVisualStyleBackColor = true;
			// 
			// gp_bx_status
			// 
			this.gp_bx_status.Controls.Add(this.rdbtn_inativo);
			this.gp_bx_status.Controls.Add(this.rdbtn_ativo);
			this.gp_bx_status.Location = new System.Drawing.Point(195, 207);
			this.gp_bx_status.Name = "gp_bx_status";
			this.gp_bx_status.Size = new System.Drawing.Size(263, 51);
			this.gp_bx_status.TabIndex = 14;
			this.gp_bx_status.TabStop = false;
			this.gp_bx_status.Text = "Status";
			this.gp_bx_status.Visible = false;
			// 
			// rdbtn_inativo
			// 
			this.rdbtn_inativo.Location = new System.Drawing.Point(127, 20);
			this.rdbtn_inativo.Name = "rdbtn_inativo";
			this.rdbtn_inativo.Size = new System.Drawing.Size(104, 24);
			this.rdbtn_inativo.TabIndex = 1;
			this.rdbtn_inativo.TabStop = true;
			this.rdbtn_inativo.Text = "inativo";
			this.rdbtn_inativo.UseVisualStyleBackColor = true;
			// 
			// rdbtn_ativo
			// 
			this.rdbtn_ativo.Location = new System.Drawing.Point(16, 19);
			this.rdbtn_ativo.Name = "rdbtn_ativo";
			this.rdbtn_ativo.Size = new System.Drawing.Size(104, 24);
			this.rdbtn_ativo.TabIndex = 0;
			this.rdbtn_ativo.TabStop = true;
			this.rdbtn_ativo.Text = "ativo";
			this.rdbtn_ativo.UseVisualStyleBackColor = true;
			// 
			// btn_alte
			// 
			this.btn_alte.Location = new System.Drawing.Point(13, 235);
			this.btn_alte.Name = "btn_alte";
			this.btn_alte.Size = new System.Drawing.Size(75, 23);
			this.btn_alte.TabIndex = 15;
			this.btn_alte.Text = "Alterar";
			this.btn_alte.UseVisualStyleBackColor = true;
			this.btn_alte.Visible = false;
			this.btn_alte.Click += new System.EventHandler(this.Btn_alteClick);
			// 
			// Cad_usuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(496, 284);
			this.Controls.Add(this.btn_alte);
			this.Controls.Add(this.gp_bx_status);
			this.Controls.Add(this.grbx_tp_usr);
			this.Controls.Add(this.btn_cad);
			this.Controls.Add(this.txt_cfm_senha);
			this.Controls.Add(this.txt_senha);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt_email);
			this.Controls.Add(this.txt_nome);
			this.Controls.Add(this.txt_ra);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Cad_usuario";
			this.Text = "Cad_usuario";
			this.Load += new System.EventHandler(this.Cad_usuarioLoad);
			this.grbx_tp_usr.ResumeLayout(false);
			this.gp_bx_status.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btn_alte;
		private System.Windows.Forms.RadioButton rdbtn_ativo;
		private System.Windows.Forms.RadioButton rdbtn_inativo;
		private System.Windows.Forms.GroupBox gp_bx_status;
		private System.Windows.Forms.RadioButton rdbtn_aluno;
		private System.Windows.Forms.RadioButton rdbtn_prof;
		private System.Windows.Forms.GroupBox grbx_tp_usr;
		private System.Windows.Forms.Button btn_cad;
		private System.Windows.Forms.TextBox txt_cfm_senha;
		private System.Windows.Forms.TextBox txt_senha;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_email;
		private System.Windows.Forms.TextBox txt_nome;
		private System.Windows.Forms.TextBox txt_ra;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
