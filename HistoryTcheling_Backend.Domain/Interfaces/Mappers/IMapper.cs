namespace HistoryTcheling_Backend.Domain.Interfaces.Mappers
{
    public interface IMapper<TSource, TDestination>
    {
        TDestination MapToDestination(TSource source);
        TSource MapToSource(TDestination destination);
    }
}
