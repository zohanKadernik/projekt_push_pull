using MyFirstProgram.Common;

namespace MyFirstProgram.Work.Exercise06_ReadInput_Variable_Decision;

public class Exercise06 : Exercise0101Base
{
    public override void Run()
    {
        #region Step 1
        /*
        1. Copy code from Exercise05
        
        2. Use method 'ReadStringInput' to read input from user, 
        and store this value to variable 'inputText'
        Notice: this method will wait until user writes some text to console and press [enter] key
        
        3. Change code to if user will write word "work", program will write output as below
        
        Output:
        
        #######################
        My first program started
        Enter text: <user input>
        I am doing work
        I am doing work
        I am doing work
        I am doing work
        I am doing work
        My first program finished
        #######################
        
        if user will write some other word, program will write output as below
        
        Output:
        
        #######################
        My first program started
        Enter text: <user input>
        My first program finished
        #######################
        
        */
        #endregion
        #region Step 2
        /*
        Run test Exercise06
        */
        #endregion
        #region Step 3
        /*
        Questions:
        1. What is variable?
        2. What for are decision good?
        3. When variable stops exists?
        4. What is difference between variable and parameter?
        */
        #endregion

        WriteApplicationSeparator();
        WriteNewLine();
        Zkratka("started");
        WriteNewLine();

        string inputText = ReadStringInput();

        if (inputText == "work")
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
    }

    private void WriteApplicationSeparator()
    {
        WriteWord("##############################");
    }
}
