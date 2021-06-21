namespace CsharpComputeUtil.util
{
    public interface IPersistInfoService
    {
        /**
         * set save file path first
         */
        bool SetPersistFilePath(string filepath);

        /**
         * save string
         */
        bool PersistStringToFile(string infoString);

        /**
         * remove string
         */
        bool RemoveStringFromFile(string infoString);
    }
}