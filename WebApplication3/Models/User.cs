using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class User
    {
        public User()
        {
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            this.Status = UserStatus.Active;
        }
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public UserStatus Status { get; set; }
    }

    public enum UserStatus
    {
        Active = 1,
        Deactive = 0
    }
}
