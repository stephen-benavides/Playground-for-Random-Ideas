namespace Advanced.Delegator
{
    public interface ILogger
    {
        void LogInfo(string message);
        void LogError(string message);
    }
}