namespace PrivateHouseBuilder
{
    internal class Project
    {
        public Project(string name, TypeOfHouse typeOfHouse, int numberOfRooms, int numberOfFloors, float sizeOfHouseInSquareMeters)
        {
            Name = name;
            TypeOfHouse = typeOfHouse;
            NumberOfRooms = numberOfRooms;
            NumberOfFloors = numberOfFloors;
            SizeOfHouseInSquareMeters = sizeOfHouseInSquareMeters;
        }

        public string Name { get; set; }

        public TypeOfHouse TypeOfHouse { get; set; }

        public int NumberOfRooms { get; set; }

        public int NumberOfFloors { get; set; }

        public float SizeOfHouseInSquareMeters { get; set; }
    }
}