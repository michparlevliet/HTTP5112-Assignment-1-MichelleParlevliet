using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HTTP5111_Assignment1_MichelleParlevliet.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}