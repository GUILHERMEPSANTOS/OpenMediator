namespace OpenMediator.Contracts;


public interface IRequestBase { }
 
public interface IRequest : IRequestBase;

public interface IRequest<out TResponse> : IRequestBase { } 
