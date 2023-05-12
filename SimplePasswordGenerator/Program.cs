// See https://aka.ms/new-console-template for more information
using SimplePasswordGenerator;

var passwordGenerator = new PasswordGenerator();
passwordGenerator.Greetings();
passwordGenerator.ReadInputs();
passwordGenerator.Generate();
passwordGenerator.WriteGeneratedPasswors();
Console.ReadLine();
return 0;

