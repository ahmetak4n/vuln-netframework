namespace DI.Services
{
    public interface IOsCommandInjectionService
    {
        void RunOsCommand(string command);
        void RunOsCommandWithProcessParam(string command);
        void RunOsCommandWithStartInfo(string command);
        void RunPythonWithArgs(string args);
    }
}
