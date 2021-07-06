namespace DI.Services
{
    public interface IServerSideRequestForgeryService
    {
        string SyncHttpClient(string path);

        string SyncWebClient(string path);

        string SyncRestClient(string path);
    }
}
