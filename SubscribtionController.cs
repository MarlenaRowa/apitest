
using Catalog;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Net;
using CatalogSub;


namespace API
{

    // Hier Soll  neu Api Route für subscribtion sein, wir sollen Get und post bekommen 
    // ich denke(?) und ich sätze es wird funktionieren wie bei ItemsController 

    // wir brauchen dann aus subscription für programm abfrage, wir sollen datei wie id, name, version bekommen
    //und ein subscription trigger, aber ich kann mich noch nicht vostellen was und wie soll es funktionieren 



    // bekommt von Subscription id, name ,version
    // zum programmhandler gehen mit id, name
    // schickt aktuelle id name und versionOnRobot zurück an api und diese weiter zur subscription
    // GET / items
    [ApiController]
    [Route("v2/subscription")]

    public class SubscribtionController : ControllerBase
        {
            private readonly IItemsRepository repository1;

            public SubscribtionController(IItemsRepository repository1)
            {
                this.repository1 = repository1;
            }

            [HttpGet]
            public IEnumerable<ItemSubDto> GetItemsSub()
            {
                var itemsSub = repository1.GetItemsSub().Select(itemSub => new ItemSubDto
                {
                    id = itemSub.id,
                    type = itemSub.type,
                    name = new NameSubDto { value = itemSub.name.value },
                    versionOnRobot = new VersionOnRobotDto { value = itemSub.versionOnRobot.value },
                    time_index = itemSub.time_index,

                });



                return itemsSub;
            }

        // We get id, name, version from the subscription 
        [HttpPost]
        [Route("notify")]

        public ActionResult<ItemSubDto> CreateItemSub(Create.ItemSub itemSubDto)
        {
            ItemSub itemSub = new()
            {
                id = itemSubDto.id,
                type = itemSubDto.type,
                name = new NameSub { value = itemSubDto.name.value },
                versionOnRobot = new VersionOnRobot { value = itemSubDto.versionOnRobot.value },
                time_index = itemSubDto.time_index,

            };
                        repository1.CreateItemSub(itemSub);
            Console.WriteLine("WORK?");
            return CreatedAtAction(nameof(GetItemsSub), new { id = itemSub.id }, itemSub.AsDto());
            

        }
        [HttpGet("{entityId}")]
        public ActionResult<ItemSubDto> GetItemsSub(string id)
        {
            var itemSub = repository1.GetItemsSub(id);

            if (itemSub is null)

            {
                return NotFound();
            }

            return itemSub.AsDto();

        }



        // public void SubscriptionNotification(ProgramDto programDto)
        //     {
        //         Console.WriteLine("This is the data {0}, {1}, {2}", programDto.Id, programDto.Name, programDto.Version);
        //         // TODO
        //         // Go to programmhandler and which sends the versionOnRobot back to this api (to /handler)
        //     }




        // Programm handler sends back the id, name and versionOnRobot
        //TODO send to subscription
        [HttpPost]
        [Route("handler")]
        public void ProgrammHandlerNotification(ProgramDto programDto)
        {
            System.Console.WriteLine("This is the data from the programhandler {0}, {1}, {2}", programDto.Id, programDto.Name, programDto.Version);
        }

    }
    
}

