using System;

using CliWrap;


namespace R5T.F0078.Extensions
{
    public static class CommandExtensions
    {
        public static Command WithConsoleError(this Command command)
        {
            var output = CommandOperator.Instance.WithConsoleError(command);
            return output;
        }

        public static Command WithConsoleOutput(this Command command)
        {
            var output = CommandOperator.Instance.WithConsoleOutput(command);
            return output;
        }
    }
}
