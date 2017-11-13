/*
 * Created by SharpDevelop.
 * User: tgomes
 * Date: 31/10/2017
 * Time: 10:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoBD
{
	/// <summary>
	/// Description of Cad_usuario.
	/// </summary>
	public partial class Cad_usuario : Form
	{
		public Cad_usuario()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void GroupBox1Enter(object sender, EventArgs e)
		{
			
		}
		
		void Btn_cadClick(object sender, EventArgs e){
		string tipo="";
		string sql;
		
		Conn conn = new Conn();
		
		
			if (txt_senha.Text!=txt_cfm_senha.Text){
			
				MessageBox.Show("Senha Digitas são diferentes","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				txt_senha.Clear();
				txt_cfm_senha.Clear();
				txt_senha.Focus();
			
			}
			
		
			if (rdbtn_aluno.Checked){
			   tipo="aluno";
			}
			if (rdbtn_prof.Checked){
				tipo="professor";
				
			}
			
			sql="insert into usuario (ra,nome,email,tipo,status,senha) values ('"+txt_ra.Text+"' ,'"+txt_nome.Text+"' ,'"+txt_email.Text+"','"+tipo+"','ativo','"+txt_senha.Text+"');";
			
			if (conn.Insert(sql)){
			
			MessageBox.Show("Usuario cadastro com sucesso","Sucesso!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			txt_ra.Clear();
			txt_nome.Clear();
			txt_email.Clear();
			tipo="";
			txt_senha.Clear();
			txt_cfm_senha.Clear();
			txt_ra.Focus();
			}
			else {
				MessageBox.Show("Deu errado");
				txt_ra.Focus();
			}
			
			}
			
			
			
		
		void Cad_usuarioLoad(object sender, EventArgs e)
		{
			if(Usuario.pes=="atv"){
				
		    txt_ra.Text= Usuario.ra;
			txt_nome.Text=Usuario.nome;
			txt_email.Text=Usuario.email;
			btn_alte.Visible=true;
			gp_bx_status.Visible=true;	
			btn_cad.Visible=false;	
				
			}
		}
		
		void Btn_alteClick(object sender, EventArgs e)
		{
			Conn conn = new Conn();
			
			
			string sql;
			string status="ativo";
			string tipo="";
			
			//sql ="update usuario set ra="+txt_ra.Text+",nome="+txt_nome.Text+",email="+txt_email.Text+",ra="+txt_ra.Text+",tipo="+tipo+",status="+status+",senha="+txt_senha.Text+" where id="+Usuario.id+";"; 
			if (txt_senha.Text!=txt_cfm_senha.Text){
			
				MessageBox.Show("Senha Digitas são diferentes","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				txt_senha.Clear();
				txt_cfm_senha.Clear();
				txt_senha.Focus();
			
			}
			
			if (rdbtn_aluno.Checked){
			   tipo="aluno";
			}
			if (rdbtn_prof.Checked){
				tipo="professor";
				
			}
				
			if (rdbtn_ativo.Checked){
				status="ativo";
 			 }
			if (rdbtn_inativo.Checked){
				status="inativo";
 			 }
			sql ="update usuario set ra="+txt_ra.Text+",nome='"+txt_nome.Text+"',email='"+txt_email.Text+"',tipo='"+tipo+"',status='"+status+"',senha="+txt_senha.Text+" where id="+Usuario.id+";"; 
			
			//MessageBox.Show(sql);
			
			
			if (conn.Update(sql)){
		MessageBox.Show("Usuario alterado com sucesso","Sucesso!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			txt_ra.Clear();
			txt_nome.Clear();
			txt_email.Clear();
			tipo="";
			txt_senha.Clear();
			txt_cfm_senha.Clear();
			txt_ra.Focus();
			this.Hide();
			
			
			}
			else {
				MessageBox.Show("Deu errado");
				txt_ra.Focus();
			}
		
		
		}
	}}
	

