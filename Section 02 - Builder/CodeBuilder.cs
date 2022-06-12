using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02Builder
{
    public class CodeBuilder
    {
        private string _className;
        private List<string> _fieldName = new List<string>();
        private List<string> _fieldType = new List<string>();
        
        public CodeBuilder(string className)
        {
            this._className = className;
        }

        public CodeBuilder AddField(string name, string type)
        {
            _fieldName.Add(name);
            _fieldType.Add(type);
            return this;
        }

        private string MakeString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"public class {_className}");
            builder.AppendLine("{");

            for(int i = 0; i < _fieldName.Count; i++) 
            {
                builder.AppendLine($"  public {_fieldType[i]} {_fieldName[i]};");
            }
            builder.AppendLine("}");
            return builder.ToString();
        }

        public override string ToString()
        {
            return MakeString();
        }
    }
}
