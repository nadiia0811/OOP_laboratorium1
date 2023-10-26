using System;

class Test
{
    static void Main(string[] args)
    {

        //task 1
        double inputDouble()
        {
            Console.WriteLine("Input value: ");
            double val = Convert.ToDouble(Console.ReadLine());
            return val;
        }

        void quadraticEquation()
        {
            double a = inputDouble(), b = inputDouble(), c = inputDouble();
            double x1, x2;

            double delta = Math.Pow(b, 2) - (4 * a * c);
            if (delta > 0)
            {
                x1 = ((-b) - Math.Sqrt(delta)) / (2 * a);
                x2 = ((-b) + Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            }
            else if (delta == 0)
            {
                x1 = (-b) / (2 * a);
                Console.WriteLine($"x1 = x2 = {x1}");
            }
            else
            {
                Console.WriteLine("There is no solutions");
            }
        }

       // quadraticEquation();




        //task 2
        void calculate()
        { 
            double num1 = inputDouble(), num2 = inputDouble();           
            Console.WriteLine("Input number of operation: "); 

            Console.WriteLine("====== 1.Sum ======");
            Console.WriteLine("====== 2.Subtruction ======");
            Console.WriteLine("====== 3.Multiplying ======");
            Console.WriteLine("====== 4.Division ======");
            Console.WriteLine("====== 5.Degree ======");
            Console.WriteLine("====== 6.Square root ======");
            Console.WriteLine("====== 7.Sinus ======");
            Console.WriteLine("====== 8.Cosine ======");
            Console.WriteLine("====== 9.Tangent ======");
            Console.WriteLine("====== 10.EXIT ======");
            Console.WriteLine();

            
            int operation = Convert.ToInt32(Console.ReadLine());
            double result;

            void printResult()
            {
                Console.WriteLine($"The result is: {result}");
            }
    
            switch(operation)
            {
                case 1:
                    result = num1 + num2;
                    printResult();
                    break;
                case 2:
                    result = num1 - num2;
                    printResult();
                    break;
                case 3:
                    result = num1 * num2;
                    printResult();
                    break;
                case 4:
                    result = num1 / num2;
                    printResult();
                    break;
                case 5:
                    result = Math.Pow(num1, num2);
                    printResult();
                    break;
                case 6:
                    result = Math.Sqrt(num1);
                    printResult();
                    break;
                case 7:
                    result = Convert.ToDouble((Math.Sin(num1 * (180 / Math.PI))).ToString("0.00"));
                    printResult();
                    break;
                case 8:
                    result = Convert.ToDouble((Math.Cos(num1 * (180 / Math.PI))).ToString("0.00"));
                    printResult();
                    break;
                case 9:
                    result = Convert.ToDouble((Math.Tan(num1 * (180 / Math.PI))).ToString("0.00"));
                    printResult();
                    break;
                case 10:
                    Console.WriteLine("Exit...Press any key");
                    return;
            }
        }

        //calculate();



        //task 3
        double[] arr = new double[10];

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter a number:");
            double num = Convert.ToDouble(Console.ReadLine());
            arr[i] = num;
        }

        void printArrayValues()
        {
            foreach (double val in arr)
            {
                Console.WriteLine(val);
            }
        }

        //printArrayValues();

        Console.WriteLine();

        void printReverseArrayIndexes()
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }

        //printReverseArrayIndexes();


        void printEvenArrayIndexes()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

        //printEvenArrayIndexes();


        void printOddArrayIndexes()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

        //printOddArrayIndexes();




        //task 4
        double[] arr2 = new double[10];

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter a number:");
            double num = Convert.ToDouble(Console.ReadLine());
            arr2[i] = num;
        }

        double sum(double[] array)
        {
            double sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        //double res = sum(arr2);
        //Console.WriteLine(res);



        void multiply(double[] array)
        {
            double result = 1;
            for (int i = 0; i < array.Length; i++)
            {
                result *= array[i];
            }
            Console.WriteLine(result);
        }

        //multiply(arr2);


        void average(double[] array)
        {
            double result;
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            result = sum / array.Length;
            Console.WriteLine(result);
        }

        //average(arr2);



        void min(double[] arr)
        {
            double min = double.PositiveInfinity;
            for(int i = 0; i < arr.Length;i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"Min value in array is: {min}");
        }

        //min(arr2);



        void max(double[] arr)
        {
            double max = double.NegativeInfinity;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"Max value in array is: {max}");
        }

        //max(arr2);



        //task 5
        void printArrayUsingContinue()
        {
            double[] arr = new double[21];
            for (int i = 20,j = 0; i >= 0; i--, j++)
            {
                arr[j] = i;
            }

            foreach (double val in arr)
            {
                if (val == 2 || val == 6 || val == 9 || val == 15 || val == 19) continue;
                Console.WriteLine(val);
            }
        }

        //printArrayUsingContinue();




        //task 6
        while (true)
        {
            Console.WriteLine("Enter a number: ");
            double value = Convert.ToDouble(Console.ReadLine());
            if (value < 0) break;
        }



        //task 7 
        void bubbleSort()
        {
            Console.WriteLine("Enter positive number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0 || num == 0) return;
            double[] arr = new double[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter any number: ");
                double val = Convert.ToDouble(Console.ReadLine());
                arr[i] = val;
            }


            double temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach (double p in arr)
            {
                Console.Write(p + " ");
            }
        }

        bubbleSort();
            

}
}
       
        




