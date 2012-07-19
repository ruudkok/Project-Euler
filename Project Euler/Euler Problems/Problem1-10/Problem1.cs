namespace Euler_Problems.Problem1_10
{
    public class Problem1
    {
        public static int CalculateSumOfMultiplesOfTheeAndFive(int maximum)
        {
            int sum_of_three = 0,
                sum_of_five = 0,
                sum_of_fifteen = 0,
                multiples_of_three = 3,
                multiples_of_five = 5,
                multiples_of_fifteen = 15;


            while (multiples_of_three < maximum)
            {
                sum_of_three += multiples_of_three;
                multiples_of_three += 3;
            }

            while (multiples_of_five < maximum)
            {
                sum_of_five += multiples_of_five;
                multiples_of_five += 5;
            }

            // 3x5 = 15 and 5x3 = 15. Fifteen is in each while loop, so it's counted twice. 
            // We need to substract one count of the sum of all fifteens below the maximum
            while (multiples_of_fifteen < maximum)
            {
                sum_of_fifteen += multiples_of_fifteen;
                multiples_of_fifteen += 15;
            }

            return sum_of_three + sum_of_five - sum_of_fifteen;
        }
    }
}