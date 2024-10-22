using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        private readonly AppDbContext _context;

        public EfBookingDal(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public void BookingStatusChangeApprovedForId(int id)
        {
            var values = _context.Bookings.Find(id);
            values.Status = "Onaylandı";
            _context.SaveChanges();
        }
    }
}
