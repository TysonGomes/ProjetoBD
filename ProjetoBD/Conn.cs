using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ProjetoBD
{
    class Conn
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public Conn()
        {
            Initialize();
        }

        //Initialize values
        public void Initialize()
        {
            server = "localhost";
            database = "projetobd";
            uid = "nigga";
            password = "9886";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
               
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Não foi possível se conectar no banco de dados.  Contate o administrador");
                        break;

                    case 1045:
                        MessageBox.Show("Usuário e/ou senha inválido, por favor tente novamente");
                        break;
                }
                return false;
            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement

        public bool Insert(String SQL)
        {

          
          	string query = SQL;
          	try {
            //open connection 
            if (this.OpenConnection() == true)
            {
               
                //create command and assign the query and connection from the constructor 
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command 
                cmd.ExecuteNonQuery();

                //close connection 
                this.CloseConnection();
                

            }
            return true;}
          	
            catch(MySqlException ex) {
                MessageBox.Show(ex.Message);
                return false;
                
            }}
        
          	
          	
            
        public bool Login(string SQL)
{
   string query = SQL;
    

    
    MySqlCommand cmd = new MySqlCommand(query, connection);
    cmd.CommandType = CommandType.Text;

    this.OpenConnection();
    MySqlDataReader dr= cmd.ExecuteReader();
if (dr.HasRows)
                {
                    //usuario existe
                    return true;
                }
                else
                {
                    //usuario nao existe
                    return false;
                }
            }
        public void pesquisa(string SQL)
		{
			//Conn conn new Conn();
       
			string query= SQL;
	
    
    MySqlCommand cmd = new MySqlCommand(query, connection);
    cmd.CommandType = CommandType.Text;

    this.OpenConnection();
    MySqlDataReader dr= cmd.ExecuteReader();
    while (dr.Read()) {
    	
    	//log= Convert.ToInt32(dr["log_id"].ToString());
    	//MessageBox.Show( dr["log_id"].ToString()+ dr["userlogin"].ToString()+ dr["pass"].ToString());
    	
    	
    //usr.log_id
    Usuario.id=int.Parse(dr["id"].ToString());
    Usuario.ra=	dr["ra"].ToString();
    Usuario.nome=dr["nome"].ToString();
	Usuario.email= dr["email"].ToString();	
	Usuario.tipo= dr["tipo"].ToString();
	Usuario.status=dr["status"].ToString();
	Usuario.senha=	dr["senha"].ToString();
		
    	}
    
    
      this.CloseConnection();
        
      
		}
        
        
        
        public bool Update(String SQL)
        {

          
          	string query = SQL;
          	try {
            //open connection 
            if (this.OpenConnection() == true)
            {
               
                //create command and assign the query and connection from the constructor 
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command 
                cmd.ExecuteNonQuery();

                //close connection 
                this.CloseConnection();
                

            }
            return true;}
          	
            catch(MySqlException ex) {
                MessageBox.Show(ex.Message);
                return false;
                
            }}
        
        
        
        
        
        
        
        
        
        
        
        
        
        
      /* private void GetData(string query)
{
    try
    {
        // Specify a connection string. Replace the given value with a 
        // valid connection string for a Northwind SQL Server sample
        // database accessible to your system.
       // String connectionString =
       //     "Integrated Security=SSPI;Persist Security Info=False;" +
       //     "Initial Catalog=Northwind;Data Source=localhost";
         this.OpenConnection();
        // Create a new data adapter based on the specified query.
        MySqlDataAdapter  da = new MySqlDataAdapter(query, connection);

        // Create a command builder to generate SQL update, insert, and
        // delete commands based on selectCommand. These are used to
        // update the database.
        //MySqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

        // Populate a new data table and bind it to the BindingSource.
        DataTable tbusr = new DataTable();
        tbusr.Locale = System.Globalization.CultureInfo.InvariantCulture;
        da.Fill(tbusr);
        BindingSource bs = new BindingSource();
        bs.DataSource=tbusr;

        // Resize the DataGridView columns to fit the newly loaded content.
        ds.AutoResizeColumns( 
            DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
    }
    catch (MySqlException)
    {
        MessageBox.Show("To run this example, replace the value of the " +
            "connectionString variable with a connection string that is " +
            "valid for your system.");
    }
}
        
       /*  public int Pes_todos(string SQL)
		{
			//Conn conn new Conn();
       
			string query= SQL;
	
    
    MySqlCommand cmd = new MySqlCommand(query, connection);
    cmd.CommandType = CommandType.Text;

    this.OpenConnection();
   // MySqlDataReader dr= cmd.ExecuteReader();
    MySqlDataAdapter da = new  MySqlDataAdapter(cmd);
    
    DataTable dtusr =new DataTable();
    //da.Fill(dtusr);
   return da.Fill(dtusr);
    
    
    /*while (dr.Read()) {
    	
    	
    Usuario.id=int.Parse(dr["id"].ToString());
    Usuario.ra=	dr["ra"].ToString();
    Usuario.nome=dr["nome"].ToString();
	Usuario.email= dr["email"].ToString();	
	Usuario.tipo= dr["tipo"].ToString();
	Usuario.status=dr["status"].ToString();
	Usuario.senha=	dr["senha"].ToString();*/
		
    	
    	
    	
    	
    	
    }}
        
        
        
            /*catch (Exception)
            {
                return false;
                throw;
            }*/
    
   /* public void pesquisa(String Sql)
		{
			//Conn conn new Conn();
			string query = SQL;
    
	Usuario usr new Usuario();
    
    MySqlCommand cmd = new MySqlCommand(query, connection);
    cmd.CommandType = CommandType.Text;

    conn.OpenConnection();
    MySqlDataReader dr= cmd.ExecuteReader();
    
    usr.log_id= Convert.ToInt32(dr["log_id"].ToString());
	usr.userlogin=dr["Nome"].ToString();		
	usr.pass= Convert.ToInt32(dr["pass"].ToString());	
	return usr;
	
		}*/
    
    


        
        
        
        
        
        
        
            
          /*  public void Login(String SQL){
            
{
 
 string query = SQL;



this.OpenConnection();

MySqlCommand cmd = new MySqlCommand(query, connection);

var resultado = cmd.ExecuteScalar();

      if (resultado is DBNull) // Se não retornar nada é  nao loga 
            {
      	MessageBox.Show("usuario errado");
		//return false; 
	    }
	    else
	    {
	    	MessageBox.Show("Logado");
		//return true; 
            }
        	}}}}*/
