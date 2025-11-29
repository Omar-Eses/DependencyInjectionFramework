namespace Consumer.ConsoleApp;

public class ConsoleWriter : IConsoleWriter
{
    public void WriteLine(string message)
    {
        Console.WriteLine(message);
    }
}

public interface IConsoleWriter
{
    void WriteLine(string message);
}