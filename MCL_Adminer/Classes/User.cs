using System;
using System.Collections.Generic;

namespace MCL_Adminer
{
    public class User
    {
        public void LoadAll()
        {
            List<string[]> query = SQL.Select("users", new string[] { "*" }, null);
            foreach (string[] usr in query)
            {
                User user = new User();
                user.id = usr[0];
                user.firstName = usr[1];
                user.lastName = usr[2];
                user.fullName = usr[1] + " " + usr[2];
                user.bldg = usr[3];
                user.shift = usr[4];
                user.rooms = usr[5].Split(';');
                Globals.UserList.Add(user);
                Console.WriteLine(usr[0] + " " + usr[1] + " " + usr[2] + " " + usr[3] + " " + usr[4] + " " + usr[5] + " Added to list!");
            }
            foreach (User user2 in Globals.UserList)
            {
                Console.WriteLine("User added: " + user2.id + " " + user2.firstName + " " + user2.lastName);
            }
        }

        public static string getUsernameByID(string id)
        {
            foreach (User user in Globals.UserList)
            {
                if (user.id == id)
                {
                    return user.fullName;
                }
            }
            return "";
        }

        public string id = "null";
        public string firstName = "";
        public string lastName = "";
        public string fullName = "";
        public string bldg = "";
        public string shift = "";
        public string[] rooms;
        private readonly SQLHandler SQL = new SQLHandler();
    }
}
