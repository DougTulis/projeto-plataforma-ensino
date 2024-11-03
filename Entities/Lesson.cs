using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_plataforma_ensino.Entities {
    abstract class Lesson {

        public string title { get; set; }

        protected Lesson(string title) {
            this.title = title;
        }

        public abstract int Duration();
    }
}
