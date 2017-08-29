using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.TimeZoneInfo;
using System.DateTime;


namespace ConsoleApplication7
{
    public class Baby
    {
        private String name;
        private DateTime birth;
        private String continent;
        private String city;

        public Baby(String name, DateTime birth, String continent, String city)
        {
            this.name = name;
            this.birth = birth;
            this.continent = continent;
            this.city = city;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getBirth()
        {
            return convertoTimeZone(continent, city);
        }

        public void setBirth(DateTime birth)
        {
            this.birth = birth;
        }

        public String getContinent()
        {
            return continent;
        }

        public void setContinent(String continent)
        {
            this.continent = continent;
        }

        public String getCity()
        {
            return city;
        }

        public void setCity(String city)
        {
            this.city = city;
        }

        public String getBirthInOtherTimeZone(String continent, String city)
        {
            return convertoTimeZone(continent, city);
        }

        public String convertoTimeZone(String continent, String city)
        {
            Calendar calendar = new GregorianCalendar();
            calendar.setTime(this.birth);

            DateTimeFormat formatter = new SimpleDateTimeFormat("dd MMM yyyy HH:mm:ss z");

            formatter.setCalendar(calendar);
            formatter.setTimeZone(TimeZone.getTimeZone(continent + "/" + city));

            return formatter.format(calendar.getTime());
        }
    }
}
