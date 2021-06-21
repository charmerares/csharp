namespace CsharpComputeUtil.domain
{
    public class Record
    {
        private string recordName;

        public string RecordName
        {
            get => recordName;
            set => recordName = value;
        }

        public override string ToString()
        {
            return $"{nameof(recordName)}: {recordName}";
        }
    }
}