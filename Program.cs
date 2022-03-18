using Laboratorio_II.Kinal.Lab.Entities;
using Laboratorio_II.Kinal.Lab.Interfaces;
public class Program
{
    private static List<Persona> ListaGeneral = new List<Persona>();
    public static void Main(string[] args)
    {
        Alumno AndresBautista = new Alumno("111", "Bautista Morales", "Andres Erick", "Abautista@gmail.com", "221155", 30);
        Profesor JenyRivera = new Profesor("222", "Rivera Ponce", "Jenny Margarita", "Jrivera@gmail.com", "300255448870101", "Maestro de programacion");

        OperarRegistro(AndresBautista);
        OperarRegistro(JenyRivera);

        RegistrarAsistencia(AndresBautista);
        RegistrarAsistencia(JenyRivera);

        VerMisDatos(AndresBautista);
        VerMisDatos(JenyRivera);

        QuitarAsignatura(AndresBautista,"Calculo");
        QuitarAsignatura(JenyRivera,"Programacion");
    }

    public static void QuitarAsignatura(Persona elemento, string asignatura)
    {
        ((IOperaciones)elemento).EliminarAsignatura(asignatura);
    }

    public static void VerMisDatos(Persona elemento)
    {
        if (elemento is Alumno)
        {
            Alumno auxiliar = (Alumno)elemento;
            auxiliar.ListarMisDatos(auxiliar.Carne);
        }
        else if (elemento is Profesor)
        {
            Profesor auxiliar = (Profesor)elemento;
            auxiliar.ListarMisDatos(auxiliar.Cui);
        }
    }

    public static void RegistrarAsistencia(Persona elemento)
    {
        foreach (Persona registro in ListaGeneral)
        {
            if (registro.Uuid == elemento.Uuid)
            {
                elemento.TomarAsistencia();
            }
        }
    }
    public static void OperarRegistro(Persona elemento)
    {
        ListaGeneral.Add(elemento);
    }
}

