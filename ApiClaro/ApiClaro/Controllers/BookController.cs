using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persistence.Repository;
using Persistence.Models;

namespace ApiClaro.Controllers
{
    [Route("api/Book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private UnitOfWork _unitOfWork;
        private Repository<Book> _repoBook;


        public BookController()
        {
            _unitOfWork = new UnitOfWork();
            _repoBook = _unitOfWork.Repository<Book>();
        }

        //Method to get all books 
        /// <summary>
        /// Obtener todas las categorias
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<Book>))]
        public async Task<IActionResult> GetBooks()
        {
            try
            {
                return Ok(await _repoBook.GetAll());
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al recuperar los datos");
                return StatusCode(400, ModelState);
            }
        }
    }
}
