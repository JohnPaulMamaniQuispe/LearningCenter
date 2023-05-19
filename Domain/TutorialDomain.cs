using Infraestructura;

namespace Domain;

public class TutorialDomain : ITutorialDomain
{
    private ITutorialInfraestructure _tutorialInfraestructure;

    public TutorialDomain(ITutorialInfraestructure tutorialInfraestructure)
    {
        _tutorialInfraestructure = tutorialInfraestructure;

    }
    public IEnumerable<string> GetAll()
    {
       // TutorialInfraestructure tutorialInfraestructure = new TutorialInfraestructure();
        //return tutorialInfraestructure.GetAll();
        return _tutorialInfraestructure.GetAll();
        //SQLIn

    } 
}