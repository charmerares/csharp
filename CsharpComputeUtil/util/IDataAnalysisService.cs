using System.Collections.Generic;

namespace CsharpComputeUtil.util
{
    public interface IDataAnalysisService
    {
        void CollectDataFromRecord(List<string> recordList);
    }
}