

namespace API
{
    public class InMemItemsRepository : IItemsRepository
    {


        private readonly List<Item> items = new()

        {

            new Item { Id = "Blasius1", Type = "Program", Name = "blasius1", versionOnRobot = 1 },

            new Item { Id = "Blasius2", Type = "Program", Name = "blasius2", versionOnRobot = 1 },

            new Item { Id = "Blasius5", Type = "Program", Name = "blasius5", versionOnRobot = 1 }
        };

        public IEnumerable<Item> GetItems()
        {
            return items;

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


    }


}

