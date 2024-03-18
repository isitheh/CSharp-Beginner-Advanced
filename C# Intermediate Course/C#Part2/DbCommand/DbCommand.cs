using System;

public class DbCommand
{
    public DbConnection MDbConnection { get; set; }
    public string CmdInstruction { get; set; }
    public DbCommand(DbConnection mDbConnection, string cmdInstruction)
    {
        if (mDbConnection == null || cmdInstruction == null)
        {
            throw new ArgumentNullException(nameof(mDbConnection));
        }
        this.MDbConnection = mDbConnection;
        this.CmdInstruction = cmdInstruction;
    }

    public void Execute()
    {
        //Open the DB Connection
        MDbConnection.OpenDbConnection(MDbConnection.ConnectionString);
        Console.WriteLine("The DB Connection String is {0} ", MDbConnection.ConnectionString);
        Console.WriteLine("Run the instruction: " + this.CmdInstruction);
        MDbConnection.CloseDbConnection(MDbConnection.ConnectionString);
    }
}
