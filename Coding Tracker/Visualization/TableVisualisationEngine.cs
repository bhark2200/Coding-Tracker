using Coding_Tracker.Controller;
using ConsoleTableExt;

namespace Coding_Tracker.Visualization
{
    internal class TableVisualisationEngine
    {
        internal static void CreateVisualTable()
        {
            ConsoleTableBuilder
                .From(CodingController.table)
                .ExportAndWriteLine();
        }
    }
}
