
namespace API
{
    public interface IItemsRepository
    {

        Item GetItem(String id);

        ItemSub GetItemsSub(String id);
        IEnumerable<ItemSub> GetItemsSub();
        void CreateItem(Item item);
        IEnumerable<Item> GetItems();
        void UpdateItem(Item item);
        void CreateItemSub(ItemSub itemSub);


    }
}