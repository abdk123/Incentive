﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Incentive.Entity.Modules.Incentive.Entities;

namespace Incentive.Mapping.Modules.Incentive.Entities
{
    public class QuestionConfigure:EntityTypeConfiguration<Question>
    {
        public QuestionConfigure()
        {
            HasKey(x => x.Id);
            Property(x => x.QuestionText);

            HasRequired(x => x.QuestionsGroup);
            HasRequired(x => x.DegreeQuestion);
        }
    }
}
