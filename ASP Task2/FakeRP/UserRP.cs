using ASP_Task2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Task2.FakeRP
{
    public class UserRP
    {
        public static List<User> Users = new List<User>
        {
            new User
            {
                Id=1,
                Name="Kamran",
                Surname="Aliyev",
                Age=23
            },
            new User
            {
                Id=1,
                Name="Huseyn",
                Surname="Rustamov",
                Age=21
            },
            new User
            {
                Id=1,
                Name="MemmedAga",
                Surname="Qubali",
                Age=55
            }
        };

        public List<User> GetAllUsers()
        {
            return Users;
        }
    }
}
