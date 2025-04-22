using Cathei.BakingSheet;
using UnityEngine;

namespace AssembleWords
{
    public class CplusSheet : Sheet<string, CplusSheet.Row>
    {
        public class Row : SheetRow<string>
        {
            public string Category { get; private set; }
            public string Word { get; private set; }
            public string Description { get; private set; }
        }
    }
}