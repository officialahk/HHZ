using System;
using System.Collections.Generic;
using System.Linq;
using MLMS.Models;
using System.Data.Entity;
using System.Web.Mvc;

namespace MLMS.Services
{
    public class CourseService
    {
        private  ApplicationDbContext Db { get; } = new ApplicationDbContext();


        public Course FindById(int? id)
        {
           return Db.Courses.Include("Instructor").FirstOrDefault(x => x.CourseId==id);
        }

        

        public IEnumerable<Course> InstructorCourses(int instructorId)
        {
            return Db.Courses.Where(x=>x.InstructorId==instructorId).ToList();
        }

        public IEnumerable<Course> GetCoursesByCategory(int id)
        {
            return Db.Courses.Include("Instructor").Where(x=>x.CategoryId==id).ToList();
        }

        public IEnumerable<Course> Courses()
        {
            return Db.Courses.Include("Instructor").ToList();
        }

        public IEnumerable<SelectListItem> CoursesDropDown()
        {
            return Db.Courses.Select(x => new SelectListItem { Value = x.CourseId.ToString(), Text = x.Title });
        }

        public IEnumerable<Course> GetCoursesForInstructor(int instructorId)
        {
            return Db.Courses.Where(x=>x.InstructorId==instructorId).Include("Instructor").ToList();
        }

        public void Create(Course course)
        {
            Db.Courses.Add(course);
            Db.SaveChanges();
        }

        public void Update(Course course)
        {
            Db.Entry(course).State = EntityState.Modified;
            Db.SaveChanges();
        }


        public void Delete(Course course)
        {
            Db.Courses.Remove(course);
            Db.SaveChanges();
        }



        #region Course Enrollment


        public void Enrollment(int courseId, string userId)
        {
            var studentId = GetStudentId(userId);
            var enrollment = new CourseEnrollment
            {
                CourseId = courseId,
                StudentId = studentId,
                TimeStamp = DateTime.Now
            };

            Db.CourseEnrollments.Add(enrollment);
            Db.SaveChanges();

        }


       

        public bool CheckCourseEnrollment(string userId,int courseId)
        {
            var studentId = GetStudentId(userId);

            return Db.CourseEnrollments.Any(x => x.StudentId == studentId && x.CourseId==courseId);
        }


        public IEnumerable<CourseEnrollment> GetCourseEnrollments(string userId)
        {
            var studentId = GetStudentId(userId);

            return Db.CourseEnrollments.Include("Course").Where(x => x.StudentId == studentId).ToList();

        }

        private int GetStudentId(string userId)
        {
            return Db.Students.Where(st => st.UserId == userId).Select(st => st.StudentId).FirstOrDefault();
        }

        #endregion

    }
}