using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Car.Properties;
using System.Drawing;

namespace Project_Car.BL
{
    public class PhotoArr : ArrayList
    {
        public void Fill()
        {
            this.Add(Resources.Loading1);
            this.Add(Resources.Loading2);
            this.Add(Resources.Loading3);
            this.Add(Resources.Loading4);
            this.Add(Resources.Loading5);
            this.Add(Resources.Loading6);
            this.Add(Resources.Loading7);
            this.Add(Resources.Loading8);
            this.Add(Resources.Loading9);
            this.Add(Resources.Loading10);
            this.Add(Resources.Loading11);
            this.Add(Resources.Loading12);
        }

        public Image RandomImage()
        {
            Random rand = new Random();
            int n = rand.Next(0, this.Count);
            return this[n] as Image;
        }
    }
}
