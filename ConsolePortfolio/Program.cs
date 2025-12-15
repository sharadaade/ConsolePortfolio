using ConsolePortfolio;
using Spectre;
using Spectre.Console;
using Spectre.Console.Extensions;
using System.Threading;


AnsiConsole.WriteLine();
AnsiConsole.Write(new Rule("[bold purple_1] Portfolio - Sharad Aade[/]").Centered());
AnsiConsole.WriteLine();
// Load an image
var SharadImage = new CanvasImage("sharadaade.jpg");
//SharadImage.MaxWidth(2000);
SharadImage.NoMaxWidth();

// Render the image to the console
AnsiConsole.Write(SharadImage);

Waiting w = new Waiting();

// Call LoadName first, then EducationTable
await w.LoadNameAsync();  // Wait for this to complete
await w.EducationTable(); // Then run this

await w.SkillsTable();


Console.ReadKey();
