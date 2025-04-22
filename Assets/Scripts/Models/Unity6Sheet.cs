using Cathei.BakingSheet.Examples;
using Cathei.BakingSheet;
using UnityEngine;

namespace AssembleWords
{
    public class Unity6Sheet : Sheet<string, Unity6Sheet.Row>
    {
        public class Row : SheetRow<string>
        {
            public string Category { get; private set; }
            public string Word { get; private set; }
            public string Description { get; private set; }
        }
    }
}