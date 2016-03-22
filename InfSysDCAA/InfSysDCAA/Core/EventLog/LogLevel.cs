namespace InfSysDCAA.Core.EventLog
{
    using System;

    public sealed class LogLevel : IComparable
    {
        /// <summary>
        /// 
        /// </summary>
        public static readonly LogLevel Trace = new LogLevel("Trace", 0);
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly LogLevel Debug = new LogLevel("Debug", 1);
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly LogLevel Info = new LogLevel("Info", 2);
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly LogLevel Warn = new LogLevel("Warn", 3);
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly LogLevel Error = new LogLevel("Error", 4);
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly LogLevel Fatal = new LogLevel("Fatal", 5);
        
        /// <summary>
        /// 
        /// </summary>
        public static readonly LogLevel Off = new LogLevel("Off", 6);
       
        /// <summary>
        /// 
        /// </summary>
        private readonly int _ordinalLogLevel;
        
        /// <summary>
        /// 
        /// </summary>
        private readonly string _nameLogLevel;

        /// <summary>
        /// 
        /// </summary>
        public string NameLogLevel
        {
            get { return _nameLogLevel; }
        }

        /// <summary>
        /// 
        /// </summary>
        internal static LogLevel MinLevel
        {
            get { return Trace; }
        }

        /// <summary>
        /// 
        /// </summary>
        internal static LogLevel MaxLevel
        {
            get { return Fatal; }
        }

        internal int OrdinalLogLevel
        {
            get { return _ordinalLogLevel; }
        }

        // to be changed into public in the future
        private LogLevel(string nameLogLevel, int ordinalLogLevel)
        {
            _nameLogLevel = nameLogLevel;
            _ordinalLogLevel = ordinalLogLevel;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="loglvl1"></param>
        /// <param name="loglvl2"></param>
        /// <returns></returns>
        public static bool operator ==(LogLevel loglvl1, LogLevel loglvl2)
        {
            if (ReferenceEquals(loglvl1, null))
            {
                return ReferenceEquals(loglvl2, null);
            }
            if (ReferenceEquals(loglvl2, null))
            {
                return false;
            }
            return loglvl1.OrdinalLogLevel == loglvl2.OrdinalLogLevel;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="loglvl1"></param>
        /// <param name="loglvl2"></param>
        /// <returns></returns>
        public static bool operator !=(LogLevel loglvl1, LogLevel loglvl2)
        {
            if (ReferenceEquals(loglvl1, null))
            {
                return !ReferenceEquals(loglvl2, null);
            }
            if (ReferenceEquals(loglvl2, null))
            {
                return true;
            }
            return loglvl1.OrdinalLogLevel != loglvl2.OrdinalLogLevel;
         
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="loglvl1"></param>
        /// <param name="loglvl2"></param>
        /// <returns></returns>
        public static bool operator >(LogLevel loglvl1, LogLevel loglvl2)
        {
            AssertNotNull(loglvl1, "loglvl1");
            AssertNotNull(loglvl2, "loglvl2");
            return loglvl1.OrdinalLogLevel > loglvl2.OrdinalLogLevel;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="loglvl1"></param>
        /// <param name="loglvl2"></param>
        /// <returns></returns>
        public static bool operator >=(LogLevel loglvl1, LogLevel loglvl2)
        {
            AssertNotNull(loglvl1, "loglvl1");
            AssertNotNull(loglvl2, "loglvl2");
            return loglvl1.OrdinalLogLevel >= loglvl2.OrdinalLogLevel;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="loglvl1"></param>
        /// <param name="loglvl2"></param>
        /// <returns></returns>
        public static bool operator <(LogLevel loglvl1, LogLevel loglvl2)
        {
            AssertNotNull(loglvl1, "loglvl1");
            AssertNotNull(loglvl2, "loglvl2");
            return loglvl1.OrdinalLogLevel < loglvl2.OrdinalLogLevel;
        }

        public static bool operator <=(LogLevel loglvl1, LogLevel loglvl2)
        {
            AssertNotNull(loglvl1, "loglvl1");
            AssertNotNull(loglvl2, "loglvl2");
            return loglvl1.OrdinalLogLevel <= loglvl2.OrdinalLogLevel;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ordinal"></param>
        /// <returns></returns>
        public static LogLevel FromLevel(int ordinal)
        {
            switch (ordinal)
            {
                case 0:
                {
                    return Trace;
                }
                case 1:
                {
                    return Debug;
                }
                case 2:
                {
                    return Info;
                }
                case 3:
                {
                    return Warn;
                }
                case 4:
                {
                    return Error;
                }
                case 5:
                {
                    return Fatal;
                }
                case 6:
                {
                    return Off;
                }
                default:
                {
                    throw new ArgumentException("Invalid ordinal.");
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lvlName"></param>
        /// <returns></returns>
        public static LogLevel FromString(string lvlName)
        {
            if (lvlName == null)
            {
                throw new ArgumentException("levelName");
            }
            if (lvlName.Equals("Trace", StringComparison.OrdinalIgnoreCase))
            {
                return Trace;
            }
            if (lvlName.Equals("Debug", StringComparison.OrdinalIgnoreCase))
            {
                return Debug;
            }
            if (lvlName.Equals("Info", StringComparison.OrdinalIgnoreCase))
            {
                return Info;
            }
            if (lvlName.Equals("Warn", StringComparison.OrdinalIgnoreCase))
            {
                return Warn;
            }
            if (lvlName.Equals("Error", StringComparison.OrdinalIgnoreCase))
            {
                return Error;
            }
            if (lvlName.Equals("Fatal", StringComparison.OrdinalIgnoreCase))
            {
                return Fatal;
            }
            if (lvlName.Equals("Off", StringComparison.OrdinalIgnoreCase))
            {
                return Off;
            }
            throw new ArgumentException("Unkown log level: " + lvlName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return NameLogLevel;
        }

        public override int GetHashCode()
        {
            return OrdinalLogLevel;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            LogLevel tmp = obj as LogLevel;
            if ((object) tmp == null)
            {
                return false;
            }
            return OrdinalLogLevel == tmp.OrdinalLogLevel;
        }

        /// <summary>
        /// Сравнивает уровень с другим LogLevel объектом
        /// </summary>
        /// <param name="obj">Объект</param>
        /// <returns>
        /// </returns>
        public int CompareTo(object obj)
        {
            var lvl = (LogLevel) obj;
            return OrdinalLogLevel - lvl.OrdinalLogLevel;
        }

        /// <summary>
        /// Утверждает что значение не является нулевым и генерирует исключение
        /// </summary>
        /// <param name="value">Значение для проверки</param>
        /// <param name="paramName">Имя параметра</param>
        public static void AssertNotNull(object value, string paramName)
        {
            if (value == null)
            {
                throw new ArgumentException(paramName);
            }
        }
    }
}
