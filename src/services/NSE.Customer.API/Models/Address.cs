﻿using NSE.Core.DomainObjects;
using System;

namespace NSE.Customers.API.Models
{
    public class Address : Entity
    {
        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Complement { get; private set; }
        public string District { get; private set; }
        public string Cep { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public Guid CustomerId { get; private set; }
        public Customer Customer { get; private set; }

        public Address(string street, string number, string complement, string district, string cep, string city, string state)
        {
            Street = street;
            Number = number;
            Complement = complement;
            District = district;
            Cep = cep;
            City = city;
            State = state;
        }
    }
}