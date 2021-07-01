namespace DI.Services
{
    public interface ISqlInjectionService
    {
        string Classic(string param);

        string ClassicWithFormatString(string param);

        string Blind(string param);

        void BlindSecond(string param);
    }
}
