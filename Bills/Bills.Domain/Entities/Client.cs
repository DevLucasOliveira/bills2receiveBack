﻿using Bills.Shared.Entities;
using System;

namespace Bills.Domain.Entities
{
    public class Client : Entity
    {
        public Client()
        {

        }

        public Client(string name, string cellPhone)
        {
            Name = name;
            CellPhone = cellPhone;
        }

        public string Name { get; private set; }
        public string CellPhone { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public Order Order { get; private set; }

    }
}