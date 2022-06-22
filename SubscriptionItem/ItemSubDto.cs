namespace API

{

        public class ItemSubDto
    {
            public string id { get; set; }
            public string type { get; set; }
            public NameSubDto name { get; set; }
            public VersionOnRobotDto versionOnRobot { get; set; }
            public DateTime time_index { get; set; }
        }
        public class NameSubDto
        {
            public string type { get; set; }
            public string value { get; set; }
            public MetadataDto metadata { get; set; }
        }


        public class VersionOnRobotDto
        {
            public string type { get; set; }
            public int value { get; set; }
            public MetadataDto metadata { get; set; }
        }
        public class MetadataDto
        {
            public DateCreatedDto dateCreated { get; set; }
            public DateModifiedDto dateModified { get; set; }
        }
        public class DateCreatedDto
        {
            public string type { get; set; }
            public DateTime value { get; set; }
        }

        public class DateModifiedDto
        {
            public string type { get; set; }
            public DateTime value { get; set; }

            //{
            //    public List<Datum> data {get; set;}
            //    public string subscriptionId {get;set;}

            //}

            // public class Datum
            // {
            // public string id {get; set;}
            // public IversionOnRobotSub versionOnRobotSub{get;set;}
            // public string type {get; set;} = "Program";

            // }

            // public class IversionOnRobotSub

            // {
            //     public Metadata metadata {get; set;}
            //     public string type {get; set;} ="Float";
            //     public double value {get; set;}

            // }

            // public class Metadata
            // {

            // }

        }
    }