using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start.utils
{

    /***
     * Class to handle date formats
     * 
     **/
    public sealed class DateFormat
    {
        private static string DDMMYYYY = "dd/MM/yyyy";
        private static string DDMYYYYHMMSSA = "dd/MM/yyyy h:mm:ss a";
        public enum DateFormatType
        {
            DDMMYYYY,
            DDMYYYYHMMSSA
        }

        private String type;
        private DateFormat(String type)
        {
            this.type = type;
        }

        public string Format
        {
            get { 
                if(type == null)
                    {
                    return DDMMYYYY; // Default format
                }
                return type;
            }
            private set { }
        }

        /**
         * Factory method to create DateFormat instance based on type
         * @param type DateFormatType
         * @return DateFormat instance
         **/
        public static DateFormat Build(DateFormatType type){ 
            return type switch
            {
                DateFormatType.DDMMYYYY => new DateFormat(DDMMYYYY),
                DateFormatType.DDMYYYYHMMSSA => new DateFormat(DDMYYYYHMMSSA),
                _ => new DateFormat(DDMMYYYY),
            };
        }
        /**
         * Factory method to create DateFormat instance with default format
         * @return DateFormat instance with default format
         * @see DateFormatType
         **/
        public static DateFormat Build() { 
            return new DateFormat(DDMMYYYY);
        }
    }
    public static class DateTimeUtils
    {
        public static long GetCurrentTimeOnMilliseconds()
        {
            return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        }

        public static string FormateDate(long timestamp, DateFormat format)
        {
            DateTime dateTime = DateTimeOffset.FromUnixTimeMilliseconds(timestamp).UtcDateTime;
            return dateTime.ToString(format.Format);
        }
        public static string FormateDate(long timestamp)
        {
            DateTime dateTime = DateTimeOffset.FromUnixTimeMilliseconds(timestamp).UtcDateTime;
            return dateTime.ToString(DateFormat.Build().Format);
        }
    }
}
