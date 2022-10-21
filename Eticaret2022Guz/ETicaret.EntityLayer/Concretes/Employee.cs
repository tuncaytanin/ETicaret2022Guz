using ETicaret.EntityLayer.Abstracts;
using System;

namespace ETicaret.EntityLayer.Concretes
{
    public class Employee : IEntity
    {
        /// <summary>
        /// Employee Unique key value
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Employee Name
        /// </summary>
        public string EmployeeName { get; set; }

        /// <summary>
        /// Employee Family Name
        /// </summary>
        public string EmployeeLastname { get; set; }

        /// <summary>
        /// Employee User Name
        /// </summary>
        public string EmployeeUserName { get; set; }

        /// <summary>
        /// Employee Email
        /// </summary>
        public string EmployeeEmail { get; set; }
        /// <summary>
        /// Statu 0-> Pasif , 1 -> Aktif
        /// </summary>
        public bool EmployeeStatu { get; set; }
        /// <summary>
        /// Employe create date datetimestamp
        /// </summary>
        public DateTime StartDate { get; set; }

        // RoleId manuel olarak eklemesem.. EF benim yerime kendisi ekliyor..
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
