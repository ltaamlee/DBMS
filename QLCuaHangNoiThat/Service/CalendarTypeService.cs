using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCuaHangNoiThat.Dao;
using QLCuaHangNoiThat.Model;

namespace QLCuaHangNoiThat.Service
{
    public class CalendarTypeService
    {
        private Dao.CalendarTypeDao calendarTypeDao = new Dao.CalendarTypeDao();
        public List<CalendarType> GetAll()
        {
            return new Dao.CalendarTypeDao().GetAll();  
        }
    }
}
