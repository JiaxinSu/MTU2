using System;
namespace MTUdemo
{
	[TestFixture]
	public class EmptyClass
	{
		private IWebDriver driver;
		string url = "http://symbiote-app.herokuapp.com/";

		[SetUp]
		public void TestSetup()
		{
			driver = new FirefoxDriver();
			driver.Navigate().GoToUrl(url);
		}

		[TearDown]
		public void Cleanup()
		{
			driver.Quit();
		}

		[Test]
		public void LoginAsAdmin()
		{
			driver.FindElement(By.Id("open")).Click();
			driver.FindElement(By.Id("username")).SendKeys("admin");
			driver.FindElement(By.Id("password")).SendKeys("admin");
			driver.FindElement(By.Id("login-button")).Click();
		}
	}
}

