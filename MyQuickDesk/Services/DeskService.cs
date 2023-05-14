﻿using MyQuickDesk.Models;
using System.Data;

namespace MyQuickDesk.Services
{
    public class DeskService
    {
        private static int _idCounter = 5;
        private static List<Desk> _desks = new List<Desk>
        {
            new Desk()
            {
                Id = 1,
                Name = "Adrian",
                OwnerId = 123,
                Description ="Biurko 1",
                StartDate= DateTime.Now,
                EndDate = DateTime.Now,
                ReservationId= 3,
            }
        };
        public List<Desk> GetAll()
        {
            return _desks;
        }
        public Desk GetById(int id)
        {
            return _desks.FirstOrDefault(m => m.Id == id);
        }
        public void Create(Desk desk)
        {
            desk.Id = GetNextId();
            _desks.Add(desk);
        }

        public void Update(Desk model)
        {
            var desk = GetById(model.Id);

            desk.Name = model.Name;
            desk.OwnerId = model.OwnerId;
            desk.Description = model.Description;
            desk.StartDate = model.StartDate;
            desk.EndDate = model.EndDate;
            desk.ReservationId = model.ReservationId;
        }

        public void Delete(int id)
        {
            _desks.Remove(GetById(id));

        }

        private int GetNextId()
        {
            _idCounter++;
            return _idCounter;
        }
    }
}
