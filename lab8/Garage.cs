using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{

class Garage
    {
        public List <Car> myCars = new List <Car>();

        public void AddNewCar()
        {
            string name;
            string color;
            int speed;
            int year;

            Console.Write("\nВведите имя: ");
            name = Console.ReadLine();
            
            Console.Write("Введите цвет: ");
            color = Console.ReadLine();

            Console.Write("Введите  скорость: ");
            while(!int.TryParse(Console.ReadLine(), out speed) || speed<=0)
            {
                Console.Write("Введите правильно: ");
            }

            Console.Write("Введите год выпуска: "); 
            while (!int.TryParse(Console.ReadLine(), out year) || year > 2020 || year < 1850)
            {
                Console.Write("Введите правильно: ");
            }

            Car newCar = new Car(name, color, speed, year);

            myCars.Add(newCar);
        }

        public void DisplayAllCars()
        {
            int i = 1;
            foreach(Car c in myCars)
            {
                DisplayInfoAboutCar(c);
                i++;
            }
        }

        public void RemoveCar()
        {
            int position;
            Console.Write("Ввдите номер который хотите удалить: ");
            while (!int.TryParse(Console.ReadLine(), out position) || position < 1 || position > myCars.Count)
            {
                Console.Write("Нет автомобиля под этим номером, введите другой: ");
            }
            myCars.RemoveAt(position-1);
            Console.WriteLine("Автомобиль под номером {0} был удалён", position);
        }
       
        public void SearchByOneCharacteristic(char characteristic)
        {
            int i = 0;
            switch (characteristic)
            {
                case 'n':
                    Console.Write("Введите Имя: ");
                    string name = Console.ReadLine();
                    
                    foreach(Car c in myCars)
                    {
                        if (c.Name == name)
                        {
                            DisplayInfoAboutCar(c);
                            i++;
                        }
                        }
                    if (i == 0) Console.WriteLine("Автомобиль не найден.");
                    i = 0;
                    break;

                case 'c':
                    Console.Write("Введите цвет: ");
                    string color = Console.ReadLine();
                    foreach (Car c in myCars)
                    {
                        if (c.Color == color)
                        {
                            DisplayInfoAboutCar(c);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("Автомобиль не найден.");
                    i = 0;
                    break;

                case 's':
                    Console.Write("Введите скорость: ");
                    int speed = Convert.ToInt32(Console.ReadLine());
                    foreach (Car c in myCars)
                    {
                        if (c.Speed == speed)
                        {
                            DisplayInfoAboutCar(c);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("Автомобиль не найден.");
                    i = 0;
                    break;

                case 'y':
                    Console.Write("Введите год: ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    foreach (Car c in myCars)
                    {
                        if (c.YearOfIssue == year)
                        {
                            DisplayInfoAboutCar(c);
                            i++;
                        }
                        }
                    if (i == 0) Console.WriteLine("Автомобиль не найден.");
                    i = 0;
                    break;

                default:
                    Console.WriteLine("Нет такой характеристики");
                    break;
            }

        }

        public void DisplayInfoAboutCar(Car car)
        {
            Console.WriteLine("\nИмя  : {0}\nЦвет  : {1}\nСкорость  : {2}\nГод  : {3}", car.Name, car.Color, car.Speed, car.YearOfIssue);
        }
    }
}
