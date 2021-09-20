namespace DI.Services
{
    public interface IServerSideRequestForgeryService
    {
        #region Classic

        string ClassicWithHttpClient(string path);

        string ClassicWithWebClient(string path);

        string ClassicWithRestClient(string path);

        string ClassicWithWebRequest(string path);

        #endregion

        #region Blind

        string BlindWithHttpClient(string path);

        string BlindWithWebClient(string path);

        string BlindWithRestClient(string path);

        string BlindWithWebRequest(string path);

        #endregion
    }
}
