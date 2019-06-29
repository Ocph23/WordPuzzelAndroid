using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace WordPuzzel
{
    public static class Helper
    {
        public static T GetRandom<T>(this IEnumerable<T> list)
        {
            return list.ElementAt(new Random(DateTime.Now.Millisecond).Next(list.Count()));
        }

        public static List<E> ShuffleList<E>(List<E> inputList)
        {
            List<E> randomList = new List<E>();

            Random r = new Random();
            int randomIndex = 0;
            while (inputList.Count > 0)
            {
                randomIndex = r.Next(0, inputList.Count); //Choose a random object in the list
                randomList.Add(inputList[randomIndex]); //add it to the new, random list
                inputList.RemoveAt(randomIndex); //remove to avoid duplicates
            }

            return randomList; //return the new random list
        }
        public static Diagonal FindOnesFromLeftToRight(int[,] matrix, int row, int col)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int lastColumnIndex = columns - 1;
            int lastRowIndex = rows - 1;

            int max = 0;
            int i = row;
            int j = col;
            int lastrow = 0;
            int lastcol = 0;
            //calculate 1's from left to right
            var da = new Diagonal()
            {
                RowStart = row,
                CollStart = col,
                Direction = Direction.LeftToRight,
                Number = max
            };

            while ((i >= 0 && i < rows) && (j >= 0 && j < columns))
            {
                i--;
                da.RowStart = i;
                j--;
                da.CollStart = j;
                da.FirstCount++;
            }

            while (j <= columns)
            {

                if (j <= lastColumnIndex && i <= lastRowIndex)
                {
                    lastrow = i;
                    lastcol = j;
                    max++;
                }
                j++;
                i++;
            }
            if (max > 0)
            {
                da.CollEnd = lastcol;
                da.RowEnd = lastrow;
                da.Number = max;
                return da;

            }
            else
                return null;
        }

        public static Diagonal FindOnesFromRightToLeft(int[,] matrix, int row, int col)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int lastColumnIndex = columns - 1;
            int lastRowIndex = rows - 1;

            int max = 0;
            int i = row;
            int j = col;
            int lastrow = 0;
            int lastcol = 0;
            //calculate 1's from left to right
            var da = new Diagonal()
            {
                RowStart = row,
                RowEnd = lastrow,
                CollStart = col,
                CollEnd = lastcol,
                ColumnIndex = j,
                Direction = Direction.RightToLeft,
                Number = max
            };

            while ((i >= 0 && i < rows) && (j >= 0 && j < columns))
            {
                i--;
                da.RowStart = i;
                j++;
                da.CollStart = j;
                da.FirstCount++;
            }

            while (j >= 0)
            {
                if ((i >= 0 && i <= rows) && (j >= 0 && j <= columns))
                {
                    lastrow = i;
                    lastcol = j;
                    max++;
                }
                j--;
                i++;
            }
            if (max > 0)
            {
                da.CollEnd = lastcol;
                da.RowEnd = lastrow;
                da.Number = max;
                return da;
            }
            else
            {
                return null;
            }

        }

        public static Color PickBrush()
        {
            Random r = new Random();
            byte red = (byte)r.Next(0, byte.MaxValue + 1);
            byte green = (byte)r.Next(0, byte.MaxValue + 1);
            byte blue = (byte)r.Next(0, byte.MaxValue + 1);
            var brush = Color.FromRgb(red, green, blue);
            //brush.Freeze();
            return brush;
        }

        public static Color BindingBrush(Color current, Color newcolor)
        {
            Color foreground = current;
            Color background = newcolor;

            byte opacity = 75;

            byte r = (byte)((opacity * (foreground.R - background.R) / 100) + background.R);
            byte g = (byte)((opacity * (foreground.G - background.G) / 100) + background.G);
            byte b = (byte)((opacity * (foreground.B - background.B) / 100) + background.B);

            Color brush = Color.FromRgb( r, g, b);
          //  brush.Freeze();
            return brush;
        }

       

        internal static string RandomString(Random random)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, 1)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        public static int RandomPosision(Random rrow, int max)
        {
            return rrow.Next(0, max - 1);
        }

        public static Arah RandomArah(Random rarah)
        {
            const string chars = "123";
            var res = Convert.ToInt32(new string(Enumerable.Repeat(chars, 1)
              .Select(s => s[rarah.Next(s.Length)]).ToArray()));
            if (res == 1)
            {
                return Arah.Horizontal;
            }
            else if (res == 2)
                return Arah.Vertical;
            else
                return Arah.Diagonal;
        }

        internal static Frame NewBorder(Color currentColor)
        {
           var rec= new Frame();
           // rec.BorderColor = currentColor;
            
            return rec;
        }

        //Soulition With Back Tract




    }
}
