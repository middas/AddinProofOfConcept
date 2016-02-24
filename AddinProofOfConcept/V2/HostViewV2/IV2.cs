namespace HostViewV2.V2
{
    public interface IV2
    {
        string GetName();

        void Initialize(ICallbackV2 callback);

        void WriteToConsole(string output);
    }
}