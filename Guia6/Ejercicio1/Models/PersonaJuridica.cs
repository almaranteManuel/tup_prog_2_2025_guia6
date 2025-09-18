namespace Ejercicio1.Models;

public class PersonaJuridica : Persona
{
    string cuit;

    public PersonaJuridica(string nombre, string cuit): base(nombre)
    {
        this.cuit = cuit;
    }

    public override string Describir()
    {
        return base.Describir() + $" | {cuit}";
    }
}
