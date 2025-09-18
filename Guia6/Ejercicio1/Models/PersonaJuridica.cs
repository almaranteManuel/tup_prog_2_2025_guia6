namespace Ejercicio1.Models;

public class PersonaJuridica : Persona
{
    string cuit;

    public PersonaJuridica(string nombre, string cuit): base(nombre)
    {
        this.cuit = cuit;
    }

    protected bool VerificarCuit()
    {
        int[] p = { 5, 4, 2, 7 };
        bool esValido = cuit.Length == 11;

        for (int i = 0; esValido && i < cuit.Length; i++)
        {
            
        }
    }

    public override string Describir()
    {
        return base.Describir() + $" | {cuit}";
    }
}
