namespace Six.Gen.Ebnf
{
    public sealed class Instance : IComparable<Instance>
    {
        public Instance(CoreOp holder, int offset)
        {
            Holder = holder;
            Offset = offset;
        }

        public CoreOp Holder { get; }
        public int Offset { get; }

        public int CompareTo(Instance other)
        {
            if (other.Holder.Id != Holder.Id)
            {
                return Holder.Id.CompareTo(other.Holder.Id);
            }
            return Offset.CompareTo(other.Offset);
        }

        public override bool Equals(object obj)
        {
            return obj is Instance other && other.Holder.Id == Holder.Id && other.Offset == Offset;
        }

        public override int GetHashCode()
        {
            return Holder.GetHashCode() ^ Offset.GetHashCode();
        }
    }
}
