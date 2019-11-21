﻿using CodeBlogFitness.BL.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace CodeBlogFitness.BL.Controller
{
    /// <summary>
    /// Контроллер пользователя
    /// </summary>
    public class UserController
    {
        /// <summary>
        /// Пользователь приложения
        /// </summary>
        public User User { get; }
        /// <summary>
        /// Создание нового контроллера пользоввателя
        /// </summary>
        /// <param name="user"></param>
        
        public UserController (string userName, string genderName, DateTime birdthDay,double weight, double height)
        {
            //TODO Проверка
            var gender = new Gender(genderName);
            User = new User(userName, gender, birdthDay, weight, height);
        }
        /// <summary>
        /// Сохранить данные пользователя
        /// </summary>
                public void Save()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }
        /// <summary>
        /// Получить данные пользователя
        /// </summary>
        /// <returns>Пользователь приложенияя</returns>
        public UserController()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if (formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }
                //TODO что делать, если пользователя не прочитали
            }
        }

    }
}
