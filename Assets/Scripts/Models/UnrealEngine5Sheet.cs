using Dictionary;
using Cathei.BakingSheet;
using UnityEngine;

public class UnrealEngine5Sheet : Sheet<string, UnrealEngine5Sheet.Row>
{
    public class Row : SheetRow<string>
    {
        public string Category { get; private set; }
        public string Word { get; private set; }
        public string Description { get; private set; }
    }
}
