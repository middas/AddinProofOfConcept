using System.AddIn.Pipeline;

namespace AddinView.V1
{
    [AddInBase]
    public interface IV1
    {
        string GetName();

        void Initialize(ICallback callback);

        void WriteToConsole();
    }
}