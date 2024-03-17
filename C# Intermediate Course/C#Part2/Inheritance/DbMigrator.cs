namespace C_Part2.Inheritance;

public class DbMigrator
{
    private readonly Logger _logger;

    //Inject the Logger into the composed class by adding to constructor
    public DbMigrator(Logger logger)
    {
        this._logger = logger;
    }

    public void Migrate()
    {
        _logger.Log("We are migrating.");
    }
}