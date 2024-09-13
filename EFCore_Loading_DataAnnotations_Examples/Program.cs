using EFCore_Loading_DataAnnotations_Examples;
using Microsoft.EntityFrameworkCore;

AppDbContext context = new AppDbContext();

var allPost = context.Posts.Include(x => x.Blog).ToList();

foreach (var item in allPost)
{
    Console.WriteLine(item.Blog.BlogName);
}