using Spectre.Console;

namespace CodeTracker
{
    internal static class DisplayEngine
    {
        public static void DisplayCodingSessions(List<CodingSession> sessions)
        {
            var table = new Table();

            table.AddColumns("[green]ID[/]", "[green]Start Time[/]", "[green]End Time[/]", "[green]Duration[/]").Centered();

            foreach (var session in sessions)
            {
                var sessionProperties = session.GetDisplayFormattedProperties();
                table.AddRow(sessionProperties[0], sessionProperties[1], sessionProperties[2], sessionProperties[3]);
            }

            AnsiConsole.Write(table);
        }
    }
}
