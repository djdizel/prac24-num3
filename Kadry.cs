using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac24._3
{
    internal class Kadry
    {
        /// <summary>
        /// поля
        /// </summary>
        string fam;
        int age;
        string dol;
        int staj;
        /// <summary>
        /// Инкапсуляция
        /// </summary>
        public string Fam
        {
            get { return fam; }
            set => fam = value;
        }
        public int Age
        {
            get { return age; }
            set { if (value < 16) { age = 16; } else if (value > 60) { age = 60; } else { age = value; } }
        }
        public string Dol
        {
            get { return dol; }
            set => dol = value;
        }
        public int Staj
        {
            get { return staj; }
            set { if (value < 0) { staj = 0; } else if (value > 45) { staj = 45; } else { staj = value; } }

        }
        /// <summary>
        /// Без параметров
        /// </summary>
        public Kadry() { }
        /// <summary>
        /// С параметрами
        /// </summary>
        /// <param name="fam"></param>
        /// <param name="age"></param>
        /// <param name="dol"></param>
        /// <param name="staj"></param>
        public Kadry(string fam, int age, string dol, int staj)
        {
            this.Fam = fam;
            this.Age = age;
            this.Dol = dol;
            this.Staj = staj;
        }
        /// <summary>
        /// метод для вывода значений об объекте.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Фамилия = {Fam}, Возраст = {Age}, Должность = {Dol}, Стаж = {Staj}";
        }
    }
}
