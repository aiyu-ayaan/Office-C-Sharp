namespace Oops
{

    class HtttpCookies
    {
        private readonly Dictionary<string, string> _cookies;


        public HtttpCookies()
        {
            _cookies = new Dictionary<string, string>();
        }

        // usindexer to access cookies
        public string? this[string key]
        {
            get
            {
                if (_cookies.ContainsKey(key))
                {
                    return _cookies[key];
                }
                return null;
            }
            set
            {
                if(value == null)
                {
                    _cookies.Remove(key);
                }
                else
                {
                    _cookies[key] = value;
                }
            }
        }


    }


    class Indexers
    {
        public static void Main(string[] args)
        {
            HtttpCookies cookies = new HtttpCookies();
            cookies["session"] = "12345";
            cookies["user"] = "john_doe";
            Console.WriteLine("Session Cookie: " + cookies["session"]);
            Console.WriteLine("User Cookie: " + cookies["user"]);
            // Remove a cookie
            cookies["session"] = null;
            Console.WriteLine("Session Cookie after removal: " + cookies["session"]);
        }

    }
}
