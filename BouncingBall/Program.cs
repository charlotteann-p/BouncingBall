using System;

namespace BouncingBall
{
    public class Program
    {
        public static int bouncingBall(double height, double window, double bounce)
        {
            Console.WriteLine("How many times does mom see the ball pass her window?");
            if (window >= height)
            {
                Console.WriteLine("Please enter the mom's window height as a value lower than " + height + ".");
                return 1;
            }
            if (bounce >= 1 || bounce <= 0)
            {
                Console.WriteLine("Please enter the bounce rate as a decimal between 0 and 1.");
                return 1;
            }
            var numberOfPasses = 1;
            while (height > window)
            {
                height = height * bounce;
                if (height > window)
                {
                    numberOfPasses = numberOfPasses + 2;
                }
            }
            Console.WriteLine(numberOfPasses);
            return 0;
        }
        static void Main()
        {
            bouncingBall(77, 67, 0.62);
            bouncingBall(3, 1.5, 0.66);
            bouncingBall(100, 40, 0.66);
            bouncingBall(7, 10, 0.66);
            bouncingBall(3, 1.5, 40);
        }
    }
}
