using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frm_StudentGrade
{
    internal class Grade_unit
    {

        public string Name;
        public int Chi;
        public int Eng;
        public int Math;
        public string Chinese;
        public string English;
        public string Mathematics;
        
        public int totalponit()
        {
            int total = (Chi + Eng + Math);
            return total;
        }
        public double average()
        {
            double aver = (Chi + Eng + Math) / 3;
            return aver;
        }
        public string maxpoint()
        {
            string max ="";
            int maxGrade = 0;
            /*
            if (Chi > Eng && Eng > Math)
            {
                max = "國文"+Chi.ToString() ;

            }
            else if (Eng > Chi && Chi > Math)
            {
                max = "英文"+Eng.ToString();
            }
            else if (Math > Eng && Eng > Chi)
            {
                max = "數學"+Math.ToString();
            }*/
            
            if(Chi > maxGrade)
            {
                maxGrade = Chi;
                max = "國文";
            }
            if (Eng > maxGrade)
            {
                maxGrade = Eng;
                max = "英文";
            }
            if (Math > maxGrade)
            {
                maxGrade = Math;
                max = "數學";
            }

            max += maxGrade.ToString();

            return max;
        }
        public string minpoint()
        {
            string min = "";
            int minGrade = 100;

            if (Chi < minGrade)
            {
                minGrade = Chi;
                min = "國文";
            }
            if (Eng < minGrade)
            {
                minGrade = Eng;
                min = "英文";
            }
            if (Math < minGrade)
            {
                minGrade = Math;
                min = "數學";
            }
            min += minGrade.ToString();
            return min;
        }

    }
}    

            //public int totalpoint;
            // public int averagepoint;
            //public int maxpoint;
            //public int minpoint;


