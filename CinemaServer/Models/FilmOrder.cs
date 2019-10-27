using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaServer.Models
{
    public class FilmOrder
    {
        public int Id { get; set; }

        [Display(Name = "Название киносеанса")]
        public string Name { get; set; }

        [Display(Name = "Количество билетов")]
        public int CountTicket { get; set; }

        [Display(Name = "Время заказа")]
        public DateTime OrderTime { get; set; }
    }
}
