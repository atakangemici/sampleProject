using System.ComponentModel.DataAnnotations.Schema;

namespace Sample.Model.Entities
{
    public class Users : BaseEntity
    {
        [Column("name")]
        public string Name { get; set; }

        [Column("surename")]
        public string SureName { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("has_admin_rights")]
        public bool HasAdminRights { get; set; }
    }
}
