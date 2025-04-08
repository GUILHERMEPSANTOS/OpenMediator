using OpenMediator.Contracts;

namespace OpenMediator;

public class Mediator : ISender
{
    public Task SendAsync(IRequest request, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TResponse> SendAsync<TResponse>(IRequest<TResponse> request, CancellationToken cancellation = default)
    {
        throw new NotImplementedException();
    }
}
