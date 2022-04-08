using System;

namespace DataAccess
{

    /// <summary>
    /// type of result
    /// </summary>
    public interface IQuery<TResult>
    {
    }
    public interface IQuery
    {

    }
    /// <summary>
    /// Implements Handler for input
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    /// <typeparam name="TQuery"></typeparam>
    public interface IQueryHandler<TQuery, TResult> where TQuery : IQuery<TResult>
    {
        TResult Handle(TQuery query);
    }

    /// <summary>
    /// Implements Query Hander without input
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    public interface IQueryHandler<TResult>
    {
        TResult Handle();
    }

}
