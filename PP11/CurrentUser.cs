using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP11
{
    public static class CurrentUser
    {
        public static int Id { get; set; }

        public static string Name { get; set; }

        public static string Surname { get; set; }

        public static string Patronymic { get; set; }

        public static int? PositionId { get; set; }

        public static string ImgHref { get; set; }

        public static string ToString()
        {
            return $"{Surname} {Name[0]}.{Patronymic[0]}.";
        }

        public static void Clear()
        {
            Id = -1;
            Name = null;
            Surname = null;
            Patronymic = null;
            PositionId = null;
            ImgHref = null;
        }
    }
}
