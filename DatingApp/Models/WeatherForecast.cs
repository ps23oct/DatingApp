using System;
using System.ComponentModel.DataAnnotations;

namespace DatingApp.Models
{
    public class WeatherForecast
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    
    }
}