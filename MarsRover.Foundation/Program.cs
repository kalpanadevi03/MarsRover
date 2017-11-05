using Autofac;
using MarsRover;
using MarsRover.Foundation.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Foundation
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();
            container.Resolve<RoverApp>().Run();
            Console.ReadLine();
        }
    }
}
