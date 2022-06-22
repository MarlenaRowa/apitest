
namespace API
{
    public class InMemItemsRepository : IItemsRepository
    {


        private readonly List<Item> items = new()
        {

            //new Item { Id = "Blasius1", Type = "Program", Name = "blasius1", versionOnRobot = 1 },

            //new Item { Id = "Blasius2", Type = "Program", Name = "blasius2", versionOnRobot = 1 },

            //new Item { Id = "Blasius5", Type = "Program", Name = "blasius5", versionOnRobot = 1 },
            new Item { Id="Blasius1", Name = new Name { value="blasius1",}, Type="Program", version=new Version { value=1} }
        };

        private readonly List<ItemSub> itemsSub = new()
        {
            new ItemSub
            {
                id = "Blasius3",
                type = "Program",
                name = new NameSub { value = "blasius1" },
                versionOnRobot = new VersionOnRobot{ value = 1 },
                time_index = DateTime.Now,
            }
        };
        // ich weiß nicht was ich habe hier falsch gemacht, ich was sicher es funktionieren aber jetzt fehler kommt 
        //private readonly List<SubItem> subItems = new List<SubItem>()
        //{
        //      new SubItem
        //{
        //    data = new List<Datum>()
        //    {
        //        new Datum()
        //        {
        //            id = "Blasius1",
        //            versionOnRobotSub = new IversionOnRobotSub()
        //            {
        //                metadata = new Metadata(),
        //                value = 1
        //            },
        //            type ="Program"
        //        }
        //    },
        //    subscriptionId = ""
        //},

        //};



        public IEnumerable<Item> GetItems()
        {
            return items;

        }
        public void CreateItemSub(ItemSub itemSub)
        {
            itemsSub.Add(itemSub);
        }

        public void CreateItem(Item item)
        {
            items.Add(item);
        }

        public void UpdateItem(Item item)
        {
            var index = items.FindIndex(existingItem => existingItem.Id == item.Id);
            items[index] = item;
        }

        public Item GetItem(string id)
        {
            {
                return items.Where(item => item.Id == id).SingleOrDefault();


            }
        }


        public IEnumerable<ItemSub> GetItemsSub()
        {
              return itemsSub;
        }

        public ItemSub GetItemsSub(string id)
        {
              return itemsSub.Where(itemSub => itemSub.id == id).SingleOrDefault();

        }
    }


}

