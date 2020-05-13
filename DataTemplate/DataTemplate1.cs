using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplate
{
    class DataTemplate1
    {
        public string StudentName { get; set; }
        public string StudentNumber { get; set; }
        public double GPA { get; set; }
        public string StudentImage { get; set; }

        public string GPA_Colour
        {
            get
            {
                if (GPA >= 40)
                    return "white";
                else
                    return "red";
            }
        }
    }
}
