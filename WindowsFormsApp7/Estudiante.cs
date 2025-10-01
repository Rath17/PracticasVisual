using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp7
{
    public class Estudiante
    {
        public string Carnet { get; set; }
        public string Nombre { get; set; }
        public List<Asignatura> Asignaturas { get; set; } = new List<Asignatura>();

        public double Promedio => Asignaturas.Count > 0 ? Asignaturas.Average(a => a.Nota) : 0;
    }

    public class Asignatura
    {
        public string Nombre { get; set; }
        public double Nota { get; set; }
    }

    public static class DatosCompartidos
    {
        public static List<Estudiante> ListaEstudiantes { get; set; } = new List<Estudiante>();
    }
}
