using MyFirstProgram.Common;

namespace MyFirstProgram.Final.Exercise10_Array;

public class Exercise10 : Exercise0101Base
{
    public override void Run()
    {
        #region Step 1

        /*
        Notice: To be able to work with list of values in C#, u can use 'array' type,
        it is just needed to add '[]' after any type

        Example (there is created array of strings variable with five strings inside):

            string[] arrayOfStrings = ["text1", "text2", "text3", "text4", "text5"];

        2. To method 'Run', rewrite (do not copy-paste) code
        from example and investigate it by debugger
        and write output as bellow
        Notice: to get one string from array od strings, u need to use indexer,
        for example this will return first string from array 'arrayOfStrings[0]'

        Output:

            Array:
            Length: 5
            First: text1
            Second: text2
            Last: text5
            All: text1,text2,text3,text4,text5

        */

        #endregion

        #region Step 2

        /*
        1. Improve output to be as bellow,
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
            All words in array: text1,text2,text3,text4,text5

        */

        #endregion

        #region Step 3

        /*
        1. Change code to read string array from user input,
        and use that input in console output to have output as bellow

        Output:

           Enter words separated by space: <user input> (for example: "I will be the biggest programmer in the world")
           Digging to array:
           Length of array: 8
           First word in array: I
           Second word in array: will
           Last word in array: world
           All words in array: I,will,be,the,biggest,programmer,in,the,world

        */

        #endregion

        #region Step 4

        /*
        Run test Exercise09
        */

        #endregion

        #region Step 5

        /*
        Questions:
        1. What is array and how it can help u to write better code?
        2. What is indexer and what u can do with that?
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
        WriteWords(arrayOfStrings, ",", false);
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
                if (separator == " ")
                {
                    WriteSpace();
                }
                else
                {
                    WriteWord(separator);
                }
            }
        }

        if (isNewLine)
        {
            WriteNewLine();
        }
    }
}