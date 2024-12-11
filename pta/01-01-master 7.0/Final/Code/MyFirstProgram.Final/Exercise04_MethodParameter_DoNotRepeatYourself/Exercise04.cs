using MyFirstProgram.Common;

namespace MyFirstProgram.Final.Exercise04_MethodParameter_DoNotRepeatYourself;

public class Exercise04 : Exercise0101Base
{
    public override void Run()
    {
        #region Step 1
        /*
        1. Copy code from Exercise03
        
        2. If u will take a look, there is violated "Do not repeat yourself" (DRY) principle,
        find the problem and fix it by adding new method 'WriteApplicationLine' with parameter 
        */
        #endregion
        #region Step 2
        /*
        Run test Exercise04
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
        WriteWord("#######################");
        WriteNewLine();
    }
}