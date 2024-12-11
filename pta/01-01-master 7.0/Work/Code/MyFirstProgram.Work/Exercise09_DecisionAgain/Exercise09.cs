using MyFirstProgram.Common;

namespace MyFirstProgram.Work.Exercise09_DecisionAgain;

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

        WriteApplicationSeparator();
        WriteNewLine();
        Zkratka("started");
        WriteNewLine();

        string inputText = ReadStringInput();



        if (inputText == "work")
        {
            int inputNumber = ReadIntInput();

            for (int i = 0; i < inputNumber; i++)
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

        else 
        { 
                WriteWord("I");
                WriteSpace();
                WriteWord("am");
                WriteSpace();
                WriteWord("not");
                WriteSpace();
                WriteWord("doing");
                WriteSpace();
                WriteWord("work");
                WriteNewLine();
        }

        Zkratka("finished");
        WriteNewLine();
        WriteApplicationSeparator();
        WriteNewLine();
    }

    private void Zkratka(string status)
    {
        WriteWord("My");
        WriteSpace();
        WriteWord("first");
        WriteSpace();
        WriteWord("program");
        WriteSpace();
        WriteWord(status);
    }

    private void WriteApplicationSeparator()
    {
        for (int i = 0; i < 31; i++)
        {
            WriteWord("#");
        }
    }
}