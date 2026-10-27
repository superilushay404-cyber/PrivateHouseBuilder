using System.Transactions;

namespace PrivateHouseBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool needToContinue = true;

            while (needToContinue)
            {
                PrintInfo();
                bool isUserInputParseSuccessful = int.TryParse(Console.ReadLine(), out int userInput);

                if (isUserInputParseSuccessful)
                {
                    if (userInput == 1)
                    {
                        Console.WriteLine("Enter the name of the project:");
                        string nameOfProject = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(nameOfProject))
                        {
                            Console.WriteLine("Enter type of house");
                            string typeOfHouse = Console.ReadLine();

                            TypeOfHouse findedType = GetTypeOfHouse(typeOfHouse);

                            if (findedType != null)
                            {
                                Console.WriteLine("Enter amount of rooms");
                                bool isNumberOfRoomsParseSuccess = int.TryParse(Console.ReadLine(), out int numberOfRooms);

                                if (isNumberOfRoomsParseSuccess == true && numberOfRooms >= 3)
                                {
                                    Console.WriteLine("Enter amount of floors");
                                    bool isNumberOfFloorsParseSuccess = int.TryParse(Console.ReadLine(), out int numberOfFloors);

                                    if (isNumberOfFloorsParseSuccess == true && numberOfFloors >= 1)
                                    {
                                        Console.WriteLine("Enter size of house in square meters");
                                        bool isSizeOfHouseInSquareMetersParseSuccess = float.TryParse(Console.ReadLine(), out float sizeOfHouseInSquareMeters);

                                        if (isNumberOfRoomsParseSuccess == true && sizeOfHouseInSquareMeters >= 15)
                                        {
                                            Project project = new Project(nameOfProject, findedType, numberOfRooms, numberOfFloors, sizeOfHouseInSquareMeters);
                                        }
                                        else if (isNumberOfRoomsParseSuccess == false)
                                        {
                                            Console.WriteLine("Input is not a number");
                                        }
                                        else if (sizeOfHouseInSquareMeters < 15)
                                        {
                                            Console.WriteLine("Size of house cant be less than 15 square meters");
                                        }
                                    }
                                    else if (isNumberOfFloorsParseSuccess == false)
                                    {
                                        Console.WriteLine("Input is not a number");
                                    }
                                    else if (numberOfFloors < 1)
                                    {
                                        Console.WriteLine("Cant be less than 1 floor in a house");
                                    }
                                }
                                else if (isNumberOfRoomsParseSuccess == false)
                                {
                                    Console.WriteLine("Input is not a number");
                                }
                                else if (numberOfRooms < 3)
                                {
                                    Console.WriteLine("Cant be less than 3 rooms in a house");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid project name. Please try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }

        static void PrintInfo()
        {
            Console.WriteLine("Enter 1 to make a project");
        }

        static TypeOfHouse GetTypeOfHouse(string typeOfHouse)
        {
            if (typeOfHouse.Equals("WoodenHouse"))
            {
                return new TypeOfHouse { WoodenHouse = "Wooden House" };
            }
            else if (typeOfHouse.Equals("BrickHouse"))
            {
                return new TypeOfHouse { BrickHouse = "Brick House" };
            }
            else if (typeOfHouse.Equals("CementHouse"))
            {
                return new TypeOfHouse { CementHouse = "Cement House" };
            }
            else
            {
                Console.WriteLine("Invalid type of house. Please try again.");
                return null;
            }
        }
    }
}
