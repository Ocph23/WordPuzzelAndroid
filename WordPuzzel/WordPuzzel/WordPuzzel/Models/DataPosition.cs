using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPuzzel.Models
{
    public class DataPosition
    {
        StringBuilder sb = new StringBuilder();
        public DataPosition(string item)
        {
            sb.Append(item);
            Datas = new List<ButtonBox>();
        }
        public DataPosition()
        {
            Datas = new List<ButtonBox>();
        }

        public List<ButtonBox> Datas { get; set; }
        public Cordinate From { get; set; }
        public Cordinate To { get; set; }
        public string Content { get { return sb.ToString(); } }

       
        internal void AddButton(ButtonBox btn)
        {
            Datas.Add(btn);
            sb.Append(btn.Text);
        }
    }
}
