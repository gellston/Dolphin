using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PopupMessage
    {

        public PopupMessage()
        {

        }

        public int Width { get; set; }
        public int Height { get; set; }

        public object Content { get; set; }

        public bool IsOpen { get; set; }
    }
}
