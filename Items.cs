
namespace API
{
    public record Item
    {
        public string? Id { get; init; }

        public string? Type { get; set; }
        public Name? Name { get; set; }

        public Version? version { get; init; }


    }

    public record Name
    {
        public string? value { get; set; }
        public string type { get; set; } = "String";
    }

    public record Version
    {   
        public float value { get; set; }
        public string type { get; set; } = "Float";
    }

}

