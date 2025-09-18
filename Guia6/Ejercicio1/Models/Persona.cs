namespace Ejercicio1.Models;

public class Persona : IComparable<Persona>
{
    protected string nombre;

    public string Nombre {
        get
        {
            return nombre;
        }
    }

    public Persona (string nombre)
    {
        this.nombre = nombre;
    }

    public virtual string Describir()
    {
        return $"Hola {nombre}";
    }

    public int CompareTo(Persona otro)
    {

        if (otro != null)
            return nombre.CompareTo(otro.nombre);
        return -1;
    }
}
