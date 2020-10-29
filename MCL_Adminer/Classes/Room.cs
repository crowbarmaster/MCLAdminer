using System;
using System.Collections.Generic;

namespace MCL_Adminer
{
    public class Room
    {
        public void LoadAll()
        {
            List<string[]> query = SQL.Select("rooms", new string[] { "*" }, null);
            foreach (string[] rm in query)
            {
                Room room = new Room();
                room.ID = rm[0];
                room.tName = rm[1];
                char[] explode = rm[2].ToCharArray();
                room.hasS = charToBool(explode[0]);
                room.hasT = charToBool(explode[1]);
                room.hasFloor = charToBool(explode[2]);
                room.hasCarpet = charToBool(explode[3]);
                room.hasBRoom = charToBool(explode[4]);
                room.hasSani = charToBool(explode[5]);
                Globals.RoomList.Add(room);
            }
            foreach (Room rm2 in Globals.RoomList)
            {
                Console.WriteLine("Room added: " + rm2.ID + " " + rm2.tName);
            }
        }

        public bool charToBool(char input)
        {
            return input == '1';
        }

        public char boolToChar(bool input)
        {
            char result;
            if (input)
            {
                result = '1';
            }
            else
            {
                result = '0';
            }
            return result;
        }
        public string ID;
        public string tName;
        public bool hasS = false;
        public bool hasT = false;
        public bool hasFloor = false;
        public bool hasCarpet = false;
        public bool hasBRoom = false;
        public bool hasSani = false;
        private readonly SQLHandler SQL = new SQLHandler();
    }
}
