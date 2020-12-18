using System;
using System.Collections.Generic;
using System.Linq;
using Git_Command_Test.Dtos;
using Git_Command_Test.Extensions;
using Git_Command_Test.Services;
using Microsoft.AspNetCore.Mvc;

namespace Git_Command_Test.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private readonly IRepository _repository;

        public ItemsController(IRepository iRepository) => _repository = iRepository;

        // GET /items
        [HttpGet]
        public IEnumerable<GetItemDto> GetItems() => _repository.GetItems().Select(i => i.AsGetDto());

        // GET /items/{id}
        [HttpGet("{id}")]
        public GetItemDto GetItem(Guid id) => _repository.GetItem(id).AsGetDto();
    }
}