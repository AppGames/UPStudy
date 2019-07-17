using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ContentController : Controller
    {
        private readonly Content contents;
        public ContentController(IOptions<Content> option)
        {
            contents = option.Value;
        }

        public IActionResult Index()
        {
            return View(new ContentViewModel { Contents = new List<Content> { contents } });
        }

        //public IActionResult Index()
        //{
        //    ContentViewModel contentModel = new ContentViewModel();
        //    contentModel.Contents = new List<Content>();
        //    for(int i=0; i<11; i++)
        //    {
        //        contentModel.Contents.Add(new Content {
        //            Id = i, title=$"(i)的标题", content=$"(i)的内容",
        //            status = 1, add_time = DateTime.Now.AddDays(-i)});
        //    }

        //    return View(contentModel);
        //}
    }
}
