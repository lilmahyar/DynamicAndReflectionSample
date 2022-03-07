using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AttributeReadingWithReflection
{
    public class Report
    {
        public string Generate (List<object> items)
        {
            _ = items ??
                throw new ArgumentNullException($"{nameof(items)} is required");
            MemberInfo[] members = items.First().GetType().GetMembers();
            var report = new StringBuilder("# Report /n/n");
            report.Append(GetHeaders(members));
            return report.ToString();
        }

        const string CoulmnSeprator = " | ";
        StringBuilder GetHeaders(MemberInfo[] members)
        {
            var coulmnNames = new List<string>();
            var underscores = new List<string>();
            foreach (var member in members)
            {
                var attribute = member.GetCustomAttribute<CoulmnAttribute>();
                if(attribute != null)
                {
                    string columnTitle = attribute.Name;
                    string dashes = "".PadLeft(columnTitle.Length, '-');

                    coulmnNames.Add(columnTitle);
                    underscores.Add(dashes);
                }

            }
            var header = new StringBuilder();
            header.AppendJoin(CoulmnSeprator, coulmnNames);
            header.Append("\n");
            header.AppendJoin(CoulmnSeprator, underscores);
            header.Append("\n");

            return header; 
        }
    }
}
