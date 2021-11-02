using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Building
{
    class Creator
    {
        public static Hashtable Hashes;
        static public Building CreateBuild()
        {
            Building b = new Building();
            Hashes.Add("building", b.Number);
            return b;
        }

        private Creator()
        {
            Hashes = new Hashtable();
        }
    }
}
