using Autofac;
using FatCat.Toolkit.Console;
using FatCat.Toolkit.Injection;

namespace OneOff;

public static class Program
{
	public static string[] Args { get; set; }

	public static async Task Main(params string[] args)
	{
		await Task.CompletedTask;

		Args = args;

		ConsoleLog.LogCallerInformation = true;

		try
		{
			SystemScope.Initialize(
				new ContainerBuilder(),
				[typeof(Program).Assembly, typeof(ConsoleLog).Assembly],
				ScopeOptions.SetLifetimeScope
			);
		}
		catch (Exception ex)
		{
			ConsoleLog.WriteException(ex);
		}
	}
}
