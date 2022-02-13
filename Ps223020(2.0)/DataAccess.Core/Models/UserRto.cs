using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ps223020_2._0_.DataAccess.Core.Models
{
    [Table("User")]
    public class UserRto
    {
        [Key] public int Id { get; set; }
        public long PhoneNumber { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }



        #region Relationship Scheme
        public List<UserGameRto> MyProperty { get; set }
        #endregion
    }
}
