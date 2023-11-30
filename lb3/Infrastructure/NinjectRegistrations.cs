using lb3.Models;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb3.Infrastructure
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IValueCalculator>().To<LinqValueCalculator>();
            Bind<IDiscountHelper>().To<DefaultDiscountHelper>()
                .WithConstructorArgument("discountSize", 50M);
            Bind<IDiscountHelper>().To<FlexibleDiscountHelper>()
                .WhenInjectedInto<LinqValueCalculator>();
        }
    }
}
