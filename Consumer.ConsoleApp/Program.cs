using Consumer.ConsoleApp;
using Vax;

var services = new ServiceCollection();

// services.AddSingleton<IConsoleWriter, ConsoleWriter>();
// services.AddSingleton<IIdGenerator, IdGenerator>();
// services.AddTransient<ConsoleWriter>();
services.AddSingleton(new IdGenerator(new ConsoleWriter()));

var serviceProvider = services.BuildServiceProvider();

var serviceA = serviceProvider.GetService<IIdGenerator>();
var serviceB = serviceProvider.GetService<IIdGenerator>();

serviceA?.PrintId();
serviceB?.PrintId();