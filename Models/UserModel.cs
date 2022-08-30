using System;
namespace HardwareSite.Models
{
    public class UserModel
    {
        public int id { get; set;}
        public string email { get; set; }
        public string passwordHash { get; set; }
        public roles role { get; set; }

        public UserModel(int id, string email, string passwordHash, roles role)
        {
            this.id = id;
            this.email = email;
            this.passwordHash = passwordHash;
            this.role = role;
        }

        public enum roles {
            user,
            employee,
            admin
        };
    }
}

