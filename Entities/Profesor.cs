using Laboratorio2.Interface;

namespace Laboratorio2.Entities
{
    public class Profesor : Persona
    {
        public string CUI {get;set;}
        public string Cargo {get;set;}
        public int asistencia { get; set; }

         public Profesor (string CUIset, string Cargoset, Persona persona): base(persona.UUID, persona.Apellidos, persona.Nombres, persona.Email){
            CUI = CUIset;
            Cargo = Cargoset;
            asistencia = 0;
        }

        public void tomarAsistencia(Profesor profesor, int asistencia){
            profesor.asistencia = asistencia;
        }
    }
}