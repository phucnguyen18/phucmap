using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BussinessLayer
{
   public class KHACHHANG
    {
        Entities db;
        public KHACHHANG()
        {
            db = Entities.CreateEntities();
        }
        public tb_KHACHHANG getItem(int MaKH)
        {
            
            return db.tb_KHACHHANG.FirstOrDefault(x=>x.MAKH == MaKH);
        }
        public List<tb_KHACHHANG> getall()
        {
            return db.tb_KHACHHANG.ToList();
        }
        public void add(tb_KHACHHANG kh)
        {
            try
            {
                db.tb_KHACHHANG.Add(kh);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }
        public void update(tb_KHACHHANG kh)
        {
            tb_KHACHHANG _kh = db.tb_KHACHHANG.FirstOrDefault(x=>x.MAKH==kh.MAKH);
            _kh.TENKH = kh.TENKH;
            _kh.SDT = kh.SDT;
            _kh.CCCD_CMND = kh.CCCD_CMND;
            _kh.DIACHI = kh.DIACHI;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }
        public void delete(int MAKH)
        {
            tb_KHACHHANG _kh = db.tb_KHACHHANG.FirstOrDefault(x => x.MAKH == MAKH);
            try
            {
                db.tb_KHACHHANG.Remove(_kh);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }
    }
}
