public abstract class ExpedienteAnimal { }
public class ExpedientePerro : ExpedienteAnimal { }
public class ExpedienteSilvestre : ExpedienteAnimal { }

public class ExpedienteFactory 
{
    public static ExpedienteAnimal CrearExpediente(string tipo) 
    {
        return tipo == "silvestre" ? new ExpedienteSilvestre() : new ExpedientePerro();
    }
}
