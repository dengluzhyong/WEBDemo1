using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WEBDemo1.Models;

namespace WEBDemo1.Controllers
{
    public class MyContentController : Controller
    {
        public IActionResult Index()
        {
            List<MyContent> lists = new List<MyContent>();
            for (int i = 0; i < 10; i++)
            {
                lists.Add(new MyContent { ID = i + 1, Title = $"{i + 1}title", Neirong = $"{i + 1}neirong", status = 1, CreateTime = DateTime.Now.AddDays(-i) });
            }
            return View(new MyContentModelView { myContents=lists});
        }
    }
}