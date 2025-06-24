using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteMateoOrtega.Interfaces
{
    interface IContactoService
    {
        public async void Init();
        public Task<List<Models.Contacto>> DevuelveListaContacto();
        public Task <bool> InsertarContacto(Models.Contacto contacto);
        public Task <bool> EliminarContacto(int id);
    }
}
