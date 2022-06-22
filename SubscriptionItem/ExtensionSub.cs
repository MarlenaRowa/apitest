
using API;

namespace CatalogSub
{

    public static class ExtensionsSub
    {
        public static ItemSubDto AsDto(this ItemSub itemSub)
        {
            return new ItemSubDto()
            {


                id = itemSub.id,
                type = itemSub.type,
                name = new NameSubDto { value = itemSub.name.value},
                versionOnRobot = new VersionOnRobotDto { value = itemSub.versionOnRobot.value},
                time_index = itemSub.time_index,


            };



        }

    }
}