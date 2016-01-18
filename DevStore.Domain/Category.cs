namespace DevStore.Domain
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }


        // Override ToString()
        public override string ToString()
        {
            return this.Title;
        }
    }
}