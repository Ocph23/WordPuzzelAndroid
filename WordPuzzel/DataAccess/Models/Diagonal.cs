namespace DataAccess
{
    public class Diagonal:BaseNotify
    {
        public int RowIndex;
        public int ColumnIndex;
        public Direction Direction;
        public int Number;
        public int FirstCount { get; set; }
        public int SecoundCount
        {
            get
            {
                return Number - FirstCount;
            }
        }
        public int RowStart { get;  set; }
        public int RowEnd { get;  set; }
        public int CollStart { get;  set; }
        public int CollEnd { get;  set; }
    }
    public enum Direction
    {
        LeftToRight,
        RightToLeft
    }
}
