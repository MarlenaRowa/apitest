using System.ComponentModel.DataAnnotations;

namespace API
{
    public class CreateItem
    {

        public string Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

       public int versionOnRobot{ get; init; }

        
    }
}
