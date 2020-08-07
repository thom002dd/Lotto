using System;

using System.CodeDom.Compiler;

using System.Collections.Generic;

using System.ComponentModel;

using System.Linq;

using System.Security.Principal;

using System.Text;



namespace Practice

{

    class Program

    {

        static void Main(string[] args)

        {

            //variables

            int temp;

            int temp2;

            int[] lotto = new int[7];

            int[] coupon = new int[7];

            Random random = new Random();



            //fills lotto array with 7 random numbers between 1 and 100

            for (int i = 0; i < lotto.Length; i++)

            {

                do

                {

                    temp = random.Next(1, 100);

                } while (lotto.Contains(temp));

                lotto[i] = temp;

            }   //prints the winning numbers

            Console.WriteLine("The winning numbers are: ");

            for (int j = 0; j < lotto.Length; j++)

            {

                Console.WriteLine(lotto[j] + " ");

            }   //fills coupon array with 7 random numbers between 1 and 100

            for (int k = 0; k < coupon.Length; k++)

            {

                do

                {

                    temp2 = random.Next(1, 100);



                } while (coupon.Contains(temp2));

                coupon[k] = temp2;

            }   //prints coupon

            Console.WriteLine("Your numbers are: ");

            for (int l = 0; l < coupon.Length; l++)

            {

                Console.WriteLine(coupon[l] + " ");

            }   //tells user if they win or not

            if (coupon == lotto)

            {

                Console.WriteLine("Congratulations, you win!");

            }

            else if (coupon != lotto)

            {

                Console.WriteLine();

                Console.WriteLine("You didn't win, better luck next time!");

            }



            Console.ReadKey();

        }

    }

}