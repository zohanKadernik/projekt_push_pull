using MyFirstProgram.Common;

namespace MyFirstProgram.Final.Exercise05_ForLoopAgain;

public class Exercise05 : Exercise0101Base
{
    public override void Run()
    {
        #region Step 1
        /*
        1. Copy code from Exercise04
        
        2. In method 'WriteSeparator' change code to write exactly 30 '#' characters, it is hard to count right?
        Try to Change code to be easy to change count of separator characters
        */
        #endregion
        #region Step 2
        /*
        Run test Exercise05
        */
        #endregion

        WriteSeparator();

        WriteApplicationLine("started");

        WriteWorkLoop();

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

    private void WriteWorkLoop()
    {
        for (int i = 0; i < 9; i++)
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