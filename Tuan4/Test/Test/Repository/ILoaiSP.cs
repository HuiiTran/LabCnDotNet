using Test.Models;

namespace Test.Repository
{
    public interface ILoaiSP
    {
        TLoaiSp Add(TLoaiSp loaiSp);
        TLoaiSp Update(TLoaiSp loaiSp);

        TLoaiSp Delete(TLoaiSp loaiSp);

        TLoaiSp GetLoaiSp(String loaiSp);
        IEnumerable<TLoaiSp> GetAll();

    }
}
