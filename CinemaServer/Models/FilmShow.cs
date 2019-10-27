using System;
using System.ComponentModel.DataAnnotations;

namespace CinemaServer.Models
{
    public class FilmShow
    {
        public int Id { get; set; }

        [Display(Name = "Название киносеанса")]
        public string Name { get; set; }

        [Display(Name = "Время начала киносеанса")]
        public DateTime FilmStartTime { get; set; }
    }
}
