using System.Collections.Generic;
using BerryAIGC.Common;

namespace BerryAIGC.Toolkit.Configuration;

public interface IScanOptions
{
    string FileExtensions { get; set; }

    bool StoreMetadata { get; set; }

    bool StoreWorkflow { get; set; }
    bool ScanUnavailable { get; set; }
}







