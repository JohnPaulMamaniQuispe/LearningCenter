namespace Infraestructura;

public class TutorialSQLInfraestructure : ITutorialInfraestructure
{
    public IEnumerable<string> GetAll()
    {
        //Comunicaccion con Base de Datos
        return new string[] { "value1  Infraestructure SQL", "value2 Infraestructure SQL" }; 
    }
       
}