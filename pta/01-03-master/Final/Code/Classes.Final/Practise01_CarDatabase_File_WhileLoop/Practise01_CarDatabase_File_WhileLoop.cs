using Classes.Common;

namespace Classes.Final.Practise01_CarDatabase_File_WhileLoop;

public class CarDatabase : Exercise0103Base
{
    #region Step 1
    /*
    1. Add to class 'CarDatabase' method with name 'RunAsync', which will write output as below

        Output:

        Enter car name:

    2. Write code which will read string value of car name and store this value to file 'car-database'
    and then will write output as below

        Output:

        Enter car name: Ferrari 550
        Car 'Ferrari 550' was stored

    3. And run test Practise01_Step1
    */
    #endregion
    #region Step 2
    /*
    1. Add while loop to be able to read more cars, when user will not enter car name,
    loop will finish and program will write output as below

       Output:

       Enter car name: Ferrari 550
       Car 'Ferrari 550' was stored

       Car database closed

    2. Run test Practise01_Step2
    */
    #endregion
    #region Step 3
    /*
    1. Add code which will load stored car names from file and write them 
    (only if it is there any) to console, see output as below

        Output:

        Stored cars:
          Ferrari 550

        Enter car name:_

        Car database closed

    2. Run test Practise01_Step3
    */
    #endregion
    #region Step 4
    /*
    Run all tests from Practise01Tests
     */
    #endregion

    public async Task RunAsync()
    {
        var storedCars = await LoadCars();

        WriteCars(storedCars);

        while (true)
        {
            var carName = ReadCarName();
            if (carName == GetExitProgramCharacter())
            {
                break;
            }

            await StoreCarName(carName);
        }

        WriteLine();
        WriteLine("Car database closed");
    }

    private string ReadCarName()
    {
        Write("Enter car name: ");
        var carName = ReadStringInput();
        return carName;
    }

    private static string GetExitProgramCharacter()
    {
        return "";
    }

    private void WriteCars(string[] carNames)
    {
        if (carNames.Length > 0)
        {
            WriteLine("Stored cars:");
            foreach (var carName in carNames)
            {
                WriteLine($"  {carName}");
            }

            WriteLine();
        }
    }

    private async Task<string[]> LoadCars()
    {
        if (IsDatabaseFileCreated())
        {
            return await File.ReadAllLinesAsync(GetDatabaseFileName());
        }

        return [];
    }

    private async Task StoreCarName(string carName)
    {
        string databaseContent;
        if (IsDatabaseFileCreated())
        {
            databaseContent = await File.ReadAllTextAsync(GetDatabaseFileName());
            databaseContent += $"{Environment.NewLine}{carName}";
        }
        else
        {
            databaseContent = carName;
        }
        await File.WriteAllTextAsync(GetDatabaseFileName(), databaseContent);

        WriteLine($"Car '{carName}' was stored");
    }

    private bool IsDatabaseFileCreated()
    {
        return File.Exists(GetDatabaseFileName());
    }

    string GetDatabaseFileName()
    {
        return "car-database";
    }
}