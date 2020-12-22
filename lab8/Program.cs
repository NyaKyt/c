using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage myGarage = new Garage();
            int choice;
            do
            {
                if (myGarage.myCars.Count == 0)
                { 
                    Console.WriteLine("[1] - Добавить автомобиль");
                    Console.WriteLine("[0] - Закрыть");
                }
                else
                { 
                    Console.WriteLine("[1] - Добавить автомобиль");
                    Console.WriteLine("[2] - Показать все автомобили");
                    Console.WriteLine("[3] - Удалить автомобиль");
                    Console.WriteLine("[4] - Найти автомобиль по определённому критерию");
                    Console.WriteLine("[0] - Закрыть");
                }
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("выберить правильный вариант: ");
                }
                switch (choice)
                {
                    case 1:
                        myGarage.AddNewCar();
                        Console.WriteLine("Машина добавлена");
                        Console.WriteLine(myGarage.myCars.Count);
                        break;
                    case 2:
                        myGarage.DisplayAllCars();
                        break;
                    case 3:
                        myGarage.RemoveCar();
                        break;
                    case 4:
                        Console.WriteLine("Выберите характеристику: ");
                        char characteristic;
                        Console.WriteLine("[n] - Имя");
                        Console.WriteLine("[c] - Цвет");
                        Console.WriteLine("[s] - Скорость");
                        Console.WriteLine("[y] - Год выпуска");
                        characteristic = Convert.ToChar(Console.ReadLine());
                        myGarage.SearchByOneCharacteristic(characteristic);
                        break;
                    case 0:
                       
                        return;
                    default:
                        Console.WriteLine("Неправильный вариант");
                        break;
                }
            } while(choice != 0);
        }
    }
}
