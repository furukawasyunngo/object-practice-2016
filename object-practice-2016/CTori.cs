﻿namespace object_practice_2016
{
    class CTori : CIkimono
    {
        private static int count = 0;

        public CTori(string nm) : base(nm)
        {
            count++;
        }

        public static int getCount()
        {
            return count;
        }

        public override string action()
        {
            return "パタパタ";
        }
    }
}
