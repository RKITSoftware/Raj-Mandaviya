using System.Web.Caching;

namespace LibraryManagementAPI.Helpers
{
    public class Caches
    {
        private static Cache _myCache = null;
        public static Cache MyCache // comment
        {
            get
            {
                //Create new MyCache object if not already instantiated
                if (_myCache == null)
                    _myCache = (System.Web.HttpContext.Current == null) ? System.Web.HttpRuntime.Cache : System.Web.HttpContext.Current.Cache;
                //Return the cached object
                return _myCache;
            }
            set
            {
                //Return the cached object
                _myCache = value;
            }
        }
        /// <summary>
        /// Get Data from MyCache using key
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Data from MyCache</returns>
        public static object Get(string key)
        {
            return MyCache.Get(key);
        }
        /// <summary>
        /// Add data to MyCache using Key
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void Add(string key, object value)
        {
            MyCache.Insert(key, value);
        }
        /// <summary>
        /// Remove data from cache using key
        /// </summary>
        /// <param name="key"></param>
        public static void Remove(string key)
        {
            MyCache.Remove(key);
        }
    }
}