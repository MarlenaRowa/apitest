
using Catalog;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Net;

namespace API
{

    // GET / items
    [ApiController]
    [Route("v2/entities")]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepository repository;

        public ItemsController(IItemsRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<ItemDto> GetItems()
        {
            var items = repository.GetItems().Select(item => new ItemDto
            {
                Id = item.Id,
                Type = item.Type,
                Name = item.Name,
                versionOnRobot = item.versionOnRobot
            }) ;

            return items;
        }

        //GET /items/id
        [HttpGet("{entityId}")]
        public ActionResult<ItemDto> GetItem(string id)
        {
            var item = repository.GetItem(id);

            if (item is null)

            {
                return NotFound();
            }

            return item.AsDto();


        }

        //POST / items
        [HttpPost]
        public ActionResult<ItemDto> CreateItem(CreateItem itemDto)
        {
            Item item = new()
            {
                Id = itemDto.Id,
                Type = itemDto.Type,
                Name = itemDto.Name,
                versionOnRobot = itemDto.versionOnRobot,

            };

            repository.CreateItem(item);

            return CreatedAtAction(nameof(GetItems), new { id = item.Id }, item.AsDto());


        }

        [HttpPatch("{entityId}")]
        public ActionResult UpdateItem(String id, UpdateItem itemDto)
        {
            var existingItem = repository.GetItem(id);

            if (existingItem is null)
            {
                return NotFound();
            }

            Item updatedItem = existingItem with
            {
                Name = itemDto.Name,
                versionOnRobot = itemDto.versionOnRobot
                
            };

            repository.UpdateItem(updatedItem);

            return NoContent();


        }



    }




}
