namespace Logger
{
    public abstract class RecordsEntity : IEntity
    {
        public Guid Id { get; init; }
        public abstract string Name { get; }
    }
}
