public interface IObservador 
{ 
    void Notificar(string mensaje); 
}

public class VoluntarioObserver : IObservador 
{
    public void Notificar(string mensaje) { }
}
