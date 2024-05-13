namespace BorderControl.Models
{
    public class BorderControl
    {
        private List<BaseEntity> entities;
        public List<BaseEntity> Entities { get => entities; }

        public BorderControl()
        {
            entities = new List<BaseEntity>();
        }

        public void AddEntityCheck(BaseEntity entity)
        {
            entities.Add(entity);
        }

    }
}
