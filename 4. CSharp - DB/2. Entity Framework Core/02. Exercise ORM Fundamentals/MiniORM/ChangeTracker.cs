namespace MiniORM
{
    public class ChangeTracker<T>
        where T : class, new()
    {
        private readonly List<T> _allEntities;
        private readonly List<T> _added;
        private readonly List<T> _removed;

        public ChangeTracker(IEnumerable<T> entities)
        {
            if (entities is null) throw new ArgumentNullException(nameof(entities));

            this._added = new List<T>();
            this._removed = new List<T>();
            this._allEntities = CloneEntities(entities).ToList();
        }

        public IReadOnlyCollection<T> Added => _added.AsReadOnly();
        public IReadOnlyCollection<T> Removed => _removed.AsReadOnly();

        private static IEnumerable<T> CloneEntities(IEnumerable<T> entities) 
        {

        }
    }
}