using MyFirstProgram.Common;

namespace MyFirstProgram.Final.Exercise01_WriteOutput_Sequence;

public class Exercise01 : Exercise0101Base
{
    public override void Run()
    {
        #region Step 1
        /*
        1. Write application which will write output as below, 
        you can use only methods 'WriteWord("robot")', 'WriteSpace()', 'WriteNewLine()'
        
        Output:
        
        ***********************
        My first program started
        My first program finished
        ***********************
        
        */
        #endregion
        #region Step 2
        /*
        Run test Exercise01
        */
        #endregion

        WriteWord("***********************");
        WriteNewLine();

        WriteWord("My");
        WriteSpace();
        WriteWord("first");
        WriteSpace();
        WriteWord("program");
        WriteSpace();
        WriteWord("started");
        WriteNewLine();

        WriteWord("My");
        WriteSpace();
        WriteWord("first");
        WriteSpace();
        WriteWord("program");
        WriteSpace();
        WriteWord("finished");
        WriteNewLine();

        WriteWord("***********************");
        WriteNewLine();
    }
}