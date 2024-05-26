namespace RepositoryPattern.Entity
{
    public class Product : BaseEntity<int>
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        
    }
}
