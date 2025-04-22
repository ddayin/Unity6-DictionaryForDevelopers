using Cathei.BakingSheet;

namespace AssembleWords
{
    public class SheetContainerDev : SheetContainerBase
    {
        public SheetContainerDev(Microsoft.Extensions.Logging.ILogger logger) : base(logger) { }

        // property name matches with corresponding sheet name
        // for .xlsx or google sheet, **property name matches with the name of sheet tab in workbook**
        // for .csv or .json, **property name matches with the name of file**
        public AssemblySheet Assembly { get; private set; }
        public CplusSheet Cplus { get; private set; }
        public CsharpSheet Csharp { get; private set; }
        public CSheet C { get; private set; }
        public MySQLSheet MySQL { get; private set; }
        public DirectXSheet DirectX { get; private set; }
        public GeneralSheet General { get; private set; }
        public PythonSheet Python { get; private set; }
        public NodeJSSheet NodeJS { get; private set; }
        public TOEFLSheet TOEFL { get; private set; }
        public TOEICSheet TOEIC { get; private set; }
        public UnrealEngine5Sheet UnrealEngine5 { get; private set; }
        public Unity6Sheet Unity6 { get; private set; }
        public WebSheet Web { get; private set; }
    }
}