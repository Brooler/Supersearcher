namespace Supersearcher.Statistics
{
    //Better to use some external storage for collecting statistics
    //Singleton chosen for time economy
    public class StatisticsHolderSingleton
    {
        private StatisticsHolderSingleton() { }

        private static StatisticsHolderSingleton _instance;

        public static StatisticsHolderSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new StatisticsHolderSingleton();
            }

            return _instance;
        }
    }
}
