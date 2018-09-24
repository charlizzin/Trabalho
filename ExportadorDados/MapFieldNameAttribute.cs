using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportadorDados
{

    [AttributeUsage(AttributeTargets.Property)]
    public class MapFieldNameAttribute : Attribute
    {
        public List<string> AttributeNames { get; set; }

        public MapFieldNameAttribute(params string[] attributeName)
        {
            this.AttributeNames = attributeName.ToList();
        }
    }
}
