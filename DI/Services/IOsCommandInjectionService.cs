namespace DI.Services
{
    public interface IOsCommandInjectionService
    {
        #region Classic
        string Classic(string command, string arguments);

        string ClassicWithProcessStartInfo(string command, string arguments);

        string Classic2(string ip);

        string Classic2WithProcessStartInfo(string ip);

        string ClassicWithPython(string arguments);
        #endregion

        #region Blind
        string Blind(string command);
        string BlindWithArguments(string command, string arguments);
        string Blind2(string command);
        string Blind2WithProcessStartInfo(string command);
        string Blind3(string command, string arguments);
        string Blind3WithProcessStartInfo(string command, string arguments);
        string Blind4(string host);
        string Blind4WithProcessStartInfo(string host);
        #endregion
    }
}
