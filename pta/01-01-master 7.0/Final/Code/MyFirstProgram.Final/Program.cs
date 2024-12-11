// See https://aka.ms/new-console-template for more information

using Common.InputOutput;
using MyFirstProgram.Final.Exercise01_WriteOutput_Sequence;
using MyFirstProgram.Final.Exercise02_Method_CodeDuplicity;
using MyFirstProgram.Final.Practise01_WordRandomizer;

var exercise = new Exercise02();
exercise.SetInputReader(new ConsoleInputReader());
exercise.SetOutputWriter(new ConsoleOutputWriter());
exercise.Run();