using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_plataforma_ensino.Entities {
    internal class Task : Lesson {
       

        public string description { get; set; }
        public int questionCount { get; set; }

        public Task(string title, string description, int questionCount) : base(title) { 

            this.description = description;
            this.questionCount = questionCount;
        }

        public override int Duration() {
            return questionCount * 300;
        }
    }
}
