using PP11.Data.Interfaces;
using PP11.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace PP11.Data.Repositories
{
    public class ClietnRepository : IRepository<Client>
    {
        private DataBase db;

        public ClietnRepository(DataBase context)
        {
            db = context;
        }

        public async Task<int> Create(Client item)
        {
            int newId = await NewId();
            string query = $@"INSERT Clients(id, name, surname, patronymic, series_passport, number_passport, birth_of_date, adress, email)
                              VALUES({newId}, '{item.Name}', '{item.Surname}', '{item.Patronymic}', '{item.SeriesPassport}', '{item.NumberPassport}', '{item.BirthOfDate}', '{item.Adress}', '{item.Email}')";

            await db.InsertQuery(query);

            return newId;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Client> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Client>> GetAll()
        {
            string query = "SELECT id, name, surname, patronymic, birth_of_date, adress, email, series_passport, number_passport FROM Clients";
            var result = await db.SelectQuery(query);

            var listClients = new List<Client>();

            if (result.Rows.Count < 1)
            {
                return listClients;
            }

            foreach (DataRow row in result.Rows)
            {
                int id = (int)row[0];
                string name = (string)row[1];
                string surname = (string)row[2];
                string patronymic = (string)row[3];
                DateTime birthOfDate = (DateTime)row[4];
                string adress = (string)row[5];
                string email = (string)row[6];
                int seriesPassport = (int)row[7];
                int numberPassport = (int)row[8];

                listClients.Add(new Client()
                {
                    Id = id,
                    Name = name,
                    Surname = surname,
                    Patronymic = patronymic,
                    BirthOfDate = birthOfDate,
                    Adress = adress,
                    Email = email,
                    SeriesPassport = seriesPassport,
                    NumberPassport = numberPassport
                });
            }

            return listClients;
        }

        public Task Update(Client item)
        {
            throw new NotImplementedException();
        }

        public async Task<int> NewId()
        {
            string query = "SELECT MAX(id) FROM Clients";
            var result = await db.SelectQuery(query);

            int newId = ((int)result.Rows[0][0]) + 1;
            return newId;
        }
    }
}
