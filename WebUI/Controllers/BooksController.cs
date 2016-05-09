using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
/*Controler and methods to show info about goods*/
namespace WebUI.Controllers
{
    public class BooksController : Controller
    {
        private IBookRepository repository;
            // Свойства контроллера для доступа к информации о запросе.
            // Request - данные о текущем HTTP запросе.
            // Response - данные о текущем HTTP ответе.
            // RouteData - данные маршрутизации для текущего запроса.
            // HttpContext - получение специфической информации о текущем HTTP запросе.
            // Server - объект с методами для обработки HTTP запроса.
        public BooksController(IBookRepository repo)
        {
            repository = repo; 
        }
        public ViewResult List()
        {
            return View(repository.Books);
        }

    }
}