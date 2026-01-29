using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using CollectionViewEjemplo.Models;

namespace CollectionViewEjemplo
{
    public class LocalDbService
    {
        private const string DB_NAME = "demo_local_db.db3";
        private readonly SQLiteAsyncConnection _connection;

        public LocalDbService()
        {
            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));

            _connection.CreateTableAsync<Persona>().Wait();
        }

        public async Task<List<Persona>> GetPersonas()
        {
            return await _connection.Table<Persona>().ToListAsync();
        }

        public async Task<Persona> GetPersonaById(int id)
        {
            return await _connection.Table<Persona>().Where(x => x.Id==id).FirstOrDefaultAsync();
        }

        public async Task Create(Persona persona)
        {
            await _connection.InsertAsync(persona);
        }

        public async Task Update(Persona persona)
        {
            await _connection.UpdateAsync(persona);
        }

        public async Task Delete(Persona persona)
        {
            await _connection.DeleteAsync(persona);
        }

        public async Task SeedDataAsync(List<Persona> personasIniciales)
        {
            var count = await _connection.Table<Persona>().CountAsync();
            if (count == 0)
            {
                await _connection.InsertAllAsync(personasIniciales);
            }
        }
    }
}
