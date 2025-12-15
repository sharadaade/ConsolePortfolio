using Spectre.Console;
using Spectre.Console.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace ConsolePortfolio
{
    internal  class Waiting
    {
        public async Task LoadNameAsync()
        {
            // Show spinner while loading data
            await AnsiConsole.Status()
                .Spinner(Spinner.Known.Dots)
                .StartAsync("Wait a few second..", async ctx =>
                {
                    // Load your data here
                    await LoadDataAsync();
                });

            // After spinner completes, show the result
            Console.WriteLine();
            AnsiConsole.Write(
                new FigletText("Sharad Aade")
                    .Centered()
                    .Color(Color.Magenta3));
        }
        private async Task LoadDataAsync()
        {
            // Simulate data loading
            await Task.Delay(3000);
        }
        public async Task EducationTable()
        {
            // Title with styling
            AnsiConsole.Write(new Rule("[bold deepskyblue1] EDUCATION BACKGROUND[/]").Centered());
            AnsiConsole.WriteLine();

            var educationTable = new Table();
            educationTable.Border(TableBorder.Double);
            educationTable.BorderColor(Color.Blue);
            educationTable.Title("[bold yellow] Education[/]");

            // Columns with styling
            educationTable.AddColumn(new TableColumn("[bold cyan]Degree/Certification[/]").Centered());
            educationTable.AddColumn(new TableColumn("[bold cyan]Institution[/]").Centered());
            educationTable.AddColumn(new TableColumn("[bold cyan]Year[/]").Centered());
            educationTable.AddColumn(new TableColumn("[bold cyan]Grade/Score[/]").Centered());
            //educationTable.AddColumn(new TableColumn("[bold cyan]Specialization[/]").Centered());

            // Sample data - replace with your actual education
            educationTable.AddRow(
                "[bold blue].NET FullStack Course[/]",
                "[white] Naresh iT[/]",
                "[yellow] Pursuing[/]",
                "[bold green] - [/]");

            educationTable.AddRow(
                "[bold green]Master of Computer Application[/]",
                "[white]SPPU, Maharashtra[/]",
                "[yellow]2024-2025[/]",
                "[bold]7.4/10 SGPA[/]");

            educationTable.AddRow(
                "[bold green]Bachelor of Computer Application[/]",
                "[white]SPPU, Maharashtra[/]",
                "[yellow]2021-2023[/]",
                "[bold]7.9/10 SGPA[/]");

            // Additional certifications
            educationTable.AddRow(
                "[bold orange1]Foundational C# wiht MS[/]",
                "[white]freeCodeCamp[/]",
                "[yellow]2023[/]",
                "[bold]Completed[/]");

            educationTable.AddRow(
                "[bold orange1]Learn HTML[/]",
                "[white]Programiz[/]",
                "[yellow]2025[/]",
                "[bold]Completed[/]");

            AnsiConsole.Write(educationTable.Centered());
            AnsiConsole.WriteLine();
        }
        public async Task SkillsTable()
        {
            AnsiConsole.Write(new Rule("[red bold] SKILLS [/]").Centered());
            Console.WriteLine();
           
            var skillsTable = new Table();
            skillsTable.Border(TableBorder.Double);
            skillsTable.BorderColor(Color.Magenta3);

            skillsTable.Title("[magenta2_1 bold] Skills [/]").Centered();

            AnsiConsole.Write(skillsTable.Centered());
            AnsiConsole.WriteLine();

        }
        public async Task ShowEducationTable()
        {
            // Wait for LoadName to complete
            await LoadNameAsync();

            // Then show the education table
            await EducationTable();
        }
    }
}
