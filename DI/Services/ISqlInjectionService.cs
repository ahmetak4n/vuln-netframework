namespace DI.Services
{
    public interface ISqlInjectionService
    {
        #region Union Based

        string UnionBased(string param);

        string UnionBasedWithFormatString(string param);

        string UnionBasedWithSqlDataAdapter(string param);

        #endregion

        #region Error Based

        string ErrorBased(string param);

        string ErrorBasedWithFormatString(string param);

        string ErrorBasedWithSqlDataAdapter(string param);

        #endregion

        #region Boolean Based

        string BooleanBased(string param);

        string BooleanBasedWithFormatString(string param);

        string BooleanBasedWithSqlDataAdapter(string param);

        #endregion

        #region Time Based

        string TimeBased(string param);

        string TimeBasedWithFormatString(string param);

        string TimeBasedWithSqlDataAdapter(string param);

        #endregion
    }
}
