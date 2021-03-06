﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Damas.Domain.Shared;
using Incentive.Entity.Modules.Incentive.Entities;
using Incentive.Entity.Modules.Incentive.Indexs;

namespace Incentive.Entity.Modules.Incentive.RootEntities
{
    public class DegreeQuestion:EntityBase
    {
        public DegreeQuestion()
        {
            Questions=new List<Question>();
            Answers=new List<Answer>();
        }
        public ICollection<Question> Questions { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public int Degree { get; set; }
    }
}
