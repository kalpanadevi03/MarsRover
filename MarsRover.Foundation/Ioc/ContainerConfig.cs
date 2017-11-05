using Autofac;
using MarsRover.BusinessLogic.Rover;
using MarsRover.BusinessLogic.Rover.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Foundation.Ioc
{
    //Autofac container config
    public static class ContainerConfig
    {
        public static Autofac.IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterInstance(new Rover()).As<IRover>();
            builder.RegisterInstance(new Plateau()).As<IPlateau>();
            builder.RegisterInstance(new Position()).As<IPosition>();

            builder.RegisterType<RoverApp>();
            builder.RegisterType<Orientations>();

            return builder.Build();
        }
    }
}
