using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI_Evolutionary
{
    public class Courbe
    {
        public List<Point> data {get; set;}

        public Courbe()
        {
            this.data = new List<Point>();
        }

        public void addData()
        {
            string line;
            System.IO.StreamReader file =
                new System.IO.StreamReader("AIdata25.txt");
            while ((line = file.ReadLine()) != null)
            {
                this.addData(line);
            }

            file.Close();
        }

        private void addData(string line)
        {
            var numbers = line.Trim().Split(" ");
            float x = convertTodouble(numbers[0]);
            float y = convertTodouble(numbers[1]);
            this.data.Add(new Point(x, y));
        }

        private float convertTodouble(string X)
        {
            var datas = X.Split("e");

            float x = float.Parse(datas[0].Replace(".", ","));

            int test = datas[1].ElementAt(0).Equals('-') ? -1 : 1;
            x = x * (float)Math.Pow(10, (Convert.ToDouble(datas[1].Substring(1)) * test));

            return x;
        }
    }
}
