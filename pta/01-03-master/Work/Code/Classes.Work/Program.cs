// See https://aka.ms/new-console-template for more information

using Classes.Work.Exercise01_EmptyClass_Namespace;
using Classes.Work.Practise01_CarDatabase_File_WhileLoop;
using Common.InputOutput;
using System.Reflection.Metadata;

using Classes.Work.Exercise01_EmptyClass_Namespace;
using Classes.Work.Exercise02_MethodWithoutResult;

var carDatabase = new CarDatabase();
carDatabase.SetInputReader(new ConsoleInputReader());
carDatabase.SetOutputWriter(new ConsoleOutputWriter());

carDatabase.RunAsync();