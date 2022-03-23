using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persistence.Repository;
using Persistence.Models;
using Microsoft.AspNetCore.Http;

namespace ApiClaro.Controllers
{
    [Route("api/Books")]
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
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<Book>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetBooks()
        {
            try
            {
                return Ok(await _repoBook.GetAll());
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.ToString());
                return StatusCode(400, ModelState);
            }
        }

        //Method to get only one book
        /// <summary>
        /// </summary>
        /// <returns></returns>
        [HttpGet("{Id:int}", Name = "GetBook")]
        [ProducesResponseType(200, Type = typeof(Book))]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetBook(int Id)
        {
            try
            {
                Book book = await _repoBook.GetById(Id);

                if (book == null)
                {
                    return NotFound("Este libro no existe.");
                }
                else
                {
                    return Ok(book);
                }
                
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.ToString());
                return StatusCode(400, ModelState);
            }
        }


        [HttpPost]
        [ProducesResponseType(201, Type = typeof(Book))]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateBook([FromBody] Book book)
        {
            try
            {
                //check if object comes null
                if (book == null)
                {
                    return BadRequest(ModelState);
                }

                if (await _repoBook.Add(book))
                {
                    return Created("~api/Book", new { book = book });
                }

                ModelState.AddModelError("", $"Algo salio mal al guardar el libro {book.Title}");
                return StatusCode(500, ModelState);
            }
            catch (Exception  ex)
            {
                ModelState.AddModelError("", ex.ToString());
                return StatusCode(400, ModelState);
            }
        }


        [HttpPut("{Id:int}", Name = "ActualizarCategoria")]
        [ProducesResponseType(204)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateBook(int Id, [FromBody] Book book)
        {
            try
            {
                if (book == null || Id != book.Id)
                {
                    return BadRequest(ModelState);
                }

                if (!await _repoBook.Update(Id, book))
                {
                    ModelState.AddModelError("", $"Algo salio mal al actualizar el libro {book.Title}");
                    return StatusCode(500, ModelState);
                }

                return Content("Registro actualizado.");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.ToString());
                return StatusCode(400, ModelState);
            }
        }


        [HttpDelete("{Id:int}", Name = "BorrarCategoria")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteBook(int Id)
        {
            try
            {
                Book book = await _repoBook.GetById(Id);
                if (book == null)
                {
                    return NotFound("Este libro no existe.");
                }

                if (!await _repoBook.Delete(Id))
                {
                    ModelState.AddModelError("", $"Algo salio mal al borrar el libro {book.Title}");
                    return StatusCode(500, ModelState);
                }

                return Content("Registro borrado con exito.");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.ToString());
                return StatusCode(400, ModelState);
            }
        }
    }
}
