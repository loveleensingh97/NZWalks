namespace NZWalks.API.Models.DTOs
{
    //mention whatever data properties, we want to expose it to the client
    public class RegionDto
    {
        public Guid Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string? RegionImageUrl { get; set; }
    }
}
