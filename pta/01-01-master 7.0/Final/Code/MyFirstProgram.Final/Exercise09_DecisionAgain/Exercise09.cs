using MyFirstProgram.Common;

namespace MyFirstProgram.Final.Exercise09_DecisionAgain;

public class Exercise09 : Exercise0101Base
{
    public override void Run()
    {
        #region Step 1
        /*
        1. Copy code from Exercise08
        
        2. Change code to if user will write word "work", program will write same output as before
        and if user will write some other word, program will write output as below
        
        Output:
        
        #######################
        My first program started
        I am not doing work
        My first program finished
        #######################
        
        */
        #endregion
        #region Step 2
        /*
        Run test Exercise09
        */
        #endregion

        WriteSeparator();

        WriteApplicationLine("started");

        string inputLine = ReadStringInput();

        if (inputLine == "work")
        {
            int count = ReadIntInput();
            WriteWorks(count);
        }
        else
        {
            WriteWork(false);
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

    private void WriteWorks(int count)
    {
        for (int i = 0; i < count; i++)
        {
            WriteWork(true);
        }
    }

    private void WriteWork(bool isDoingWork)
    {
        WriteWord("I");
        WriteSpace();
        WriteWord("am");
        WriteSpace();
        if (!isDoingWork)
        {
            WriteWord("not");
            WriteSpace();
        }
        WriteWord("doing");
        WriteSpace();
        WriteWord("work");
        WriteNewLine();
    }

    private void WriteSeparator()
    {
        for (int i = 0; i < GetSeparatorCharacterCount(); i++)
        {
            WriteWord("#");
        }
        WriteNewLine();
    }

    private int GetSeparatorCharacterCount()
    {
        return 30;
    }
}