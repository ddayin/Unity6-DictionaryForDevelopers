using UnityEngine;
using Cathei.BakingSheet;

namespace Dictionary
{
    public class GeneralSheet : Sheet<GeneralSheet.Row>
    {
        public class Row : SheetRow
        {
            public string Category { get; private set; }
            public string Word { get; private set; }
            public string Description { get; private set; }
        }
    }
}