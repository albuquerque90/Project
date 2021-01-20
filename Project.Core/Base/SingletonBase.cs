namespace Project.Core.Base
{
    public class SingletonBase<T> where T : class, new()
    {
        private static T _instance;

        public static T Instance()
        {
            //garante que smpre uma instância existe, só uma
            if (_instance == null)
                _instance = new T();
            return _instance;
        }
    }
}
