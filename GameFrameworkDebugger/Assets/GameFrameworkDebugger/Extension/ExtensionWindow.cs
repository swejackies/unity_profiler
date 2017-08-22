namespace UnityGameFramework.Runtime
{
    public partial class DebuggerComponent
    {
        public void RegisterExtensionWindows()
        {
            RegisterDebuggerWindow("GM", new ExampleWindow());
        }
    }
}
