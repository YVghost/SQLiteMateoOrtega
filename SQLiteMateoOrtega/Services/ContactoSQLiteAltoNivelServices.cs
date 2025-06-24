using SQLite;
using SQLiteMateoOrtega.Interfaces;
using SQLiteMateoOrtega.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteMateoOrtega.Services
{
    class ContactoSQLiteAltoNivelServices : IContactoService
    {
        string _dbPath = FileSystem.AppDataDirectory+"/contacto.db3";
        SQLiteAsyncConnection _sqliteAsyncConnection;

        public ContactoSQLiteAltoNivelServices()
        {
            Init();
        }

        public async Task<List<Contacto>> DevuelveListaContacto()
        {
            try
            {
                var listaContactos = await _sqliteAsyncConnection.Table<Contacto>().ToListAsync();
                return listaContactos;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones, por ejemplo, registrar el error
                Console.WriteLine($"Error al obtener la lista de contactos: {ex.Message}");
                return new List<Contacto>();
            }
   
        }

        public Task<bool> EliminarContacto(int id)
        {
            throw new NotImplementedException();
        }

        public Async async Task Init()
        {
            _sqliteAsyncConnection = new SQLiteAsyncConnection(_dbPath);
            await _sqliteAsyncConnection.CreateTableAsync<Contacto>();
        }

        public Task<bool> InsertarContacto(Contacto contacto)
        {
            throw new NotImplementedException();
        }
    }
}
