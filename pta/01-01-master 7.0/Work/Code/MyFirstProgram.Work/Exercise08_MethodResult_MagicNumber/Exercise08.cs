using MyFirstProgram.Common;

namespace MyFirstProgram.Work.Exercise08_MethodResult_MagicNumber;

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
        for (int i = 0; i < 31; i++)
        {
        WriteWord("#");
        }
    }
}