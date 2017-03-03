using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Damas.Domain.Shared;
using Incentive.Entity.Modules.Incentive.Indexs;
using Incentive.Entity.Modules.Incentive.RootEntities;

namespace Incentive.Entity.Modules.Incentive.Entities
{
    public class Question:EntityBase
    {
        public string QuestionText { get; set; }
        public QuestionsGroup QuestionsGroup { get; set; }
        public DegreeQuestion DegreeQuestion { get; set; }
    }
}
