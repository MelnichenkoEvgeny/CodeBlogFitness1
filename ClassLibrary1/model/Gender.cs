using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBlogFitness.BL.model
{
    [Serializable]
    /// <summary>
    /// Пол.
    /// </summary>
    public class Gender
    {
        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Созадать новый пол.
        /// </summary>
        /// <param name="name">Имя пола</param>

        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя поля не может быть пустым", nameof(name));
            }
            Name = name;
        }

            public override string ToString()
        {
            return Name;
        }
    }
    }
