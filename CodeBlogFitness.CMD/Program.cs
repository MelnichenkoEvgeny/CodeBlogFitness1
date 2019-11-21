using CodeBlogFitness.BL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeBlogFitness.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует приложение CodeBlogeFitness");

            Console.WriteLine("Введите имя пользователя");
            var name = Console.ReadLine();

            Console.WriteLine("Введите пол");
            var gender = Console.ReadLine();

            Console.WriteLine("Введите дату рождения");
            var birthdate = DateTime.Parse(Console.ReadLine());//TODO переписать

            Console.WriteLine("Введите вес");
            var weigth = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите рост");
            var height = double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthdate, weigth, height);
            userController.Save();





        }
    }
}
