using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_plataforma_ensino.Entities {
    internal class Video : Lesson {

        public string url { get; set; }
        public int seconds { get; set; }

        public Video(string url, int seconds, string title) : base(title) {
            this.url = url;
            this.seconds = seconds;
        }

        public override int Duration() {
            return seconds;
        }
    }
}
