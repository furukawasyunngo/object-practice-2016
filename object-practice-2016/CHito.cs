﻿namespace object_practice_2016
{
    class CHito : CIkimono
    {
        private static int count = 0;

        public CHito(string nm) : base(nm)
        {
            count++;
        }

        public static int getCount()
        {
            return count;
        }

        // override = 上書き 
        public override string action()
        {
            return "テクテク";
        }
    }
}
