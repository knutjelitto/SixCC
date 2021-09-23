namespace SixCC.Sdk.Earley
{
    public class FromTransition
    {
        public FromTransition(EarleyItem origin, EarleyItem finished)
        {
            Origin = origin;
            Finished = finished;
        }

        public EarleyItem Origin { get; }
        public EarleyItem Finished { get; }

        public override bool Equals(object? obj)
        {
            return obj is FromTransition other
                && Origin.Set.ID == other.Origin.Set.ID
                && Origin.ID == other.Origin.ID
                && Finished.Set.ID == other.Finished.Set.ID
                && Finished.ID == other.Finished.ID;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Origin.Set.ID, Origin.ID, Finished.Set.ID, Finished.ID);
        }

        public override string ToString()
        {
            return $"<{Origin.Set.ID},{Origin.ID}>({Finished.Set.ID},{Finished.ID})";
        }
    }
}
