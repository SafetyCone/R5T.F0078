using System;

using CliWrap;

using R5T.T0132;


namespace R5T.F0078
{
	[FunctionalityMarker]
	public partial interface ICliOperator : IFunctionalityMarker
	{
		public string FormatResult(CommandResult result)
        {
			var representation = $"{result.ExitCode}, {result.RunTime} ({result.StartTime} to {result.ExitTime})";
			return representation;
        }

		public PipeTarget Get_ConsolePipeTarget()
        {
			var pipeTarget = PipeTarget.ToDelegate(Console.WriteLine);
			return pipeTarget;
        }
	}
}