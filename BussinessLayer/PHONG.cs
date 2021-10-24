using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;


namespace BussinessLayer
{
    public class PHONG
    {
        Entities db;
        public PHONG()
        {
            db = Entities.CreateEntities();
        }
        public tb_PHONG getItem(int MAPHONG)
        {
            return db.tb_PHONG.FirstOrDefault(x => x.MAPHONG == MAPHONG);
        }
        public List<tb_PHONG> getAll()
        {
            return db.tb_PHONG.ToList();
        }
        public void them(tb_PHONG PHOG)
        {
            try
            {
                db.tb_PHONG.Add(PHOG);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu." + ex.Message);

            }
        }
        public void sua(tb_PHONG PHOG)
        {
            tb_PHONG _phog = db.tb_PHONG.FirstOrDefault(x => x.MAPHONG == PHOG.MAPHONG);
            _phog.TENPHONG = PHOG.TENPHONG;
            _phog.DONGIA = PHOG.DONGIA;
            _phog.TRANGTHAIPHONG = PHOG.TRANGTHAIPHONG;
            _phog.MALP = PHOG.MALP;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu." + ex.Message);
            }
        }
        public void Delete(int MAPHONG)
        {
            tb_PHONG PHOG = db.tb_PHONG.FirstOrDefault(x => x.MAPHONG == MAPHONG);
            PHOG.TRANGTHAIPHONG = true;

            try
            {
                db.tb_PHONG.Remove(PHOG);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu." + ex.Message);
            }
        }
    }
}

