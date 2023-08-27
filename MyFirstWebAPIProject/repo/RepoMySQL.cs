using MySql.Data.MySqlClient;

public class RepoMySQL : RepoInterface{

    private string connectionString = string.Concat("server=localhost;user=root;password=teste123;database=C_SHARP_TEST;");
    private MySqlConnection connection;  

    public RepoMySQL(){
        connection = new MySqlConnection(connectionString);
    }

    public string returnItem(int index){
        string item = "";
        try{
            connection.Open();
            string sqlQuery = string.Concat("SELECT name FROM items WHERE id = ", index, ";");
            MySqlCommand command = new MySqlCommand(sqlQuery, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read()){
                item = reader.GetString(0);
            }
        }
        catch{
            item = "Item -1";
        }
        finally{
            connection.Close();
        }
        if(item.Equals("")){
            item = "Item -1";
        }
        return item;
    
    }

}