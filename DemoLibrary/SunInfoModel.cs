using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class SunInfoModel
    {
        public DateTime SunRise { get; set; }
        public DateTime SunSet { get; set; }
        public DateTime Civil_Twilight_Begin { get; set; }
        public DateTime Nautical_Twilight_End { get; set; }
    }
}
