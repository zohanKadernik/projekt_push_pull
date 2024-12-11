using MyFirstProgram.Common;

namespace MyFirstProgram.Work.Exercise07_ReadNumericInput;

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
        WriteWord("##############################");
    }
}