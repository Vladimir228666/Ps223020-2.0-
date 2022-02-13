using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ps223020_2._0_.DataAccess.Core.Models
{
    [Table("UserGame")]
    public class UserGameRto
    {
        [Key] public int Id { get; set; }


        public int UserId { get; set; }
        public UserRto User { get; set; } //это не нужная фигня
        public int GameId { get; set; }
        public GameRto Game { get; set; } //навигационное свойство

    }
}
