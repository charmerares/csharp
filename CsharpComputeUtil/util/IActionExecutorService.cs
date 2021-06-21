using System.Threading;

namespace CsharpComputeUtil.util
{
    public interface IActionExecutorService
    {
        /**
         * execute our task in one thread
         */
        void ExecuteTaskBySerialOrder(ParameterizedThreadStart threadStart);

        /**
         * stop our task amd close thread pool
         */
        void ShutdownSerialThreadPool();

        /**
         * wait task finshed and close thread pool
         */
        void ShutdownSerialThreadPoolWait();

        /**
         * execute our task parallelly
         */
        void ExecuteTaskParallel(ParameterizedThreadStart threadStart);
        
        /**
         * stop our task amd close thread pool
         */
        void ShutdownParallelThreadPool();

        /**
         * wait task finshed and close thread pool
         */
        void ShutdownParallelThreadPoolWait();
        
    }
}