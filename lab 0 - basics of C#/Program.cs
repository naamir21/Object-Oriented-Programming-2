namespace lab_0___basics_of_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 & 2

            Console.WriteLine("Enter the low number:");
            int lowNum = Convert.ToInt16(Console.ReadLine());

            while (lowNum < 0)
            {
                Console.WriteLine("ERROR - Please enter a positive low number: ");
                lowNum = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("Enter the high number:");
            int highNum = Convert.ToInt16(Console.ReadLine());

            while (highNum < lowNum)
            {
                Console.WriteLine("ERROR - Please enter a high number greater than the low number: ");
                highNum = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine(highNum + " - " + lowNum + " = " + (highNum - lowNum));

            //Task 3
            int arraySize = highNum - lowNum + 1;
            int[] numbersArray = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                numbersArray[i] = lowNum + i;
            }


            string numbersFile = "numbers.txt";
            
            using (StreamWriter writer = new StreamWriter("numbers.txt"))
            {
                for (int i = arraySize - 1; i >= 0; i--)
                {
                    writer.WriteLine(numbersArray[i]);
                }
            }

            string fileContent = File.ReadAllText(numbersFile);
            Console.WriteLine("\nThe list of numbers between " + lowNum + " and " + highNum + " in reverse are:\n" + fileContent);

            //Additional task
            Console.WriteLine("The sum of the listed numbers is: " + numbersArray.Sum());

            //Github ID: naamir21

        }
    }
}