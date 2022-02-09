namespace Six.Sax.Sema
{
    public interface Container
    {
        Module Module { get; }

        IReadOnlyList<Entity> Entities { get; }
        void Add(Entity entity);
    }
}
