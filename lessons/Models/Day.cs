using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5456.Models
{
    public class Day: ICloneable
    {

        public string Name { get; set; }
        public Lesson[] Lessons { get; set; }
        
        public int Hour { get; set; }
         public int Minute { get; set; }
          //public int Time { get; set; }

        
        public object Clone()
        {
            return new Day() { Name = this.Name, Hour= this.Hour, Minute=this.Minute};
        }
    }
}