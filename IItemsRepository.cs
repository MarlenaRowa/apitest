
namespace API
{
    public interface IItemsRepository
    {

        Item GetItem(String id);
        void CreateItem(Item item);
        IEnumerable<Item> GetItems();
        void UpdateItem(Item item);

    }
}