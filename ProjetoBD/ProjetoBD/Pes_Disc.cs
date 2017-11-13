/*
 * Created by SharpDevelop.
 * User: tgomes
 * Date: 08/11/2017
 * Time: 07:47
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
	/// Description of Pes_Disc.
	/// </summary>
	public partial class Pes_Disc : Form
	{
		public Pes_Disc()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Btn_pesClick(object sender, EventArgs e)
		{
			Conn conn = new Conn();
			
	
			
			string connectionString = "SERVER=localhost;DATABASE=projetobd;UID=nigga;PASSWORD=9886;"; //"Data Source=.;Initial Catalog=pubs;Integrated Security=True";
            string sql = "SELECT * FROM disciplina";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlDataAdapter dataadapter = new MySqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "disciplina_table");
            connection.Close();
           dt_gr_vw_todos.DataSource = ds;
           dt_gr_vw_todos.DataMember = "disciplina_table";
		}
	}
}
