﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem1
{
    public class TeamMember
    {
        public string Name { get; private set; }
        public int MemberId { get; private set; }

        public TeamMember(string name, int memberId)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty.");
            if (memberId <= 0)
                throw new ArgumentException("Member ID must be a positive number and explicitly provided.");

            Name = name;
            MemberId = memberId;
        }
    }

}
