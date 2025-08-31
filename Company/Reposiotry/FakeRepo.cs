namespace Company.Reposiotry
{
    public class FakeRepo : IFakeRepo
    {
        public FakeRepo()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
    }
}
