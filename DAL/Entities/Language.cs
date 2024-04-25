using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Language : HardcodeDirectory
    {
        public virtual ICollection<LanguageList> LanguageLists { get; } = new List<LanguageList>();
    }
}
