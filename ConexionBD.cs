public class ConexionBD 
{
    private static ConexionBD _instancia;
    private ConexionBD() { }

    public static ConexionBD GetInstancia() 
    {
        if (_instancia == null) 
        {
            _instancia = new ConexionBD();
        }
        return _instancia;
    }
}
