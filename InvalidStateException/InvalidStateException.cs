using System;
using System.Runtime.Serialization;

namespace InvalidStateException
{
	public class InvalidStateException : Exception
	{
		public InvalidStateException()
			: base(DefaultMessage)
		{
		}

		public InvalidStateException(string message)
			: base(Format(message))
		{
		}

		public InvalidStateException(string message, Exception innerException)
			: base(Format(message), innerException)
		{
		}

		protected InvalidStateException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		private const string DefaultMessage =
			"This Exception indicates an Invalid State has been reached, and should not be caught";
		private static string Format(string message)
		{
			return $"{DefaultMessage}:\n{message}";
		}
	}
}
