using MyFirstProgram.Common;

namespace MyFirstProgram.Work.Exercise03_ForLoop;

public class Exercise03 : Exercise0101Base
{
    public override void Run()
    {
        #region Step 1
        /*
        1. Copy code from Exercise02 and change code to write output as below
                
        Output:
        
        #######################
        My first program started
        I am doing work
        I am doing work
        I am doing work
        My first program finished
        #######################
        
        */
        #endregion
        #region Step 2
        /*
        1. Change code to write output as below
        
        Output:
        
        #######################
        My first program started
        I am doing work
        I am doing work
        I am doing work
        I am doing work
        I am doing work
        My first program finished
        #######################
        
        */
        #endregion
        #region Step 3
        /*
        Notice: You needed to change code on two places,
        it means that you are repeating same code, to improve code you can use for loop,
        
        1. Change code to write output as below (contains phrase 'I am doing work' nine times)
        
        Output:
        
        #######################
        My first program started
        I am doing work
        I am doing work
        I am doing work
        I am doing work
        I am doing work
        I am doing work
        I am doing work
        I am doing work
        I am doing work
        My first program finished
        #######################
        
        */
        #endregion
        #region Step 4
        /*
        1. Put some breakpoints to code and run program to that breakpoint
        
        2. Run program again and use 'step in', 'step over', 'step up' buttons to go through code

        3. Run program again and use 'Call stack' to orient in code depth
        */
        #endregion
        #region Step 5
        /*
        Run test Exercise03
        */
        #endregion
        #region Step 6
        /*
        Questions:
        1. What for are loops good?
        */
        #endregion

        WriteApplicationSeparator();
        WriteNewLine();
        WriteWord("My");
        WriteSpace();
        WriteWord("first");
        WriteSpace();
        WriteWord("program");
        WriteSpace();
        WriteWord("started");
        WriteNewLine();
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
        WriteWord("My");
        WriteSpace();
        WriteWord("first");
        WriteSpace();
        WriteWord("program");
        WriteSpace();
        WriteWord("finished");
        WriteNewLine();
        WriteApplicationSeparator();
        WriteNewLine();
    }

    private void WriteApplicationSeparator()
    {
        WriteWord("#######################");
    }
}

