using System;

class Nodo
{
    private string nombre, direccion;
    private int telefono;
    private Nodo Liga;

    public Nodo(string nombre, string direccion, int telefono)
    {
        Nombre = nombre;
        Direccion = direccion;
        Telefono = telefono;
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Direccion
    {
        get { return direccion; }
        set { direccion = value; }
    }

    public int Telefono
    {
        get { return telefono; }
        set 
        {
            if (value > 0)
                telefono = value;
        }
    }

    public Nodo Enlance
    {
        get { return Liga; }
        set { Liga = value; }
    }
}
