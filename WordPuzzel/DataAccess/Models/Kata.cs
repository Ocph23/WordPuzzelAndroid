
namespace DataAccess.Models
{

    public class Kata
    {
        private int _id;
        private int _kategoriid;
        private string _nilai;

        public int Id {
            get { return _id; }
            set
            {
                _id = value;
         
            }
        }

        public int KategoriId {
            get { return _kategoriid; }
            set
            {

                _kategoriid = value;
            }

        }

        public string Nilai {
            get { return _nilai; }
            set
            {
                _nilai = value;
            }
        }
    }
}
