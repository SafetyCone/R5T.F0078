using System;


namespace R5T.F0078
{
	public class CommandOperator : ICommandOperator
	{
		#region Infrastructure

	    public static ICommandOperator Instance { get; } = new CommandOperator();

	    private CommandOperator()
	    {
        }

	    #endregion
	}
}