using System;

namespace Notus
{
	public abstract class NoticeBase
	{
		private readonly string _Message;

		protected NoticeBase(string message)
		{
			if (string.IsNullOrEmpty(message))
				throw new ArgumentNullException(nameof(message));

			_Message = message;
		}

		public override string ToString()
		{
			return _Message;
		}
	}
}
