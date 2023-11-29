namespace KT_Interfaces_Kirillov;

interface ILogger
{
    protected ConsoleColor LogTextColor { get; }
    public void PrintLog(string log);
}