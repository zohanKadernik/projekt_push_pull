using MyFirstProgram.Common;

namespace MyFirstProgram.Final.Exercise12_Array;

public class Exercise12 : Exercise0101Base
{
    public override void Run()
    {
        #region Step 1
        /*
        1. Copy code from Exercise11
         
        2. Change code to read string array from user input,
        and use that input in console output to get output as bellow

        Output:

           Enter words separated by space: <user input> (for example: "I will be the biggest programmer in the world")
           Digging to array:
           Length of array: 8
           First word in array: I
           Second word in array: will
           Last word in array: world
           All words in array: I, will, be, the, best, programmer, in, the, world

        */
        #endregion

        #region Step 2
        /*
        Run test Exercise12
        */
        #endregion

        string userInput = ReadStringInput();
        string[] arrayOfStrings = userInput.Split(" ");

        WriteSentence("Digging to array:", " ", true);
        WriteSentence($"Length of array: {arrayOfStrings.Length}", " ", true);
        WriteSentence($"First word in array: {arrayOfStrings[0]}", " ", true);
        WriteSentence($"Second word in array: {arrayOfStrings[1]}", " ", true);
        WriteSentence($"Last word in array: {arrayOfStrings[arrayOfStrings.Length - 1]}", " ", true);
        WriteSentence("All words in array: ", " ", false);
        WriteWords(arrayOfStrings, ", ", false);
    }

    private void WriteSentence(string message, string separator, bool isNewLine)
    {
        string[] words = message.Split(" ");
        WriteWords(words, separator, isNewLine);
    }

    private void WriteWords(string[] words, string separator, bool isNewLine)
    {
        for (int wordIndex = 0; wordIndex < words.Length; wordIndex++)
        {
            string word = words[wordIndex];
            if (word != "")
            {
                WriteWord(word);
            }

            if (wordIndex < words.Length - 1)
            {
                for (int separatorIndex = 0; separatorIndex < separator.Length; separatorIndex++)
                {
                    char separatorCharacter = separator[separatorIndex];
                    if (separatorCharacter == ' ')
                    {
                        WriteSpace();
                    }
                    else
                    {
                        WriteWord(separatorCharacter);
                    }
                }
            }
        }

        if (isNewLine)
        {
            WriteNewLine();
        }
    }
}