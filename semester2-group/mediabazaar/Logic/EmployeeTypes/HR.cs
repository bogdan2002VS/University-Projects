﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.EmployeeTypes
{
    public class HR : Employee
    {
        public HR(int id, string firstName, string lastName,
        string email, Address address, DateOnly dateOfBirth,
        string phoneNumber, int bsn, bool isActive, string username, string password, string serialNumber) : base(id, firstName, lastName, email, address, dateOfBirth, phoneNumber, bsn, isActive, username, password, serialNumber)
        {
        }

        public HR(string firstName, string lastName,
        string email, Address address, DateOnly dateOfBirth,
        string phoneNumber, int bsn, bool isActive, string username, string password, string serialNumber) : base(firstName, lastName, email, address, dateOfBirth, phoneNumber, bsn, isActive, username, password, serialNumber)
        {
        }

        public HR(int id, string firstName, string lastName,
string email, Address address, DateOnly dateOfBirth,
string phoneNumber, int bsn, bool isActive) : base(id, firstName, lastName, email, address, dateOfBirth, phoneNumber, bsn, isActive)
        {
        }
    }
}
