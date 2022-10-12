namespace Day8LineComparisonProblem
{
    public class LineComparison
    {
        //variables
        public double length_Of_Line;

        //method for calculation
        public void Calc(double x1, double y1, double x2, double y2)
        {
            double X = Math.Pow(x2 - x1, 2.0);
            double Y = Math.Pow(y2 - y1, 2.0);
            length_Of_Line = Math.Sqrt(X + Y);
        }

    }
    public class Program
    {
        public static void Main(String[] args)
        {
            //line 1 object creating and reading input from user
            LineComparison lc = new LineComparison();
            Console.WriteLine("enter x1,y1,x2,y2 values");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            lc.Calc(a, b, c, d);
            Console.WriteLine("Line Length is = " + lc.length_Of_Line);

            //line 2 object creating and reading input from user
            Console.WriteLine("Enter Sencond line values x1,y1,x2,y2");
            double e = Convert.ToDouble(Console.ReadLine());
            double f = Convert.ToDouble(Console.ReadLine());
            double g = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());
            LineComparison lc2 = new LineComparison();
            lc2.Calc(e, f, g, h);
            Console.WriteLine("Line 2 Length is = " + lc2.length_Of_Line);

            //compairing by both line values using Equals method
            Console.WriteLine("Checking if the lines are equal, the answer is:");
            Console.WriteLine((lc.length_Of_Line).Equals(lc2.length_Of_Line));
        }

    }
}
