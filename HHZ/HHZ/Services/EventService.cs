using System;
using MLMS.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MLMS.Services
{
    public class EventService
    {
        public ApplicationDbContext Db { get; } = new ApplicationDbContext();

        public Event FindById(int? id)
        {
            return Db.Events.Include("Instructor").FirstOrDefault(x => x.EventId==id);
        }

        public IEnumerable<Event> Events()
        {
            return Db.Events.Include("Instructor").ToList();
        }
        public IEnumerable<Comment> Comments(int eventId)
        {
            return Db.Comments.Include("Student").Where(e=>e.EventId==eventId).ToList();
        }

        public void Create(Event model)
        {
            Db.Events.Add(model);
            Db.SaveChanges();
        }

        public void Update(Event model)
        {
            Db.Entry(model).State = EntityState.Modified;
            Db.SaveChanges();
        }


        public void Delete(Event model)
        {
            Db.Events.Remove(model);
            Db.SaveChanges();
        }

        public IEnumerable<Event> GetEventsByCategory(int id)
        {
            return Db.Events.Include("Instructor").Where(x => x.CategoryId == id).ToList();
        }


        #region Event Enrollment


        public EventEntrollment GetEventEntrollmentByStudentId(int studentId)
        {
            return Db.EventEntrollments.FirstOrDefault(x => x.StudentId == studentId);
        }

        public IEnumerable<EventEntrollment> GetEntrollmentsByEventId(int eventId)
        {
            return Db.EventEntrollments.Where(e=>e.EventId==eventId).Include("Student").ToList();
        }


        public int EventEnrollmentsCount(int eventId)
        {
            return Db.EventEntrollments.Count(x => x.EventId == eventId);
        }
        public void DeleteEventEnrollment(EventEntrollment model)
        {
            Db.EventEntrollments.Remove(model);
        }

        public void Enrollment(int eventId, string userId)
        {
            var studentId = GetStudentId(userId);
            var enrollment = new EventEntrollment
            {
                EventId = eventId,
                StudentId = studentId,
                TimeStamp = DateTime.Now
            };

            Db.EventEntrollments.Add(enrollment);
            Db.SaveChanges();

        }

        public bool CheckEventEnrollment(string userId)
        {
            var studentId = GetStudentId(userId);

            return Db.EventEntrollments.Any(x => x.StudentId == studentId);
        }



        private int GetStudentId(string userId)
        {
            return Db.Students.Where(st => st.UserId == userId).Select(st => st.StudentId).FirstOrDefault();
        }

        #endregion

        #region Event Comments

        public void CommentCreate(string message,int eventId, string userId)
        {
            var comment = new Comment
            {
                DateTime = DateTime.Now,
                EventId = eventId,
                Message = message,
                StudentId = GetStudentId(userId)

            };
            Db.Comments.Add(comment);
            Db.SaveChanges();
        }


        #endregion

    }
}