using System.Collections.Generic;
using CsharpComputeUtil.domain;

namespace CsharpComputeUtil.util
{
    public interface IDataParseService
    {
        /*
         * get record from specific path file
         */
        List<Record> GetRecordListByPath(string filePath);
        
        /*
         * validate the record file
         */
        bool ValidateRecordSaveFile(string filepath);

        /**
         * parse record from line string
         */
        Record ParseStringToRecord(string recordString);
        
    }
}