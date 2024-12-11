using MyFirstProgram.Common;

namespace MyFirstProgram.Final.Exercise08_MethodResult_MagicNumber;

public class Exercise08 : Exercise0101Base
{
    public override void Run()
    {
        #region Step 1
        /*
        1. Copy code from Exercise07
        
        Notice: this code can be almost considered as the best code in the world, 
        there is only one tiny problem left, if u will take a look to method 'WriteSeparator',
        there is number 30, which is "Magic number" code smell, 
        it means that there is some number flying in the code, and when you see the number, 
        you dont know what that number means
        
        2. Change code to fix "Magic number" code smell 
        by adding 'GetSeparatorCharacterCount' method, and the name of this new method 
        gives you better understanding what that number menas
        */
        #endregion
        #region Step 2
        /*
        Run test Exercise08
        */
        #endregion
        #region Step 3
        /*
        Questions:
        1. What is "Magic number" code smell?
        */
        #endregion
        #region Step 4
        /*
        Congratulate yourself, u was able to write best code possible ;)
        */
        #endregion

        WriteSeparator();

        WriteApplicationLine("started");

        string inputLine = ReadStringInput();

        if (inputLine == "work")
        {
            int count = ReadIntInput();
            WriteWorkLoop(count);
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

    private void WriteWorkLoop(int count)
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