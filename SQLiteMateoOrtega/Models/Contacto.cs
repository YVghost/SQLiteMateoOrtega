using SQLite;

namespace SQLiteMateoOrtega.Models
{
    class Contacto
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        [SQLite.NotNull]
        public string CorreoElectronico { get; set; }
        [SQLite.Column("Correo")]
        public int Telefono { get; set; }
        [MaxLength(15)]
        public string Direccion { get; set; }
        public string Empresa { get; set; }
   
    }
}
