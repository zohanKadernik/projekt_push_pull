using Classes.Common;

namespace Classes.Work.Exercise04_AsyncMethodWithoutResult;

public class WriterAsync : Exercise0103Base
{
    #region Step 1
    /*
    1. To class 'WriterAsync' add public method with name 'WriteFileContentAsync', 
    which will via method 'File.ReadAllLinesAsync("Exercise04_AsyncMethodWithoutResult/Sample.txt")' read file content
    and will write this content to output via method 'WriteLine()'

    Notice: Method must be decorated by words 'async Task' and 'await',
    the rule is simple, when you call some method 'SomeAsync()' you need to add word 'await' before it
    and must replace return type 'void' by 'async Task'

    3. Run test Exercise04
    */
    #endregion
    #region Step 2
    /*
    1. Notice that 'File' class contains many methods for working with files

    2. Change the method 'ReadAllTextAsync' to method 'ReadAllLinesAsync'
    and update code to write same output as was in Step 1

    3. Run test Exercise04
    */
    #endregion

    // todo remove me and add code here
}
