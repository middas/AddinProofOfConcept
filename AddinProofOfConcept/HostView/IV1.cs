namespace HostView
{
    public interface IV1
    {
        string GetName();

        void WriteToConsole();

        void Initialize(ICallback callback);
    }
}