using UnityEngine;
using Cathei.BakingSheet;

namespace AssembleWords
{
    public class CsharpSheet : Sheet<CsharpSheet.Row>
    {
        public class Row : SheetRow
        {
            public string Category { get; private set; }
            public string Word { get; private set; }
            public string Description { get; private set; }
        }
    }
}