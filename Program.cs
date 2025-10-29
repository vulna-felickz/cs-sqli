using System.Data.SqlClient;

Console.WriteLine("Please enter user ID:");
var userID = Console.ReadLine();
GetUserData(userID);
Console.WriteLine("Getting user data...DONE");
    
static void GetUserData(string userId)
{
    string connectionString = "YourConnectionString";
    string query = "SELECT * FROM Users WHERE UserId = '" + userId + "'";

    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        SqlCommand command = new SqlCommand(query, connection);
        connection.Open();
        SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine($"{reader["UserName"]}, {reader["Email"]}");
        }
    }
}
