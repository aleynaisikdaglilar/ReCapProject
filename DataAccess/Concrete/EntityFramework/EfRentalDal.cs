using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentCarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars on r.CarId equals c.Id
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join cus in context.Customers on r.CustomerId equals cus.Id
                             select new RentalDetailDto
                             {
                                 Id = r.Id,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                 CarName = b.BrandName,
                                 CustomerName = cus.CompanyName
                             };
                return result.ToList();
            }
        }
    }
}
