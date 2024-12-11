using MyFirstProgram.Common;

namespace MyFirstProgram.Final.Practise01_AverageComputer;

public class Practise01 : Exercise0101Base
{
    public override void Run()
    {
        #region Dificult
        /*
        Write 'Average computer' application (watch output) 
        
        1. Write application which will read list of numbers separated by space " "
        for example: "5 3 7 12"
        
        2. Application then will compute average of that numbers and write tou output,
        use method 'double.Parse("5")' to convert string to number
        
        3. Create private method 'ConvertStringArrayToDoubleArray' 
        which will take as parameter array of strings and return array of doubles.
        
        Then create private method 'SumDoubleArray' 
        which will sum numbers and return this sum
        
        Then compute average
        
        4. Check code if it is not contain some code smell or DRY principle violation
           
        5. Run test Practise01
        */
        #endregion

        #region Output
        /*
         
        Welcome in 'Average computer' application
        
        Enter space separated numbers: <user input>
        Average of numbers is: 24.4
        
        Application 'Average computer' finished
        
        */
        #endregion

        WriteWords($"Welcome in '{GetApplicationTitle()}' application");
        WriteNewLine();
        WriteNewLine();

        WriteWords("Enter space separated numbers:");
        WriteSpace();

        string userInput = ReadStringInput();

        string[] stringNumbers = userInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        double[] numbers = ConvertStringArrayToDoubleArray(stringNumbers);

        double sum = SumDoubleArray(numbers);

        double average = sum / numbers.Length;

        WriteWords("Average of numbers is:");
        WriteSpace();
        WriteWord(average);

        WriteNewLine();
        WriteNewLine();

        WriteWords($"Application '{GetApplicationTitle()}' finished");
        WriteNewLine();
    }

    private double[] ConvertStringArrayToDoubleArray(string[] stringNumbers)
    {
        double[] numbers = new double[stringNumbers.Length];

        for (int i = 0; i < stringNumbers.Length; i++)
        {
            string stringNumber = stringNumbers[i];
            double number = double.Parse(stringNumber);
            numbers[i] = number;
        }

        return numbers;
    }

    private double SumDoubleArray(double[] numbers)
    {
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            double number = numbers[i];
            sum = sum + number;
        }
        return sum;
    }

    private string GetApplicationTitle()
    {
        return "Average computer";
    }

    private int GetRandomWordWriteCount()
    {
        return 10;
    }

    private string GetRandomWord(string[] words)
    {
        return words[GetRandomNumber(0, words.Length - 1)];
    }

    private void WriteWords(string message)
    {
        string[] words = message.Split(" ");
        for (int wordIndex = 0; wordIndex < words.Length; wordIndex++)
        {
            string word = words[wordIndex];

            WriteWord(word);

            if (wordIndex < words.Length - 1)
            {
                WriteSpace();
            }
        }
    }
}