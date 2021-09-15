namespace DI.Services
{
    public interface IOsCommandInjectionService
    {
        #region Classic
        string Classic(string ip);

        string Classic2(string command);

        string Classic3(string command);

        string ClassicWithPython(string command);
        #endregion

        string Blind(string command);
    }
}
