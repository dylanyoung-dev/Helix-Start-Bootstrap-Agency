using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helix.Foundation.Ioc
{
    public class ServiceAttribute : Attribute
    {
        public Lifetime Lifetime { get; set; } = Lifetime.Singleton;
    }
}
