using System;
using NUnit.Framework;

namespace Notus.Tests
{
	public class When_constructing_a_notification
	{
		[Test]
		public void It_should_set_the_errors_to_an_empty_enumerable()
		{
			var notification = new Notification();
			Assert.IsNotNull(notification.Errors);
			CollectionAssert.IsEmpty(notification.Errors);
		}

		[Test]
		public void It_should_return_true_if_there_are_any_errors()
		{
			var notification = new Notification();
			notification.AddError("error");
			Assert.IsTrue(notification.HasErrors);
		}

		[Test]
		public void It_should_return_false_if_there_are_no_errors()
		{
			var notification = new Notification();
			Assert.IsFalse(notification.HasErrors);
		}

		[Test]
		public void It_should_throw_an_exception_when_adding_a_null_error()
		{
			var notification = new Notification();
			var exception = Assert.Throws<ArgumentNullException>(() => notification.AddError((Error) null));
			Assert.AreEqual($"Value cannot be null. (Parameter 'error')", exception.Message);
		}

		[Test]
		public void It_should_return_true_when_the_error_is_present()
		{
			var notification = new Notification();
			notification.AddError("error-1");
			notification.AddError("error-2");

			Assert.IsTrue(notification.IncludesError("Error-2"));
		}

		[Test]
		public void It_should_return_false_when_the_error_is_not_present()
		{
			var notification = new Notification();
			notification.AddError("error-1");
			notification.AddError("error-2");

			Assert.IsFalse(notification.IncludesError("error-3"));
		}

		[Test]
		public void It_should_set_the_warnings_to_an_empty_enumerable()
		{
			var notification = new Notification();
			Assert.IsNotNull(notification.Warnings);
			CollectionAssert.IsEmpty(notification.Warnings);
		}

		[Test]
		public void It_should_return_true_if_there_are_any_warnings()
		{
			var notification = new Notification();
			notification.AddWarning("warning");
			Assert.IsTrue(notification.HasWarnings);
		}

		[Test]
		public void It_should_return_false_if_there_are_no_warnings()
		{
			var notification = new Notification();
			Assert.IsFalse(notification.HasWarnings);
		}

		[Test]
		public void It_should_throw_an_exception_when_adding_a_null_warning()
		{
			var notification = new Notification();
			var exception = Assert.Throws<ArgumentNullException>(() => notification.AddWarning((Warning) null));
			Assert.AreEqual($"Value cannot be null. (Parameter 'warning')", exception.Message);
		}

		[Test]
		public void It_should_return_true_when_the_warning_is_present()
		{
			var notification = new Notification();
			notification.AddWarning("warning-1");
			notification.AddWarning("warning-2");

			Assert.IsTrue(notification.IncludesWarning("Warning-2"));
		}

		[Test]
		public void It_should_return_false_when_the_warning_is_not_present()
		{
			var notification = new Notification();
			notification.AddError("warning-1");
			notification.AddError("warning-2");

			Assert.IsFalse(notification.IncludesWarning("Warning-3"));
		}
	}
}
