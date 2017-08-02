using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EZList.Domain.Abstract;

namespace EZList.WebUI.Controllers
{
    public class DJListController : Controller
    {
        private IDJListRepository repository;

        public DJListController(IDJListRepository djListRepository)
        {
            this.repository = djListRepository;
        }

        public ViewResult List()
        {
            return View(repository.DJLists);
        }
    }
}