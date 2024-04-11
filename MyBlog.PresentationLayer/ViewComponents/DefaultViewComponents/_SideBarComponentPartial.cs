using Microsoft.AspNetCore.Mvc;

namespace MyBlog.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _SideBarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
