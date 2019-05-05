using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresParkingSimulation
{
    public class Parking
    {
        Stack stack = new Stack(15);
        LinkedList linkedList = new LinkedList();
        Queue queue = new Queue(30);
        Random randomColor = new Random();
        string strLastCar = "";

        public string AddACarToTheParking() // Add 15 vehicles to basement and 2nd floor.
        {
            string randomColor = "";
            string strList = "";
            int addedCars = 0;
            for (int i = 0; i < 30; i++)
            {
                randomColor = RandomCarColorDetermination();
                if (i < 15)
                {
                    AddToTheStack(randomColor, i + 1);
                    addedCars++;
                }
                else
                {
                    AddToTheLinkedList(randomColor, i + 1);
                    addedCars++;
                }
            }
            if (addedCars == 30)
            {
                strList = "All cars have been added to the car park.";
            }
            else
            {
                strList = "An error occurred while adding cars to the car park.";
            }
            return strList;
        }

        private void AddToTheStack(string color, int carNumber) // Basement
        {
            Car car = new Car();
            car.Number = carNumber;
            car.Color = color;
            car.AvailableFloor = "Basement";
            stack.Push(car);
        }

        private void AddToTheLinkedList(string color, int carNumber) // 2nd Floor
        {
            Car car = new Car();
            car.Number = carNumber;
            car.Color = color;
            car.AvailableFloor = "2nd Floor";
            if (linkedList.Head == null)
            {
                linkedList.InsertFirst(car);
            }
            else
            {
                linkedList.InsertLast(car);
            }
        }

        public string CarListing() // List cars in the car park
        {
            string strList = "     Cars in the basement" + Environment.NewLine;
            foreach (Car a in stack.PeekArray())
            {
                strList += "Number " + a.Number + " Car --> Color : " + a.Color + " -- Available Floor : " + a.AvailableFloor + Environment.NewLine;
            }
            strList += linkedList.DisplayElements();
            return strList;
        }

        public string ExitFromTheParking() // 2nd and basement floor cars; -> Added to the queue on the 1st floor. -> The cars are deleted from the stack and the LinkedList.
        {
            Random randomExit = new Random();
            Car car = new Car();
            string strInformation = "";
            int outputPriority = 0;
            int numberOfVehiclesLeavingTheBasement = 0, numberOfVehiclesLeavingThe2ndFloor = 0;
            int numberOfDepartingCar = 0;
            for (int i = 0; i < 30; i++)
            {
                if ((numberOfVehiclesLeavingTheBasement < 15) && (numberOfVehiclesLeavingThe2ndFloor < 15))
                {
                    outputPriority = randomExit.Next(0, 2); //outputPriority variable -> 0 : From the basement floor (Stack), -> 1:  From the 2nd floor (LinkedList) add to the queue. (Thus 50% probability is provided.)
                    if (outputPriority == 0)
                    {
                        car = (Car)stack.Peek();
                        AddCarToTheQueue(car);
                        stack.Pop();
                        numberOfVehiclesLeavingTheBasement++;
                        numberOfDepartingCar++;
                    }
                    else
                    {
                        car = (Car)linkedList.GetElement(0).Data;
                        if (numberOfVehiclesLeavingThe2ndFloor == 14)
                        {
                            strLastCar = "The last car left on the 2nd floor -- > Number : " + car.Number + "-- Color: " + car.Color + "-- Exit floor of the car: " + car.AvailableFloor + Environment.NewLine;
                        }
                        AddCarToTheQueue(car);
                        linkedList.DeleteFirst();
                        numberOfVehiclesLeavingThe2ndFloor++;
                        numberOfDepartingCar++;
                    }
                }
                else if ((numberOfVehiclesLeavingTheBasement < 15) && (numberOfVehiclesLeavingThe2ndFloor == 15))
                {
                    car = (Car)stack.Peek();
                    AddCarToTheQueue(car);
                    stack.Pop();
                    numberOfVehiclesLeavingTheBasement++;
                    numberOfDepartingCar++;
                }
                else if ((numberOfVehiclesLeavingTheBasement == 15) && (numberOfVehiclesLeavingThe2ndFloor < 15))
                {
                    car = (Car)linkedList.GetElement(0).Data;
                    if (numberOfVehiclesLeavingThe2ndFloor == 14)
                    {
                        strLastCar = "The last car left on the 2nd floor -- > Number : " + car.Number + "-- Color: " + car.Color + "-- Exit floor of the car: " + car.AvailableFloor + Environment.NewLine;
                    }
                    AddCarToTheQueue(car);
                    linkedList.DeleteFirst();
                    numberOfVehiclesLeavingThe2ndFloor++;
                    numberOfDepartingCar++;
                }
            }
            if (numberOfDepartingCar == 30)
            {
                strInformation += "   --> All cars in the parking lot are added to the exit queue. Output processes are in progress. <--";
            }
            else
            {
                strInformation = "Unexpected error occurred while adding car to the queue.";
            }
            return strInformation;
        }

        private void AddCarToTheQueue(Car car) // Output queue on 1st floor.
        {
            queue.Insert(car);
        }

        public string QueueListingTheCar()
        {
            int i = 1;
            string strList = "   --> Vehicles in the output queue :" + Environment.NewLine;
            foreach (Car a in queue.Peek())
            {
                strList += "" + i++ + "nd vehicle in queue --> Number : " + a.Number + " -- Color : " + a.Color + " -- Exit floor of the car : " + a.AvailableFloor + Environment.NewLine;
            }
            return strList;
        }

        public string TakeTheCarOutOfTheQueue() // Empty the exit tail from the parking lot.
        {
            Car deletedCar;
            string strList = "   --> Cars coming out of car park :" + Environment.NewLine;
            for (int i = 1; i <= 30; i++)
            {
                deletedCar = (Car)queue.Remove();
                strList += "" + i + "nd car coming out of car park  -->  Number : " + deletedCar.Number + " -- Color : " + deletedCar.Color + " -- Exit floor of the car : " + deletedCar.AvailableFloor + Environment.NewLine;
                if (i == 30)
                {
                    strList += strLastCar;
                }
            }
            if (queue.IsEmpty())
            {
                strList += "	--> Successful exit from the car park. <--";
            }
            else
            {
                strList = "	--> An unexpected error occurred while emptying the car park. <--";
            }
            return strList;
        }

        private string RandomCarColorDetermination() // Produces random colors for cars.
        {
            string[] arrayColor = { "Gray", "Black", "White", "Red", "Blue", "Light Blue", "Purple", "Yellow", "Brown" };
            return arrayColor[randomColor.Next(0, 9)];
        }
    }
}
