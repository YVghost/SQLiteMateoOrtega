using SQLiteMateoOrtega.Services;
using SQLiteMateoOrtega.Interfaces;

namespace SQLiteMateoOrtega
{
    public partial class MainPage : ContentPage
    {
        IContactoService _contactoService;

        public MainPage()
        {
            InitializeComponent();
            _contactoService = new ContactoSQLiteAltoNivelServices();
        }

        private void Guardado_clicked(object sender, EventArgs e)
        {
            Nombre = Nombre.Text,
            Telefono = Telefono.Text;
            CorreoElectronico = CorreoElectronico.Text;
            Direccion = Direccion.Text;
            Empresa = Empresa.Text;




        }
    }

}
