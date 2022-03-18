namespace Laboratorio2.Entities
{
    public class Persona
    {
        public string UUID { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set;}
        public string Email { get; set; }
        
        public Persona (string uUID, string apellidos, string nombres, string email){
            this.UUID = uUID;
            this.Apellidos = apellidos;
            this.Nombres = nombres;
            this.Email = email;
        }
    
    }
}