using MyFirstProgram.Common;

namespace MyFirstProgram.Final.Exercise07_ReadNumericInput;

public class Exercise07 : Exercise0101Base
{
    public override void Run()
    {
        #region Step 1
        /*
        1. Copy code from Exercise06
        
        2. Change code to if user will write word "work",
        program will wait for number input from user 
        via method 'ReadIntInput' and store this value to variable 'inputNumber', 
        then program will repeat phrase 'I am doing work' same times as the number value
        if user will write some other word, program will write output as below

        Notice: this method will wait until user writes some number to console and press [enter] key
        
        Output:
        
        #######################
        My first program started
        My first program finished
        #######################
        
        */
        #endregion
        #region Step 2
        /*
        Run test Exercise07
        */
        #endregion

        WriteSeparator();

        WriteApplicationLine("started");

        string inputLine = ReadStringInput();

        if (inputLine == "work")
        {
            int count = ReadIntInput();
            WriteWork(count);
        }

        WriteApplicationLine("finished");

        WriteSeparator();
    }

    private void WriteApplicationLine(string action)
    {
        WriteWord("My");
        WriteSpace();
        WriteWord("first");
        WriteSpace();
        WriteWord("program");
        WriteSpace();
        WriteWord(action);
        WriteNewLine();
    }

    private void WriteWork(int count)
    {
        for (int i = 0; i < count; i++)
        {
            WriteWord("I");
            WriteSpace();
            WriteWord("am");
            WriteSpace();
            WriteWord("doing");
            WriteSpace();
            WriteWord("work");
            WriteNewLine();
        }
    }

    private void WriteSeparator()
    {
        for (int i = 0; i < 30; i++)
        {
            WriteWord("#");
        }
        WriteNewLine();
    }
}