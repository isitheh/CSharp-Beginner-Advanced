namespace C_Part2.DbConExercise;

public class OracleConnection: DbConnection
{
    public OracleConnection(string connectionString) 
        : base(connectionString)
    {
    }

    public override void OpenDbConnection(string connectionString)
    {
        if (connectionString == null)
        {
            throw new ArgumentNullException("connectionString");
        }
        Console.WriteLine("Open Oracle DB Connection");
    }

    public override void CloseDbConnection(string connectionString)
    {
        if (connectionString == null)
        {
            throw new ArgumentNullException("connectionString");
        }
        Console.WriteLine("Close Oracle DB Connection");
    }
}