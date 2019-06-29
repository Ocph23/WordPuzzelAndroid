using DataAccess;


namespace DataAccess.Models
{
    public class Cordinate:BaseNotify
    {

        private int column;

        public int Column
        {
            get { return column; }
            set { SetProperty(ref column , value); }
        }

        private int row;

        public int Row
        {
            get { return row; }
            set {SetProperty(ref  row , value); }
        }

        public Cordinate(int column, int row)
        {
            this.Column = column;
            this.Row = row;
        }
    }
}
