using System;
using System.Collections.Generic;

namespace Flyweight
{
    public static class PlatformFactory
    {
        private static IDictionary<string, IPlatform> map = new Dictionary<string, IPlatform>();

        public static IPlatform PlatformInstance(string name)
        {
            IPlatform platform = null;
            try
            {
                platform = map[name];
            }
            catch (KeyNotFoundException)
            {
                switch (name)
                {
                    case "C":
                        platform = new CPlatform();
                        break;
                    case "SCALA":
                        platform = new ScalaPlatform();
                        break;
                    case "JAVA":
                        platform = new JavaPlatform();
                        break;
                    case "RUBY":
                        platform = new RubyPlatform();
                        break;
                }
                map.Add(name, platform);
            }
            return platform;
        }
    }
}