using System.Web.Mvc;
using JustBlog.Core;
using JustBlog.Models;
using System.Web;

namespace JustBlog.Controllers
{
	public class BlogController : Controller
	{
		private readonly IBlogRepository _blogRepository;

		public BlogController(IBlogRepository blogRepository)
		{
			_blogRepository = blogRepository;
		}

		public ViewResult Posts(int p = 1)
		{
			var viewModel = new ListViewModel(_blogRepository, p);
			ViewBag.Title = "Latest Posts";
			return View("List", viewModel);
		}
	}
}
