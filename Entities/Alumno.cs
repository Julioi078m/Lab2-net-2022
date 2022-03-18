namespace Laboratorio2.Entities
{
    public class Alumno : Persona
    {
        public string CUI { get; set; }
        public string numeroCreditos { get; set; }

        public int asistencia { get; set; }

        public Alumno (string CUIset, string creditos, Persona persona): base(persona.UUID, persona.Apellidos, persona.Nombres, persona.Email){
            CUI = CUIset;
            numeroCreditos = creditos;
            asistencia = 0;
        }

        public void tomarAsistencia(int asistencia){
            this.asistencia = asistencia;
        }

    }
}