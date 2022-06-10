namespace API
{

        public record ItemDto
        {
            public string Id { get; init; }

            public string Type { get; set; }
            public string Name { get; init; }

            public int versionOnRobot { get; init; }


        }

}
