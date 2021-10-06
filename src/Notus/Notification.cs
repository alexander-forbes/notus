using System;
using System.Collections.Generic;
using System.Linq;

namespace Notus
{
    public class Notification
    {
	    private readonly IList<Error> _Errors = new List<Error>();
	    private readonly IList<Warning> _Warnings = new List<Warning>();

	    public IEnumerable<Error> Errors => _Errors;
	    public IEnumerable<Warning> Warnings => _Warnings;

		public bool HasErrors => _Errors.Any();
	    public bool HasWarnings => _Warnings.Any();

		public void AddError(Error error)
		{
			if (error == null)
				throw new ArgumentNullException(nameof(error));

			_Errors.Add(error);
		}

		public void AddError(string message)
		{
			_Errors.Add(new Error(message));
		}

		public bool IncludesError(string message)
		{
			return _Errors.Any(error => string.Equals(error.ToString(), message, StringComparison.InvariantCultureIgnoreCase));
		}

	    public void AddWarning(Warning warning)
	    {
		    if (warning == null)
			    throw new ArgumentNullException(nameof(warning));

		    _Warnings.Add(warning);
	    }

	    public void AddWarning(string message)
	    {
		    _Warnings.Add(new Warning(message));
	    }

	    public bool IncludesWarning(string message)
	    {
		    return _Warnings.Any(warning => string.Equals(warning.ToString(), message, StringComparison.InvariantCultureIgnoreCase));
	    }
	}
}
