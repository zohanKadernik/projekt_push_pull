using MyFirstProgram.Common;

namespace MyFirstProgram.Final.Exercise02_Method_CodeDuplicity;

public class Exercise02 : Exercise0101Base
{
    public override void Run()
    {
        #region Step 1
        /*
        1. Copy code from Exercise01 and change code to write output as below
        
        Output:
        
        -----------------------
        My first program started
        My first program finished
        -----------------------
        
        */
        #endregion
        #region Step 2
        /*
        Notice: You needed to change code on two places,
        it means that you have "Code Duplicity" code smell in your code,
        fix "Code Duplicity" code smell by adding same code to new method with name 'WriteSeparator'
        and then update code to write output as below
        Code duplicity is one of the biggest "Technical depth" cause
        
        1. Change code to write output as below

        Output:
        
        #######################
        My first program started
        My first program finished
        #######################
        
        */
        #endregion
        #region Step 3
        /*
        Run test Exercise02
        */
        #endregion
        #region Step 4
        /*
        Questions:
        1. What are code smells?
        2. What is code duplicity?
        3. What code duplicity causes to program maintenance?
        4. What is technical depth?
        5. How method can help with code duplicity?
        */
        #endregion

        WriteSeparator();
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

        WriteSeparator();
        WriteNewLine();
    }

    private void WriteSeparator()
    {
        WriteWord("#######################");
    }
}