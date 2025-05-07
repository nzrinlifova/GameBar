namespace GameBar.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public List<TrendingGame>TrendingGames { get; set; }
    }
}
