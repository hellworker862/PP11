using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP11.Models
{
    public class Client
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }

        public int SeriesPassport { get; set; }

        public int NumberPassport { get; set; }

        public DateTime BirthOfDate { get; set; }

        public string Adress { get; set; }

        public string Email { get; set; }

        public override string ToString()
        {
            return $"{Surname} {Name} {Patronymic}";
        }
    }
}
