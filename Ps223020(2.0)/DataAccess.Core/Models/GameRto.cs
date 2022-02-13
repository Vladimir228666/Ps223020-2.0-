using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace Ps223020_2._0_.DataAccess.Core.Models
{
    [Table("Game")]
    public class GameRto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Author { get; set; }
        public int AgeRate { get; set; }

        public List<UserGameRto> UserGames { get; set; }
    }
}
