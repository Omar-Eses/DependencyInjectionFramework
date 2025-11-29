using Consumer.ConsoleApp;
using Vax;

var services = new ServiceCollection();

services.AddSingleton<IConsoleWriter, ConsoleWriter>();
services.AddSingleton<IIdGenerator, IdGenerator>();

var serviceProvider = services.BuildServiceProvider();
var service = serviceProvider.GetService<IConsoleWriter>();

var serviceA = serviceProvider.GetService<IIdGenerator>();
var serviceB = serviceProvider.GetService<IIdGenerator>();

serviceA.PrintId();
serviceB.PrintId();

// TRANSIENT
// 8e3204d4-7209-442c-b939-ed641d30534c
// f92bfb2a-c38c-4ef1-98bb-1021316bd1d0
//     Hello World!
// SINGLETON
// 2d5c7e94-4101-4ef7-b949-c67b7f7de3d1
// 2d5c7e94-4101-4ef7-b949-c67b7f7de3d1
// Hello World!