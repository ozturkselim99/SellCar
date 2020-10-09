using Microsoft.AspNetCore.Mvc;
using sellcar.business.Abstract;

namespace AspNetCoreMvcTemel.ViewComponents
{
    public class MarkalarViewComponent : ViewComponent
    {
        private IMarkaService _markaService;
        public MarkalarViewComponent(IMarkaService markaService)
        {
            _markaService = markaService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_markaService.GetMarkalar());
        }
    }
}
