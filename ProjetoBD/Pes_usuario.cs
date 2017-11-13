/*
 * Created by SharpDevelop.
 * User: tgomes
 * Date: 31/10/2017
 * Time: 16:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ProjetoBD
{
	/// <summary>
	/// Description of Pes_usuario.
	/// </summary>
	public partial class Pes_usuario : Form
	{
		public Pes_usuario()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Btn_pesquisaClick(object sender, EventArgs e)
		{
			
			Conn conn = new Conn();
			
	
			
			string connectionString = "SERVER=localhost;DATABASE=projetobd;UID=nigga;PASSWORD=9886;"; //"Data Source=.;Initial Catalog=pubs;Integrated Security=True";
            string sql = "SELECT * FROM usuario";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlDataAdapter dataadapter = new MySqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "usuarios_table");
            connection.Close();
           dt_gr_vw_todos.DataSource = ds;
           dt_gr_vw_todos.DataMember = "usuarios_table";
			
			
			//int dtuser;
			
			//Conn conn = new Conn();
			//sql="select * from usuario;";
			//dt_gr_vw_todos.DataSource = BindingSource;
           // conn.GetData(sql);
			//dtuser=conn.Pes_todos(sql);
			//dt_gr_vw_todos.DataSource=conn.Pes_todos(sql);
			
			
			//lsbox_td_usr.Items.Add(Usuario.id);
			//lsbox_td_usr.Items.Add(Usuario.ra);
			//lsbox_td_usr.Items.Add(Usuario.nome);
			//lsbox_td_usr.Items.Add(Usuario.email);
			//lsbox_td_usr.Items.Add(Usuario.tipo);
			//lsbox_td_usr.Items.Add(Usuario.status);
			
		}
	

 //private void DataGridView1_MouseClick(object sender, MouseEventArgs e) 
		
	//void DataGridView1CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		 //void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		
		/* private void Dt_gr_vw_todosCellMouseClick(Object sender, DataGridViewCellMouseEventArgs e)
		 {
			Conn conn = new Conn();
			int linha = 0;
            string sql;
            string id;
            
            
            linha = dt_gr_vw_todos.CurrentRow.Index;
            id = dt_gr_vw_todos.Rows[linha].Cells[0].Value.ToString();
            sql= "SELECT * FROM usuario where id="+id+";";
            conn.pesquisa(sql);
            Usuario.pes="ativo";
            Cad_usuario CA =new Cad_usuario();
            CA.ShowDialog();
		}*/
		
		
		/*private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e){
			Conn conn = new Conn();
			int linha = 0;
            string sql;
            string id;
            
            
            linha = Convert.ToInt16(DataGridView1.CurrentRow.Index);
            id = DataGridView1.Rows[linha].Cells[0].Value.ToString();
            sql= "SELECT * FROM usuario where id="+id+";";
            conn.pesquisa(sql);
            Usuario.pes="ativo";
            Cad_usuario CA =new Cad_usuario();
		   
            
             
	}*/
		
		//private void DataGridView1_CellMouseDoubleClick(Object sender, DataGridViewCellMouseEventArgs e)
		//private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e) {
		//private void dt_gr_vw_todos_MouseClick(object sender, MouseEventArgs e)
		private void  dt_gr_vw_todos__CellMouseDoubleClick(Object sender, DataGridViewCellMouseEventArgs e)
		{
			
			//var dataIndexNo =  dt_gr_vw_todos.Rows[e.RowIndex].Index.ToString();
            //string cellValue = dt_gr_vw_todos.Rows[e.RowIndex].Cells[1].Value.ToString();

          //  MessageBox.Show("The row index = " + dataIndexNo.ToString() + " and the row data in second column is: "
              //  + cellValue.ToString());
			//
			
			
			Conn conn = new Conn();
			int linha = 0;
            string sql;
            string id;
            
            
            linha = dt_gr_vw_todos.CurrentRow.Index;
            id = dt_gr_vw_todos.Rows[linha].Cells[0].Value.ToString();
            sql= "SELECT * FROM usuario where id="+id+";";
            conn.pesquisa(sql);
            Usuario.pes="atv";
            Cad_usuario CA =new Cad_usuario();
            CA.ShowDialog();
		}
		
		/*void Btn_testeClick(object sender, EventArgs e)
		{
			Conn conn = new Conn();
			int linha = 0;
            string sql;
            string id;
            
            
            linha = dt_gr_vw_todos.CurrentRow.Index;
            id = dt_gr_vw_todos.Rows[linha].Cells[0].Value.ToString();
            sql= "SELECT * FROM usuario where id="+id+";";
            conn.pesquisa(sql);
            Usuario.pes="atv";
            Cad_usuario CA =new Cad_usuario();
            CA.ShowDialog();
		}*/
		private void Dt_gr_vw_todosCellMouseDown(Object sender, DataGridViewCellMouseEventArgs e)
		//private void Dt_gr_vw_todosCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			Conn conn = new Conn();
			int linha = 0;
            string sql;
            string id;
            
            
            linha = dt_gr_vw_todos.CurrentRow.Index;
            id = dt_gr_vw_todos.Rows[linha].Cells[0].Value.ToString();
            sql= "SELECT * FROM usuario where id="+id+";";
            conn.pesquisa(sql);
            Usuario.pes="atv";
            Cad_usuario CA =new Cad_usuario();
            CA.ShowDialog();
		}
		
		void Dt_gr_vw_todosCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			Conn conn = new Conn();
			int linha = 0;
            string sql;
            string id;
            
            
            linha = dt_gr_vw_todos.CurrentRow.Index;
            id = dt_gr_vw_todos.Rows[linha].Cells[0].Value.ToString();
            sql= "SELECT * FROM usuario where id="+id+";";
            conn.pesquisa(sql);
            Usuario.pes="atv";
            Cad_usuario CA =new Cad_usuario();
            CA.ShowDialog();
		}
	}}
