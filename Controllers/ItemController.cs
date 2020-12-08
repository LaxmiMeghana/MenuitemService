using System.Collections.Generic;
using MenuitemService.Models;
using MenuitemService.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MenuitemService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(ItemController));
        private readonly IItemRepository _IItemRepository;
        public ItemController(IItemRepository Repo)
        {
            this._IItemRepository = Repo;
        }



        [HttpGet]

        public IActionResult GetAllItems()
        {
            try
            {
                _log4net.Info("Http GET is accesed");
                IEnumerable<Item> Tlist = _IItemRepository.GetAll();
                return Ok(Tlist);
            }
            catch
            {
                _log4net.Error("Http GET is requested");
                return new NoContentResult();

            }
        }
        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            try
            {
                _log4net.Info("Http GET is accessed" + id);
                var Tlist = _IItemRepository.GetById(id);
                return new OkObjectResult(Tlist);

            }
            catch
            {
                _log4net.Error("Error in get by id Request");
                return new NoContentResult();

            }
        }

    }

}
