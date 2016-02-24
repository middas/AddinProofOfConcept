namespace HostView.V1
{
    public interface IV1
    {
        string GetName();

        void Initialize(ICallback callback);

        void WriteToConsole();
    }
}