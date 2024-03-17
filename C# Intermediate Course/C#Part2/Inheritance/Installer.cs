namespace C_Part2.Inheritance;

public class Installer
{
    private readonly Logger _logger;

    //Inject the Logger into the composed class by adding to constructor
    public Installer(Logger logger)
    {
        this._logger = logger;
    }

    public void Install()
    {
        _logger.Log("We are installing.");
    }
}