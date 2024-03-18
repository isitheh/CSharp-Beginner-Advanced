namespace C_Part2.DbConExercise;

public class SqlConnection: DbConnection
{
    public SqlConnection(string connectionString) 
        : base(connectionString)
    {
    }

    public override void OpenDbConnection(string connectionString)
    {
        if (connectionString == null)
        {
            throw new ArgumentNullException("connectionString");
        }
        Console.WriteLine("Open SQL DB Connection");
    }

    public override void CloseDbConnection(string connectionString)
    {
        if (connectionString == null)
        {
            throw new ArgumentNullException("connectionString");
        }
        Console.WriteLine("Close SQL DB Connection");
    }
}