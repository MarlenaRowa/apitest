namespace API


    {

    public class ItemSub
    {
        public string id { get; set; }
        public string type { get; set; }
        public NameSub name { get; set; }
        public VersionOnRobot versionOnRobot { get; set; }
        public DateTime time_index { get; set; }
    }
    public class NameSub
    {
        public string type { get; set; }
        public string value { get; set; }
        public Metadata metadata { get; set; }
    }


    public class VersionOnRobot
    {
        public string type { get; set; }
        public int value { get; set; }
        public Metadata metadata { get; set; }
    }
    public class Metadata
    {
        public DateCreated dateCreated { get; set; }
        public DateModified dateModified { get; set; }
    }
    public class DateCreated
    {
        public string type { get; set; }
        public DateTime value { get; set; }
    }

    public class DateModified
    {
        public string type { get; set; }
        public DateTime value { get; set; }
    }

}