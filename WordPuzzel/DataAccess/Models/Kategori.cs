using System.Collections.Generic;

namespace DataAccess.Models
{

   public class Kategori
    {
        private int _id;
        private string _name;

        public int Id {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        public string Name {
            get { return _name; }
            set
            {
                _name = value;
            }
        }


        public virtual List<Kata> Words { get; set; }
    }
}
