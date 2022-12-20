using PP11.Data.Interfaces;
using PP11.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace PP11.Data.Repositories
{
    public class ServiceRepository : IRepository<Service>
    {
        private DataBase db;

        public ServiceRepository(DataBase context)
        {
            db = context;
        }

        public Task<int> Create(Service item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Service> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Service>> GetAll()
        {
            string query = "SELECT id, name, price FROM Services";
            var result = await db.SelectQuery(query);

            var listServices = new List<Service>();

            if (result.Rows.Count < 1)
            {
                return listServices;
            }

            foreach (DataRow row in result.Rows)
            {
                int id = (int)row[0];
                string name = (string)row[1];
                decimal price = (decimal)row[2];

                listServices.Add(new Service()
                {
                    Id = id,
                    Name = name,
                    Price = price,
                });
            }

            return listServices;
        }

        public Task Update(Service item)
        {
            throw new NotImplementedException();
        }

        public async Task<int> NewId()
        {
            string query = "SELECT MAX(id) FROM Services";
            var result = await db.SelectQuery(query);

            int newId = ((int)result.Rows[0][0]) + 1;
            return newId;
        }
    }
}
