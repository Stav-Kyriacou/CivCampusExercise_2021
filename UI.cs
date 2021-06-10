using System;
using CivCampusExercise_2021.models;

namespace CivCampusExercise_2021
{
    public class UI
    {
        public TeachingBuilding TD { get; set; }
        public AmenitiesBuilding GE { get; set; }
        public AmenitiesBuilding Library { get; set; }
        public UI() {
            this.TD = new TeachingBuilding("TD");
            this.GE = new AmenitiesBuilding("GE", "Student Amenities", 6, 22);
            this.Library = new AmenitiesBuilding("LIB", "Library", 8, 20);
        }

        public void Init() {
            TopMenu();
        }

        public void TopMenu() {
            Console.WriteLine("Welcome to the Swinburne building tracker - Alpha ver");

            Console.WriteLine("1. Add Room to TD building");
            Console.WriteLine("2. Get Room listing from TD building");
            Console.WriteLine("3. Get total capacity of the TD building");
            Console.WriteLine("4. Get the amount of rooms in the TD building");
            Console.WriteLine("5. Print the opening and closing times of the library");
            Console.WriteLine("6. Print the type of building that building GE is");
            Console.WriteLine("7. Exit");

            var input = Console.ReadLine();

            switch(input) {
                case "1":
                    this.AddRoom();     
                    break;
                
                case "2":
                    Console.WriteLine(TD.ListRooms());
                    break;

                case "3":
                    Console.WriteLine($"TD building maximum capacity: {TD.GetBuildingCapacity()}");
                    break;

                case "4":
                    Console.WriteLine($"TD building room count: {TD.Rooms.Count}");
                    break;

                case "5":
                    System.Console.WriteLine($"Library opening and closing hours are: {Library.OpeningHour}am to {Library.ClosingHour}pm");
                    break;

                case "6":
                    Console.WriteLine($"GE building type: {GE.Type}");
                    break;

                case "7":
                    return;

                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }

            Console.WriteLine("--------------------------------------------------");
            this.TopMenu();
        }

        public void AddRoom() {
            Console.WriteLine("What is the room number?");
            int roomNo = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the room capacity?");
            uint capacity = uint.Parse(Console.ReadLine());

            TD.AddRoom(capacity, roomNo);
        }

    }
}