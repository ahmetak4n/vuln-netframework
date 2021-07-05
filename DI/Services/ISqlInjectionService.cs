namespace DI.Services
{
    public interface ISqlInjectionService
    {
        string UnionBased(string param);

        string UnionBasedWithFormatString(string param);

        string UnionBasedSqlDataAdapter(string param);

        void ErrorBased(string param);

        void ErrorBasedWithFormatString(string param);

        void ErrorBasedSqlDataAdapter(string param);

        string BooleanBased(string param);

        string BooleanBasedWithFormatString(string param);

        string BooleanBasedSqlDataAdapter(string param);

        void TimeBased(string param);

        void TimeBasedWithFormatString(string param);

        void TimeBasedSqlDataAdapter(string param);
    }
}
