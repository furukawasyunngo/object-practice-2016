using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_practice_2016
{
    class CIkimono
    {
        private static int ikimonoCount = 0;

        private string name = "";

        public CIkimono(string nm)
        {
            name = nm;
            ikimonoCount++;
        }

        public static int getIkimonoCount()
        {
            return ikimonoCount;
        }

        public string hello()
        {
            return "私は" + name + "です。";
        }
    }
}
