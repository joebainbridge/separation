using System.Diagnostics.CodeAnalysis;

namespace Separation.Data.Records
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class StudentRecord
    {
        public string anumber { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }
    }
}
