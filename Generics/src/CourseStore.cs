using System;
using System.Collections.Generic;
using System.Text;

namespace src
{
    internal class CourseStore
    {
        private readonly List<Course> _courses = new();

        public void Add(Course course) => _courses.Add(course);

        public Course? GetById(int id)
        {
            foreach (var course in _courses)
            {
                if (course.Id == id)
                    return course;
            }
            return null;
        }

        public List<Course> GetAll() => _courses;

        public bool Remove(int id)
        {
            var course = GetById(id);
            if (course is null)
                return false;
            return _courses.Remove(course);
        }
    }
}
