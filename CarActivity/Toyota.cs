using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarActivity
{
    public class Toyota : Car
    {
        public override string Name { get; set; }
        public override PictureBox Picture { get; set; }
        public Toyota(string tempName, PictureBox tempPic)
        {
            Name = tempName;
            Picture = tempPic;
        }
        public override void Move(int distance)
        {
            Picture.Location = new Point(Picture.Location.X, Picture.Location.Y + distance);
            
        }
    }
}
