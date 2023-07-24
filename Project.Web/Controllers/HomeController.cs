using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Project.Data.UnitOfWorks;
using Project.Entity.Entities;
using Project.Service.Services.Abstractions;
using Project.Web.Models;
using Microsoft.EntityFrameworkCore;
using Project.Helpers;

namespace Project.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IArticleService articleService;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IUnitOfWork unitOfWork;

        public HomeController(ILogger<HomeController> logger, IArticleService articleService, IHttpContextAccessor httpContextAccessor, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            this.articleService = articleService;
            this.httpContextAccessor = httpContextAccessor;
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IActionResult> Index(Guid? categoryId, int currentPage = 1, int pageSize = 4, bool isAscending = false)
        {
            var articles = await articleService.GetAllByPagingAsync(categoryId, currentPage, pageSize, isAscending);
            return View(articles);
        }
        [HttpGet]
        public async Task<IActionResult> Search(string keyword, int currentPage = 1, int pageSize = 4, bool isAscending = false)
        {
            var articles = await articleService.SearchAsync(keyword, currentPage, pageSize, isAscending);
            return View(articles);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        public async Task<IActionResult> Detail(Guid id)
        {
            var ipAddress = httpContextAccessor.HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
            var articeVisitors = await unitOfWork.GetRepository<ArticleVisitor>().GetAllAsync(null, x => x.Visitor, y => y.Article);
            var article = await unitOfWork.GetRepository<Article>().GetAsync(x => x.Id == id);

            var result = await articleService.GetArticleWithCategoryNonDeletedAsync(id);

            var visitor = await unitOfWork.GetRepository<Visitor>().GetAsync(x => x.IpAddress == ipAddress);

            var addArticleVisitors = new ArticleVisitor(article.Id, visitor.Id);

            if (articeVisitors.Any(x => x.VisitorId == addArticleVisitors.VisitorId && x.ArticleId == addArticleVisitors.ArticleId))
                return View(result);
            else
            {
                await unitOfWork.GetRepository<ArticleVisitor>().AddAsync(addArticleVisitors);
                article.ViewCount += 1;
                await unitOfWork.GetRepository<Article>().UpdateAsync(article);
                await unitOfWork.SaveAsync();
            }

            return View(result);
        }

        [Route("magaza")]
        public IActionResult Magaza()
        {
            return View();
        }

        [Route("checkout")]
        public IActionResult Checkout()
        {
            return View();
        }

        [Route("iletisim")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("email-gönder")]
        public IActionResult EmailGonder()
        {
            MailHelper.SendEmail("Merhaba");
            return Content("Gönderdim");
        }

        //[HttpPost]
        //[Route("form-gonder")]
        //[ValidateAntiForgeryToken]
        //public IActionResult SaveForm([Bind("Name,Email,Phone,Message")] ContactModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Json(new
        //        {
        //            success = false,
        //            message = "hatalı veya eksik form"
        //        });
        //    }

        //    if (string.IsNullOrEmpty(Request.Form["ReCaptchaToken"]))
        //    {
        //        return Json(new
        //        {
        //            success = false,
        //            message = "no repcatcha no cry"
        //        });
        //    }

        //    bool isRecaptchaValidated = ReCaptchaHelper.ValidateRecaptcha(Request.Form["ReCaptchaToken"].ToString());
        //    if (!isRecaptchaValidated)
        //    {
        //        return Json(new
        //        {
        //            success = false,
        //            message = "no repcatcha no cry"
        //        });
        //    }

        //    _context.Add(model);
        //    _context.SaveChanges();

        //    return Json(new
        //    {
        //        success = true,
        //        message = "form gönderildi"
        //    });
        //}
    }
}