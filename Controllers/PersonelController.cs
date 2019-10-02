using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApi_Tutorial1.Models;

namespace WebApi_Tutorial1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonelController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            if (listPersonleList == null || listPersonleList.Count == 0)
                return NotFound();

            return Ok(listPersonleList);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id <= 0)
                return NotFound();

            Personel personel = listPersonleList.Where(w => w.Id == id).FirstOrDefault();
            if (personel == null)
                return NotFound();

            return Ok(personel);
        }


        private List<Personel> listPersonleList = new List<Personel>
        {
            new Personel { Id = 1, Ad = "Slade", Soyad = "Pena" },
            new Personel { Id = 2, Ad = "Wing", Soyad = "Lowe" },
            new Personel { Id = 3, Ad = "Blair", Soyad = "Lyons" },
            new Personel { Id = 4, Ad = "Myles", Soyad = "Potts" },
            new Personel { Id = 5, Ad = "Cheyenne", Soyad = "Mccormick" },
            new Personel { Id = 6, Ad = "Zenia", Soyad = "Finch" },
            new Personel { Id = 7, Ad = "Erica", Soyad = "Lynn" },
            new Personel { Id = 8, Ad = "Igor", Soyad = "Wooten" },
            new Personel { Id = 9, Ad = "Lunea", Soyad = "May" },
            new Personel { Id = 10, Ad = "Alan", Soyad = "Kidd" },
            new Personel { Id = 11, Ad = "Dane", Soyad = "Phillips" },
            new Personel { Id = 12, Ad = "Amy", Soyad = "Alvarez" },
            new Personel { Id = 13, Ad = "Shafira", Soyad = "Lara" },
            new Personel { Id = 14, Ad = "Sopoline", Soyad = "Nash" },
            new Personel { Id = 15, Ad = "Camden", Soyad = "Burke" },
            new Personel { Id = 16, Ad = "Ryder", Soyad = "Wade" },
            new Personel { Id = 17, Ad = "John", Soyad = "Crawford" },
            new Personel { Id = 18, Ad = "Madison", Soyad = "Shaw" },
            new Personel { Id = 19, Ad = "Nicholas", Soyad = "Juarez" },
            new Personel { Id = 20, Ad = "Kirsten", Soyad = "Carr" },
            new Personel { Id = 21, Ad = "Stephen", Soyad = "Goodman" },
            new Personel { Id = 22, Ad = "Sean", Soyad = "Finley" },
            new Personel { Id = 23, Ad = "Cameron", Soyad = "Young" },
            new Personel { Id = 24, Ad = "Sawyer", Soyad = "Singleton" },
            new Personel { Id = 25, Ad = "Merrill", Soyad = "Bray" },
            new Personel { Id = 26, Ad = "Maite", Soyad = "Contreras" },
            new Personel { Id = 27, Ad = "Riley", Soyad = "Mcdaniel" },
            new Personel { Id = 28, Ad = "Judith", Soyad = "Kerr" },
            new Personel { Id = 29, Ad = "Isaiah", Soyad = "Sears" },
            new Personel { Id = 30, Ad = "Hunter", Soyad = "Blair" },
            new Personel { Id = 31, Ad = "Walker", Soyad = "Boyle" },
            new Personel { Id = 32, Ad = "Elvis", Soyad = "Alford" },
            new Personel { Id = 33, Ad = "Adrian", Soyad = "Maynard" },
            new Personel { Id = 34, Ad = "Fletcher", Soyad = "Carrillo" },
            new Personel { Id = 35, Ad = "Marvin", Soyad = "Prince" },
            new Personel { Id = 36, Ad = "Abra", Soyad = "Harper" },
            new Personel { Id = 37, Ad = "Amelia", Soyad = "Gates" },
            new Personel { Id = 38, Ad = "Dylan", Soyad = "Lowe" },
            new Personel { Id = 39, Ad = "Raymond", Soyad = "Dickson" },
            new Personel { Id = 40, Ad = "Lillith", Soyad = "York" },
            new Personel { Id = 41, Ad = "Arthur", Soyad = "West" },
            new Personel { Id = 42, Ad = "Cassady", Soyad = "Estes" },
            new Personel { Id = 43, Ad = "Nasim", Soyad = "Bruce" },
            new Personel { Id = 44, Ad = "Steel", Soyad = "Burris" },
            new Personel { Id = 45, Ad = "Dean", Soyad = "Barry" },
            new Personel { Id = 46, Ad = "Talon", Soyad = "Chang" },
            new Personel { Id = 47, Ad = "Barrett", Soyad = "Lucas" },
            new Personel { Id = 48, Ad = "Ray", Soyad = "Mendoza" },
            new Personel { Id = 49, Ad = "Rajah", Soyad = "Palmer" },
            new Personel { Id = 50, Ad = "Winter", Soyad = "Guzman" },
            new Personel { Id = 51, Ad = "Mollie", Soyad = "Luna" },
            new Personel { Id = 52, Ad = "Minerva", Soyad = "Long" },
            new Personel { Id = 53, Ad = "Quentin", Soyad = "Hewitt" },
            new Personel { Id = 54, Ad = "Phelan", Soyad = "Fulton" },
            new Personel { Id = 55, Ad = "Stacey", Soyad = "Molina" },
            new Personel { Id = 56, Ad = "Dean", Soyad = "Sweet" },
            new Personel { Id = 57, Ad = "Bernard", Soyad = "Hutchinson" },
            new Personel { Id = 58, Ad = "Regina", Soyad = "Ashley" },
            new Personel { Id = 59, Ad = "Jamalia", Soyad = "West" },
            new Personel { Id = 60, Ad = "Charde", Soyad = "Leonard" },
            new Personel { Id = 61, Ad = "Kermit", Soyad = "Conley" },
            new Personel { Id = 62, Ad = "Ignacia", Soyad = "Santos" },
            new Personel { Id = 63, Ad = "Lionel", Soyad = "Pickett" },
            new Personel { Id = 64, Ad = "Austin", Soyad = "Roberson" },
            new Personel { Id = 65, Ad = "Hollee", Soyad = "Delacruz" },
            new Personel { Id = 66, Ad = "Whilemina", Soyad = "Russo" },
            new Personel { Id = 67, Ad = "Giselle", Soyad = "Burnett" },
            new Personel { Id = 68, Ad = "Beau", Soyad = "James" },
            new Personel { Id = 69, Ad = "Finn", Soyad = "Clements" },
            new Personel { Id = 70, Ad = "Quin", Soyad = "Flores" },
            new Personel { Id = 71, Ad = "Ava", Soyad = "Joyner" },
            new Personel { Id = 72, Ad = "Cedric", Soyad = "Ramos" },
            new Personel { Id = 73, Ad = "Remedios", Soyad = "Burks" },
            new Personel { Id = 74, Ad = "Jorden", Soyad = "Craft" },
            new Personel { Id = 75, Ad = "Hayfa", Soyad = "Hughes" },
            new Personel { Id = 76, Ad = "Cassandra", Soyad = "Mcintyre" },
            new Personel { Id = 77, Ad = "Raya", Soyad = "Washington" },
            new Personel { Id = 78, Ad = "Tyrone", Soyad = "Berg" },
            new Personel { Id = 79, Ad = "Rana", Soyad = "Vasquez" },
            new Personel { Id = 80, Ad = "George", Soyad = "Rogers" },
            new Personel { Id = 81, Ad = "Scott", Soyad = "Mayer" },
            new Personel { Id = 82, Ad = "Abraham", Soyad = "Shelton" },
            new Personel { Id = 83, Ad = "Julian", Soyad = "Rosales" },
            new Personel { Id = 84, Ad = "Haviva", Soyad = "Maldonado" },
            new Personel { Id = 85, Ad = "Azalia", Soyad = "Odom" },
            new Personel { Id = 86, Ad = "Jakeem", Soyad = "Sharpe" },
            new Personel { Id = 87, Ad = "Blaine", Soyad = "Brennan" },
            new Personel { Id = 88, Ad = "Thaddeus", Soyad = "Shepard" },
            new Personel { Id = 89, Ad = "Alfreda", Soyad = "Townsend" },
            new Personel { Id = 90, Ad = "Zeph", Soyad = "Hoffman" },
            new Personel { Id = 91, Ad = "Tamara", Soyad = "Workman" },
            new Personel { Id = 92, Ad = "Bell", Soyad = "Gilbert" },
            new Personel { Id = 93, Ad = "Alma", Soyad = "Hendrix" },
            new Personel { Id = 94, Ad = "Kennedy", Soyad = "Bennett" },
            new Personel { Id = 95, Ad = "Jesse", Soyad = "Roy" },
            new Personel { Id = 96, Ad = "Keelie", Soyad = "Kinney" },
            new Personel { Id = 97, Ad = "Holmes", Soyad = "Banks" },
            new Personel { Id = 98, Ad = "Madeson", Soyad = "Wyatt" },
            new Personel { Id = 99, Ad = "Preston", Soyad = "Slater" },
            new Personel { Id = 100, Ad = "Shaine", Soyad = "Hinton" }
        };
    }
}