using System.ComponentModel.DataAnnotations.Schema;

namespace OptimizeMePlease.Entities
{
    public class UserRole
    {
        public int Id { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        public int UserId { get; set; }

        [ForeignKey(nameof(RoleId))]
        public Role Role { get; set; }
        public int RoleId { get; set; }
    }
}