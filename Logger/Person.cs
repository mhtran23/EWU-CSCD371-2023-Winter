namespace Logger
{
    public record Person : IEntity
    {
        public Guid Id { get; init; }
        public FullName FullName { get; init; }

        string IEntity.Name => FullName.Name;
    }
}
