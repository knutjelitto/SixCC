namespace Six.Ast
{
    public abstract class Expression
    {
        //protected Expression()
        //{
        //}

        protected Expression(ILocation? location)
        {
            Location = location;
        }

        public abstract bool IsAtomic { get; }
        public virtual bool IsCompact => this is Compact;

        public ILocation? Location { get; set; }

        /// <summary>
        /// true, if this is structural a regex.
        /// </summary>
        public bool IsRegex { get; set; }

        /// <summary>
        /// true, if this expression is only used in compact rules
        /// </summary>
        public bool IsFragment { get; set; }

        public abstract string ToName();
    }
}
