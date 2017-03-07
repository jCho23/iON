using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;

namespace iON
{
	[TestFixture]
	public class Tests
	{
		AndroidApp app;

		[SetUp]
		public void BeforeEachTest()
		{
			// TODO: If the Android app being tested is included in the solution then open
			// the Unit Tests window, right click Test Apps, select Add App Project
			// and select the app projects that should be tested.
			app = ConfigureApp
				.Android
				// TODO: Update this path to point to your Android app and uncomment the
				// code if the app is not included in the solution.
				.ApkFile("iOn.apk")
				.StartApp();
		}

		[Test]
		public void iON()

		{
			app.Repl();

			app.Flash(x => x.Id("SignUp"));
			app.Tap(x => x.Id("SignUp"));
			app.Screenshot("This is the Sign Up page");

			app.Tap(x => x.Id("FirstNameCaption"));
			app.EnterText(x => x.Id("FirstName"), "Xamarin");
			app.EnterText(x => x.Id("LastName"), "Test");
			app.Screenshot("First and Last name field");

			app.Back();
			app.Tap(x => x.Id("Email"));
			app.EnterText(x => x.Id("Email"), "Xamarin@test.com");
			app.Screenshot("E-mail Field");
			app.DismissKeyboard();

			app.EnterText(x => x.Id("Phone"), "415-888-8888");
			app.Screenshot("Phone number Field");
			app.DismissKeyboard();

			app.EnterText(x => x.Id("FacilityName"), "Xamarin");
			app.Screenshot("Scroll down Facility Name field");
			app.DismissKeyboard();

			app.EnterText(x => x.Id("FacilityZIP"), "94111");
			app.DismissKeyboard();
			app.Screenshot("Facility Zip Field");


			app.Tap(x => x.Id("CompanyTypeList"));
			app.ScrollDownTo("Wound Care Clinic");
			app.Tap("Wound Care Clinic");
			app.Screenshot("Scroll down to Wound Care Clinic ");

			app.Tap(x => x.Id("LicenseType"));
			app.ScrollDownTo("RN");
			app.Screenshot("License Type Field");
			app.Tap("RN");

			app.ScrollDownTo(x => x.Id("PIN"));
			app.EnterText(x => x.Id("PIN"), "Xamarin23");
			app.EnterText(x => x.Id("ConfirmPIN"), "Xamarin23");
			app.Screenshot("Password Field");
			app.DismissKeyboard();

			app.Tap(x => x.Id("Toggle"));
			app.Screenshot("Toggle Field");

			app.Tap(x => x.Id("GetVerified"));

			app.SwipeRightToLeft();
			app.Screenshot("Swipe Image #1");
			app.SwipeRightToLeft();
			app.Screenshot("Swipe Image #2");
			app.SwipeRightToLeft();
			app.Screenshot("Swipe Image #3");
			app.SwipeRightToLeft();
			app.Screenshot("Swipe Image #4");
			app.SwipeRightToLeft();
			app.Screenshot("Swipe Image #5");
			app.SwipeRightToLeft();
			app.Screenshot("Swipe Image #6");

			app.WaitForElement(x => x.Id("GetStarted"));
			app.Tap(x => x.Id("GetStarted"));
			app.Screenshot("Landing Page");

			app.WaitForElement(x => x.Id("ProductsImage"));
			app.Flash(x => x.Id("ProductsImage"));
			app.Tap(x => x.Id("ProductsImage"));
			app.Screenshot("Product Field");
			app.Back();

			app.Flash(x => x.Id("CreateWoundAssessmentImage"));
			app.Tap(x => x.Id("CreateWoundAssessmentImage"));
			app.ScrollDownTo(x => x.Id("TherapyStatus"));
			app.Screenshot("Therapy Field");
			app.Back();
			app.Back();




		}
	}
}

