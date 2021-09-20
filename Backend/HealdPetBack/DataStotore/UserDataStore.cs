using System.Collections.Generic;
using Backend.models;

namespace Backend.DataStotore
{
    public class UserDataStore
    {
        public static UserDataStore Current { get; } = new UserDataStore();
        public List<userDto> Users { get; set; }
        public UserDataStore()
        {
            //coneccion a base de datos
            Users = new List<userDto>()
            {
                new userDto(){
                    id = 1,
                    email = "email@example.com1",
                    password = "uno"
                },
                new userDto(){
                    id = 2,
                    email = "email@example.com2",
                    password = "dos"
                }
            };
        }
    }
}