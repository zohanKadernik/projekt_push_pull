using MyFirstProgram.Common;

namespace MyFirstProgram.Final.Exercise11_Array;

public class Exercise11 : Exercise0101Base
{
    public override void Run()
    {
        #region Step 1
        /*
        1. Copy code from Exercise10
         
        2. Improve output to be as bellow,
        but 'do not repeat yourself' by writing code like WriteWord, WriteSpace, WriteWord, WriteSpace, WriteWord, ...
        you can create method with name 'WriteSentence' which accepts whole string line (words with spaces) 
        as a parameter with name 'sentence', call of that method will look like this 'WriteSentence("Digging to array:");'
        and you can call method with name 'Split' on that parameter like this 'sentence.Split(" ")',
        this method returns array of strings, in this array will be stored every word from sentence without spaces
        then you know how to write out all words from array ;)

        Output:

            Digging to array:
            Length of array: 5
            First word in array: text1
            Second word in array: text2
            Last word in array: text5
            All words in array: text1, text2, text3, text4, text5

        */
        #endregion

        #region Step 2
        /*
        Run test Exercise11
        */
        #endregion

        string[] arrayOfStrings = ["text1", "text2", "text3", "text4", "text5"];

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