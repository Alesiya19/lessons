using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5456.Models
{
    public class Lesson : IComparable
    {
        public string Lesson1 { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int CompareTo(object o)
        {
            var lesson = o as Lesson;
            if (lesson != null)
            { 
             
                var hourCompare = this.Hour.CompareTo(lesson.Hour);
                if (hourCompare == 0)
                {
                    return this.Minute.CompareTo(lesson.Minute);

                }
                else
                    return this.Hour.CompareTo(lesson.Hour);
            }
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }
}