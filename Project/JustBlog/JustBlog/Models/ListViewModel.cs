using JustBlog.Core;
using System.Collections.Generic;
using JustBlog.Core.Objects;

namespace JustBlog.Models
{
	public class ListViewModel
	{
		public ListViewModel(IBlogRepository blogRepository, int p)
		{
			Posts = blogRepository.Posts(p - 1, 10);
			TotalPosts = blogRepository.TotalPosts();
		}

		public IList<Post> Posts { get; private set; }
		public int TotalPosts { get; private set; }
	}
}