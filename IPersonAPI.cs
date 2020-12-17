namespace RestEaseWorker
{
    using System.Threading.Tasks;
    using RestEase;

    public interface IPersonAPI
    {
        [Get("workers?sections=workers,staffing")]
        Task<string> GetWorkersAsync([Query] int count = 999);
    }
}