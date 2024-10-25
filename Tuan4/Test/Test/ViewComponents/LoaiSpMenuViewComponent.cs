using Microsoft.AspNetCore.Mvc;
using Test.Repository;
namespace Test.ViewComponents
{
    public class LoaiSpMenuViewComponent : ViewComponent
    {
        private readonly LoaiSP _loaiSp;

        public LoaiSpMenuViewComponent(LoaiSP loaiSp)
        {
            _loaiSp = loaiSp;
        }

        public IViewComponentResult Innoker()
        {
            var loaisp = _loaiSp.GetAll().OrderBy(x => x.Loai);
            return View(loaisp);
        }
    }
}
