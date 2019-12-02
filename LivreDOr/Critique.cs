using System;
using System.Collections.Generic;
using System.Text;

namespace LivreDOr
{
    class Critique
    {
        private string name;
        private string message;
        private string id;

        public Critique(string id, string n, string m)
        {
            this.id = id;
            this.Name = n;
            this.Message = m;
        }

        public Critique( string n, string m)
        {
            this.id = "";
            this.Name = n;
            this.Message = m;
        }
        public Critique()
        {
        }


        public string Name { get ; set; }
        public string Message { get; set; }
        public int Id { get; set; }
    }

}
