namespace object_practice_2016
{
    abstract class CIkimono
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
        // abstract 抽象
        public abstract string action();
    }
}
