using System;
using Fitness.BL.Controller;

namespace Fitness.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует приложение");
            Console.WriteLine("Введите имя пользователя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите пол");
            string gender = Console.ReadLine();
            Console.WriteLine("Введите дату рождения");
            var bDate = DateTime.Parse(Console.ReadLine()) ;  // TODO переписать
            Console.WriteLine("Введите вес");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите рост");
            double height = double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, bDate, weight, height);

            //userController.Save();
        }
    }
}
