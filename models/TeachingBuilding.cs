using System;
using System.Collections.Generic;

namespace CivCampusExercise_2021.models
{
    public class TeachingBuilding : Building
    {

        public List<Room> Rooms { get; set; }


        public TeachingBuilding(string buildingId) : base(buildingId)
        {
            this.Rooms = new List<Room>();
        }

        public void AddRoom(uint capacity, int roomNo)
        {
            string roomId = this.BuildingId + roomNo;
            Rooms.Add(new Room(capacity, roomNo, roomId));
        }

        /// <summary>
        /// Returns a string with the list of rooms seperated by commas
        /// </summary>
        /// <returns>A string representing the rooms</returns>
        public string ListRooms()
        {
            string output = "";

            foreach (var room in Rooms)
            {
                output += $"{room.RoomId}, {room.Capacity}\n";
            }
            return output;
        }

        public int GetBuildingCapacity()
        {
            int total = 0;

            foreach(Room room in Rooms)
            {
                total += (int)room.Capacity;
            }

            return total;
        }
    }
}