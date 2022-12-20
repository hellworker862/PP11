using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP11.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime DateTimeCreate { get; set; }

        public int ClientId { get; set; }

        public int StatusId { get; set; }

        public DateTime DateClose { get; set; }

        public int RentalTime { get; set; }

        public Client Client { get; set; }

        public int EmployeeId { get; set; }
    }
}
