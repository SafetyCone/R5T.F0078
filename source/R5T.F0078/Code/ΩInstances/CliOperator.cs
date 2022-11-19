using System;


namespace R5T.F0078
{
	public class CliOperator : ICliOperator
	{
		#region Infrastructure

	    public static ICliOperator Instance { get; } = new CliOperator();

	    private CliOperator()
	    {
        }

	    #endregion
	}
}