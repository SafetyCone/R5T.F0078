using System;

using CliWrap;

using R5T.T0132;


namespace R5T.F0078
{
	[FunctionalityMarker]
	public partial interface ICommandOperator : IFunctionalityMarker
	{
		public Command WithConsoleError(Command command)
		{
			var outputCommand = command.WithStandardErrorPipe(
				Instances.CliOperator.Get_ConsolePipeTarget());

			return outputCommand;
		}

		public Command WithConsoleOutput(Command command)
        {
			var outputCommand = command.WithStandardOutputPipe(
				Instances.CliOperator.Get_ConsolePipeTarget());

			return outputCommand;
        }
	}
}