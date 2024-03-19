using C_Part2.Inheritance;

namespace C_Part2.Extensibility;

public class DbMigratorClass
{
    private readonly ILogger _logger;

    //Dependency injection. DbMigratorClass depends on the ILogger interface.
    public DbMigratorClass(ILogger logger)
    {
        _logger = logger;
    }

    public void Migrate()
    {
        //Details of migrating the database.
        //Want to log some info as database migration is happening.
        _logger.LogInfo("Migration started at " + DateTime.Now);
        _logger.LogInfo("Migration finished at " + DateTime.Now);
    }
}