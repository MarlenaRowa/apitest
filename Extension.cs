
using API;

namespace Catalog
{

    public static class Extensions
    {
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto
            {
                Id = item.Id,
                Name = new NameDto { value=item.Name.value},
                //Name = item.Name,
                Type = item.Type,
                version = new VersionDto { value=item.version.value}
                //version = item.version
            };

           

        }
    }
}