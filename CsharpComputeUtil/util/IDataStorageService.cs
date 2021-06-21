using System.Collections.Generic;
using CsharpComputeUtil.domain;

namespace CsharpComputeUtil.util
{
    public interface IDataStorage
    {
        /*
         * save the record to SQL server
         */
        void SaveRecord(List<Record> recordList);
        /**
         * get record by primary ID
         */
        Record GetRecordById(string id);
        /**
         * get record by some param
         */
        List<Record> GetRecordByString(string param);
    }
}