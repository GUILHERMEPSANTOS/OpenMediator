using OpenMediator.Contracts;

namespace OpenMediator
{
    public interface ISender
    {
        Task SendAsync(IRequest request, CancellationToken cancellationToken = default);

        Task<TResponse> SendAsync<TResponse>(IRequest<TResponse> request, CancellationToken cancellation = default);
    }
}
