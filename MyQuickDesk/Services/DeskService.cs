﻿using MyQuickDesk.Entities;
using MyQuickDesk.DatabaseContext;
using MyQuickDesk.ApplicationUser;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MyQuickDesk.Services
{
    public class DeskService:IDeskService
    {
        private readonly MyQuickDeskContext _dbContext;
        //private readonly IUserContext _userContext;

        public DeskService(MyQuickDeskContext dbContext)// IUserContext userContext
        {
            _dbContext = dbContext;
            //_userContext = userContext;
        }        

        public List<Desk> GetAll()
        {
            return _dbContext.Desks.ToList();
        }

        public Desk GetById(Guid id)
        {
            return _dbContext.Desks.FirstOrDefault(d => d.Id == id);
        }

        public void Create(Desk desk)
        {

            //var currentUser = _userContext.GetCurrentUser();
            //if (currentUser == null || !currentUser.IsAdmin("Admin"))
            //{
            //    return;
            //}

            _dbContext.Desks.Add(desk);
            _dbContext.SaveChanges();
        }
        public Guid GetDeskId()
        {
            var desk = _dbContext.Desks.FirstOrDefault();

            if (desk != null)
            {
                return desk.Id;
            }
            return Guid.Empty;
        }

        public void Update(Desk desk)
        {
            _dbContext.Desks.Update(desk);
            _dbContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var desk = _dbContext.Desks.FirstOrDefault(d => d.Id == id);
            if (desk != null)
            {
                _dbContext.Desks.Remove(desk);
                _dbContext.SaveChanges();
            }
        }

    }
}
