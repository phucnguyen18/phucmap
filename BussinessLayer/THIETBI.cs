using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BussinessLayer
{
    public class THIETBI
    {
        Entities db;
        public THIETBI()
        {
            db = Entities.CreateEntities();
        }
        public tb_THIETBI getItem(int MATB)
        {
            return db.tb_THIETBI.FirstOrDefault(x => x.MATB == MATB);
        }
        public List<tb_THIETBI>getAll()
        {
            return db.tb_THIETBI.ToList();
        }
        public void them(tb_THIETBI thb)
        {
            try
            {
                db.tb_THIETBI.Add(thb);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                
                throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu." + ex.Message);
                
            }
        }
        public void sua(tb_THIETBI thb)
        {
            tb_THIETBI _thbi = db.tb_THIETBI.FirstOrDefault(x => x.MATB == thb.MATB);
            _thbi.TENTB = thb.TENTB;
            _thbi.DONGIA = thb.DONGIA;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu." + ex.Message);
            }
        }
        public void Delete(int MATB)
        {
            tb_THIETBI thb = db.tb_THIETBI.FirstOrDefault(x => x.MATB == MATB);
            
            try
            {
                db.tb_THIETBI.Remove(thb);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu." + ex.Message);
            }
        }
    }
}
