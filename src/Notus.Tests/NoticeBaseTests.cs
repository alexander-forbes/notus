using System;
using NUnit.Framework;

namespace Notus.Tests
{
	[TestFixture]
    public class When_constructing_a_notice
    {
	    [Test]
	    public void And_the_message_is_null_it_should_throw_an_exception()
	    {
		    var exception = Assert.Throws<ArgumentNullException>(() => new Notice(null));
		    Assert.AreEqual($"Value cannot be null. (Parameter 'message')", exception.Message);
	    }

	    [Test]
	    public void And_the_message_is_empty_it_should_throw_an_exception()
	    {
		    var exception = Assert.Throws<ArgumentNullException>(() => new Notice(string.Empty));
			Assert.AreEqual($"Value cannot be null. (Parameter 'message')", exception.Message);
		}
	}

	[TestFixture]
	public class When_calling_to_string_on_notice
	{
		[Test]
		public void It_should_return_the_error_message()
		{
			const string message = "Error";
			var error = new Notice(message);
			Assert.AreEqual(message, error.ToString());
		}
	}

	internal class Notice : NoticeBase
	{
		public Notice(string message) : base(message)
		{
		}
	}
}
