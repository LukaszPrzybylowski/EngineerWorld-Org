namespace EngineerWorld.Model.Forum
{
    public class PageResult<T>
    {     
        public IEnumerable<T> Items { get; set; }
        public int TotalCount { get; set; }
    }
}
