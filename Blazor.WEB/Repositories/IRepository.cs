namespace Blazor.WEB.Repositories
{
    public interface IRepository
    {
        Task<HttpResponseWraper<T>> Get<T>(string url);
        Task<HttpResponseWraper<object>> Post<T>(string url, T model);
        Task<HttpResponseWraper<TResponse>> Post<T, TResponse>(string url, T model);
    }
}
