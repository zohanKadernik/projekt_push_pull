namespace Common.InputOutput;

public interface IOutputWriter
{
    void Write<T>(T value);
    void WriteLine<T>(T? value = default);
    void SignalEndLine();
}