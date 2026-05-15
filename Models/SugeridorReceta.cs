namespace Formularios2.Models;

public class SugeridorReceta 
{

public string Nombre {get; set;}
public DateTime fechaNacimiento {get; set;}
public string TipoComida {get; set;}
public int presupuesto  {get; set;}
public int cantidadPersonas  {get; set;}




public int CalcularEdad(DateTime fechaNacimiento)
{
    DateTime hoy = DateTime.Today;

    int edad = hoy.Year - fechaNacimiento.Year;

  
    if (fechaNacimiento.Date > hoy.AddYears(-edad))
    {
        edad--;
    }

    return edad;
}
public string DeterminarPlato()
{
    if (TipoComida == "Caliente")
    {
        if (presupuesto < 3000)
        {
            return "Fideos con manteca";
        }
        else if (presupuesto <= 7000)
        {
            return "Arroz con verduras salteadas";
        }
        else
        {
            return "Pollo al horno con guarnición";
        }
    }
    else if (TipoComida == "Fría")
    {
        if (presupuesto < 3000)
        {
            return "Ensalada simple";
        }
        else if (presupuesto <= 7000)
        {
            return "Ensalada completa con proteína";
        }
        else
        {
            return "Tabla de fiambres y quesos";
        }
        
        
    }

    return "Tipo de comida no válido";

}

public int CalcularTiempo()
{

    if (TipoComida == "Caliente")
    {
        if (cantidadPersonas >= 1 && cantidadPersonas <= 3 )
        {

            return 20;
        }
         if (cantidadPersonas >= 4 && cantidadPersonas <= 7  )
        {

            return 40;
        }
         if (cantidadPersonas >= 8)
        {

            return 80;
        }
       
    }
    else if (TipoComida == "Fría")
    {
        if (cantidadPersonas >= 1 && cantidadPersonas <= 3 )
        {
            return 10 ;
        }
        if(cantidadPersonas >= 4 && cantidadPersonas <= 7)
        {
           return 20;
        }
        if(cantidadPersonas >= 8)
        {
           return 40;
        }
    }  
        return 0;

}



public string DeterminarDificultad()
{
    
    if (cantidadPersonas >= 8)
    {
        return "Avanzado";
    }

    
    if (presupuesto < 3000 && cantidadPersonas >= 1 && cantidadPersonas <= 3)
    {
        return "Principiante";
    }

    
    return "Intermedio";
}
}