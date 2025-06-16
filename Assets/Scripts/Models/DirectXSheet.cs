using Cathei.BakingSheet;
using UnityEngine;

namespace Dictionary
{
    public class DirectXSheet : Sheet<string, DirectXSheet.Row>
    {
        public class Row : SheetRow<string>
        {
            public string Category { get; private set; }
            public string Word { get; private set; }
            public string Description { get; private set; }
        }
    }
}