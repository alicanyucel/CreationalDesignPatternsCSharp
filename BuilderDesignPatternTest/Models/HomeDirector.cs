namespace BuilderDesignPatternTest.Models;

internal class HomeDirector
{
    public Home BuilderHome()
    {
        return new HomeBuilder()
        .SetFoundation("Güçlendirilmiş Beton Temel")
        .SetWalls("Tuğla Duvarlar")
        .SetRoof("Kiremit Çatı")
        .SetInterior("Modern İç Mekan")
        .Build();
    }
}