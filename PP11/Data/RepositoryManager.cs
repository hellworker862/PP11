using PP11.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP11.Data
{
    internal class RepositoryManager
    {
        private DataBase dataBase = new DataBase();
        private ServiceRepository serviceRepository;
        private ClietnRepository clietnRepository;
        private OrderRepository orderRepository;

        public ServiceRepository Services
        {
            get
            {
                if(serviceRepository == null)
                    serviceRepository = new ServiceRepository(dataBase);
                return serviceRepository;
            }
        }

        public ClietnRepository Clients
        {
            get
            {
                if (clietnRepository == null)
                    clietnRepository = new ClietnRepository(dataBase);
                return clietnRepository;
            }
        }

        public OrderRepository Orders
        {
            get
            {
                if (orderRepository == null)
                    orderRepository = new OrderRepository(dataBase);
                return orderRepository;
            }
        }
    }
}
