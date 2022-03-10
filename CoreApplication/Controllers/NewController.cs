using CoreApplication.Models;
using CoreApplication.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication.Controllers
{
    public class NewController : Controller
    {
        private readonly OneRepository _oneRepository = null;

        public NewController()
        {
            _oneRepository = new OneRepository();
        }

        public ViewResult GetAll()
        {
            var data = _oneRepository.GetAll();
            return View(data);
        }

        public OneModel GetOne(int id)
        {
            return _oneRepository.GetOnebyId(id);
        }

        public List<OneModel> SearchOne(string Name,string Author)
        {
            return _oneRepository.SearchOne(Name, Author);
        }
    }
}
