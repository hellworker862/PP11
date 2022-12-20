using PP11.Data.Interfaces;
using PP11.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace PP11.Data.Repositories
{
    public class OrderRepository
    {
        private DataBase db;

        public OrderRepository(DataBase context)
        {
            db = context;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> NewId()
        {
            string query = "SELECT MAX(id) FROM Orders";
            var result = await db.SelectQuery(query);

            int newId = ((int)result.Rows[0][0]) + 1;
            return newId;
        }

        public async Task<int> Create(Order item, int idEmployee)
        {
            int newId = await NewId();
            string query = $@"INSERT Orders(id, datetime_create, id_client, id_status, rental_time, id_employee)
                              VALUES ({newId}, '{item.DateTimeCreate}', {item.ClientId}, {item.StatusId}, {item.RentalTime}, {idEmployee})";
            await db.InsertQuery(query);

            return newId;
        }

        public Task<Order> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            string query = "SELECT id, datetime_create, id client, id_status, date_close, rental_time FROM Orders";
            var result = await db.SelectQuery(query);

            var list = new List<Order>();

            foreach (DataRow item in result.Rows)
            {
                var newOrder = new Order()
                {
                    Id = (int)item[0],
                    DateTimeCreate = (DateTime)item[1],
                    ClientId = (int)item[2],
                    StatusId = (int)item[3],
                    DateClose = item[4] is DBNull ? DateTime.MinValue : (DateTime)item[4],
                    RentalTime = (int)item[5]
                };
                list.Add(newOrder);
            }

            return list;
        }

        public async Task Update(Order item)
        {
            string query = $"UPDATE Orders SET date_close = GETDATE() WHERE id = {item.Id}";

            await db.UpdateQuery(query);
        }

        public async Task<Order> IncludeClient(Order order)
        {
            RepositoryManager repositoryManager = new RepositoryManager();
            order.Client = await repositoryManager.Clients.Get(order.ClientId);
            return order;
        }
    }
}
