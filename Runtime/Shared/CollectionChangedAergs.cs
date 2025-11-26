using System.Collections.Generic;

namespace TravisRFrench.Common.Runtime.Shared
{
    public class CollectionChangedArgs<TItem>
    {
        public IReadOnlyCollection<TItem> From { get; set; }
        public IReadOnlyCollection<TItem> To { get; set; }
    }
}
