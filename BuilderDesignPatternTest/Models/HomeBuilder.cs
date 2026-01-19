namespace BuilderDesignPatternTest.Models;

internal  class HomeBuilder
{
    private Home _home;
    public HomeBuilder()
    {
        _home = new Home();
    }
    public HomeBuilder SetFoundation(string foundation)
    {
        _home.Foundation = foundation;
        return this;
    }
    public HomeBuilder SetWalls(string walls)
    {
        _home.Walls = walls;
        return this;
    }
    public HomeBuilder SetRoof(string roof)
    {
        _home.Roof = roof;
        return this;
    }
    public HomeBuilder SetInterior(string interior)
    {
        _home.Interior = interior;
        return this;
    }
    public Home Build()
    {
        return _home;
    }
}
