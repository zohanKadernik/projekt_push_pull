// See https://aka.ms/new-console-template for more information

using Common.InputOutput;
using MyFirstProgram.Work.Exercise01_WriteOutput_Sequence;
using MyFirstProgram.Work.Exercise02_Method_CodeDuplicity;
using MyFirstProgram.Work.Exercise03_ForLoop;
using MyFirstProgram.Work.Practise01_WordRandomizer;

var exercise = new Exercise03();
exercise.SetInputReader(new ConsoleInputReader());
exercise.SetOutputWriter(new ConsoleOutputWriter());
exercise.Run();