using MediatR;

namespace EmployeeProject.MediatR
{
    public interface ISender
    {
        Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default);
        Task<Object?> Send(Object request,CancellationToken cancellationToken = default);

    }

    public interface Publisher
    {
        Task Publish(object notification, CancellationToken cancellationToken = default);
        Task Publish<TNotification>(TNotification notification, CancellationToken cancellationToken = default)
            where TNotification : INotification;
    }
    public interface IMediator:ISender,IPublisher
    {
    }
}
