using AliBaba.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web.Infrastructure.Interfaces.Product;
using Web.Models;
using Web.ViewModel.Order;
using Web.ViewModel.Product;
namespace AliBaba
{
    [Serializable]
    class UserDAO : IRepository<User, long>
    {
        private readonly ApplicationDBContext _context;
        public bool DeleteByID(long id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteByIDs(List<long> ids)
        {
            throw new NotImplementedException();
        }

        public List<User> FindAll()
        {
            throw new NotImplementedException();
        }

        public User FindById(long id)
        {
            throw new NotImplementedException();
        }

        public List<User> FindByIDs(List<long> ids)
        {
            throw new NotImplementedException();
        }

        public User Save(User E)
        {
            throw new NotImplementedException();
        }
    }
}
