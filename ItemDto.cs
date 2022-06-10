namespace API
{

        public record ItemDto
        {
            public string Id { get; init; }

            public string Type { get; set; }
            public NameDto Name { get; set; }

            public VersionDto version { get; init; }    


        }

    public record NameDto
    {
        public string? value { get; set; }
        public string type { get; set; } = "String";
    }

    public record VersionDto
    {   
        public float value { get; set; }
        public string type { get; set; } = "Float";
    }

}
