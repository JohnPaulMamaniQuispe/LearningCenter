namespace Infraestructura;

public class TutorialOracleInfraestructure : ITutorialInfraestructure
{
    public IEnumerable<string> GetAll()
    {
        //throw new NotImplementedException();
        return new string[] { "value1  Infraestructure Oracle", "value2 Infraestructure Oracle" };
    }
}