using Core.Entity;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DataContext _context;
        private DbSet<T> table = null;
        public GenericRepository(DataContext context)
        {
            _context = context;
            table = _context.Set<T>();
            _context.SaveChanges();
        }


        public void Delete(object id)
        {
            T existing = GetById(id);
            table.Remove(existing);
            _context.SaveChanges();
        }

        public T GetById(object id)
        {
            var result = table.Find(id);
            _context.SaveChanges();
            return result;

        }
        public void Insert(T entity)
        {
            table.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public Employee CheckLogin(string emailAddress, string password)
        {
            Employee employee = null;
            employee = _context.Employees.FromSql<Employee>("CheckLogin @EmailAddress = {0}, @Password = {1}", emailAddress, password).ToList().FirstOrDefault();
            _context.SaveChanges();
            return employee;
        }

        public List<Holiday> GetHolidaysByEmployeeId(int id)
        {
            List<Holiday> results;
            results = _context.Holidays.FromSql<Holiday>("ListVacationsByEmployeeId @EmployeeId={0}", id).ToList();
            _context.SaveChanges();
            return results;
        }

        public List<Holiday> ListVacationsByEmployeeIdAndStatus(int id,string status)
        {
            List<Holiday> results;
            results = _context.Holidays.FromSql<Holiday>("ListVacationsByEmployeeIdAndStatus @EmployeeId={0}, @HolidayStatus={1}", id,status).ToList();
            _context.SaveChanges();
            return results;
        }

        public List<Holiday> ListVacationsByEmployeeIdAndStartDate(int id,DateTime startDate)
        {
            List<Holiday> results;
            results = _context.Holidays.FromSql<Holiday>("ListVacationsByEmployeeIdAndStartDate @EmployeeId={0}, @HolidayStartDate={1}", id,startDate).ToList();
            _context.SaveChanges();
            return results;
        }

        public List<Holiday> DisplayEmployeesHolidayRequests(string status)
        {
            List<Holiday> results;
            results = _context.Holidays.FromSql<Holiday>("DisplayVacationsRequests @HolidayStatus={0}", status).ToList();
            _context.SaveChanges();
            return results;
        }

        public void UpdateHolidayStatus(int id, String holidayStatus)
        {
            _context.Database.ExecuteSqlCommand("UpdateVacationStatus @Id = {0}, @HolidayStatus = {1}", id, holidayStatus);
            _context.SaveChanges();
        }

      
        public Employee SearchForEmployeeByEmail(string emailAddress)
        {
            Employee employee = null;
            employee = _context.Employees.FromSql<Employee>("SearchForEmployeeByEmail @EmailAddress = {0}", emailAddress).ToList().FirstOrDefault();
            _context.SaveChanges();
            return employee;
        }

        public string RetrievePasswordByEmail(string email)
        {           
            Login login = _context.Logins.FromSql<Login>("RetrievePasswordByEmail @EmailAddress = {0}", email).ToList().FirstOrDefault();
            _context.SaveChanges();
            string password = login.Password.ToString();
            return password;
        }

        public List<Employee> RetrieveManagersEmployees(int managerId)
        {
            List<Employee> result;
            result = _context.Employees.FromSql<Employee>("RetrieveManagersEmployees @ManagerId = {0}", managerId).ToList();
            _context.SaveChanges();
            return result;
        }

    }
}
