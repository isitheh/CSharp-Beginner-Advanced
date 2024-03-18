using System;

public abstract class DbConnection
{
    public string ConnectionString { get; set; }
    public TimeSpan Timeout { get; set; }
	public DbConnection(string connectionString)
    {
        ConnectionString = connectionString;
    }

    public abstract void OpenDbConnection(string connectionString);
    public abstract void CloseDbConnection(string connectionString);
}