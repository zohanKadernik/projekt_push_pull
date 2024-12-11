using MyFirstProgram.Common;

namespace MyFirstProgram.Work.Practise01_WordRandomizer;

public class Practise01 : Exercise0101Base
{
    public override void Run()
    {
        #region Dificult
        /*
        Write 'Word randomizer' application (watch output) 
        
        1. Write application which will read list of texts separated by comma ","
        for example: "one,two,three,four"
        
        2. Application then will write one random word,
        use method 'GetRandomNumber' to obtain random number in specified range
        
        3. Update code to write random word ten times,
        but application will wait until user will hit [enter] to show next word
                  
        4. Check code if it is not contains som code smell or DRY principle violation
           
        5. Run test Practise01   
        */
        #endregion
        #region Medium
        /*
        Write 'Word randomizer' application (watch output)

        1. Write application which will read list of texts separated by comma ","
        for example: "one,two,three,four"
        - to be able to work with words independently, we need to split them to array of words
        
        2. Application will write one random word,
        use method 'GetRandomNumber' to obtain random number in specified range
        - to be able to select word via random number, 
          pass this random number to array of words indexer,
          it will return random word
        
        3. Update code to write random word ten times,
        but application will wait until user will hit [enter] to show next word
        - add 'for' loop and 'ReadStringInput' method to the loop
           
        4. Check code if it is not contains som code smell or DRY principle violation
        
        5. Run test Practise01   
        */
        #endregion
        #region Easy
        /*
        Write 'Word randomizer' application (watch output)

        1. Write application which will read list of texts separated by comma ","
        for example: "one,two,three,four"
        - to be able to work with words independently, 
          we need to store input to 'string' variable 'inputWords'
          then we need to split 'inputWords' to array of words by comma ","
          and store result to 'string[]' variable 'words'
        
        2. Application will write one random word,
        use method 'GetRandomNumber' to obtain random number in specified range
        - assign result from method 'GetRandomNumber' to 'int' variable 'randomNumber',
          to be able to select word via random number from 'words' variable,
          pass this random number to 'words' variable indexer like 'words[randomNumber]',
          the indexer will return random word, which u can write to output

        3. Update code to write random word ten times,
        but application will wait until user will hit [enter] to show next word
        - add 'for' loop with ten repetitions and 'ReadStringInput' method to the loop,
          this method will wait until user will hit [enter]
                
        4. Check code if it is not contains som code smell or DRY principle violation
           
        5. Run test Practise01   
        */
        #endregion
        #region Output
        /*
         
        Welcome in 'Word randomizer' application
        Enter comma separated words: <user input">
        Starting word randomizer, hit key [enter]...
        two
        four
        three
        one
        
        Application 'Word randomizer' finished
        
        */
        #endregion

        // todo remove me and add code here
    }
}
