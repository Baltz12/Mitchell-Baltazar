using System.Text.RegularExpressions;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System.Threading;
using System;
using TP.SDK;
using TP.SDK.Tests.Helpers;
using TP.SDK.Tests;
using TP.Common.Attributes;
using TP.Common.Enums;

namespace TestProject.Generated.Tests.Baltz
{
	public class Ryze : IWebTest
	{
		[ParameterAttribute(Description = "Auto generated application URL parameter", DefaultValue = "https://ryze-staging.formedix.com/sign-in", Direction = ParameterDirection.Input)]
		public string ApplicationURL;
		public ExecutionResult Execute(WebTestHelper helper)
		{
			var driver = helper.Driver;
			var report = helper.Reporter;
			bool boolResult;
			By by;
			
			// set timeout for driver actions (similar to step timeout)
			driver.Timeout = 15000;
			
			 // 1. Navigate to '{{ApplicationURL}}'
			// Navigates the specified URL (Auto-generated)
			// Add step sleep time (Before)
			Thread.Sleep(500);
			boolResult = driver.TP().NavigateToURL(ApplicationURL);
			report.Step(string.Format("Navigate to '{0}'", ApplicationURL), boolResult, TakeScreenshotConditionType.Failure);
			
			 // 2. Click 'username'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#username");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'username'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 3. Type 'testteamtechtest' in 'username'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#username");
			boolResult = driver.TP().TypeText(by, "testteamtechtest");
			report.Step("Type 'testteamtechtest' in 'username'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 4. Click 'password'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#password");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'password'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 5. Type 'T3st3rT3ch' in 'password'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#password");
			boolResult = driver.TP().TypeText(by, "T3st3rT3ch");
			report.Step("Type 'T3st3rT3ch' in 'password'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 6. Click 'SIGN IN'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#btnSubmit");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'SIGN IN'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 7. Click 'Repository'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.XPath("//p[. = 'Repository']");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'Repository'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 8. Click 'menuMdbStudies'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#menuMdbStudies");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'menuMdbStudies'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 9. Click 'fdxMdbContainerListItem0MenuToggle'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#fdxMdbContainerListItem0MenuToggle");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'fdxMdbContainerListItem0MenuToggle'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 10. Click 'View'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#fdxMdbContainerListItem0View");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'View'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 11. Click 'ViewAssetGroupdataAcquisition'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#ViewAssetGroupdataAcquisition");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'ViewAssetGroupdataAcquisition'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 12. Click 'FORMTypeView'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#FORMTypeView");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'FORMTypeView'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 13. Click 'Medical History'
			// Add step sleep time (Before)
			Thread.Sleep(1000);
			by = By.XPath("//div[1][. = 'Medical History']");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'Medical History'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 14. Click 'Edit form'
			// Add step sleep time (Before)
			Thread.Sleep(1000);
			by = By.XPath("//span[. = 'Edit form']");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'Edit form'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 15. Click 'SPAN'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.XPath("//div[6]/fdx-mdb-asset-edit-prop/div/div[1]/div/span[1]");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'SPAN'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 16. Click 'Text'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#assetLocaleEditTextTextareadescription");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'Text'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 17. Click 'Text'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#assetLocaleEditTextTextareadescription");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'Text'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 18. Type 'This is a description' in 'Text'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#assetLocaleEditTextTextareadescription");///last
			boolResult = driver.TP().TypeText(by, "This is a description");
			report.Step("Type 'This is a description' in 'Text'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 19. Click 'Validate & Update'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#saveAsset");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'Validate & Update'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 20. Click 'Validate & Update'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#saveAsset");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'Validate & Update'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 21. Click 'Close edit'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#switchEditMode");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'Close edit'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 22. Does 'DIV' contain '[NONE]'?
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.XPath("//div[6]/fdx-mdb-asset-edit-view/div/div[3]/div/div");
			boolResult = driver.TP().ContainsText(by, "");
			report.Step("Does 'DIV' contain '[NONE]'?", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 23. Click 'DIV1'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.XPath("//ul[2]/li[2]/fdx-main-nav-item/div");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'DIV1'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 24. Click 'Sign out'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.XPath("//span[. = 'Sign out']");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'Sign out'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 25. Does 'You have signed out.' contain 'You have signed out.'?
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.XPath("//div[. = 'You have signed out.']");
			boolResult = driver.TP().ContainsText(by, "You have signed out.");
			report.Step("Does 'You have signed out.' contain 'You have signed out.'?", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 26. Click 'username'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#username");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'username'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 27. Type 'testteamtechtest' in 'username'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#username");
			boolResult = driver.TP().TypeText(by, "testteamtechtest");
			report.Step("Type 'testteamtechtest' in 'username'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 28. Click 'password'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#password");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'password'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 29. Type 'T3st3rT3ch' in 'password'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#password");
			boolResult = driver.TP().TypeText(by, "T3st3rT3ch");
			report.Step("Type 'T3st3rT3ch' in 'password'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 30. Click 'SIGN IN'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#btnSubmit");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'SIGN IN'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 31. Click 'P'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.XPath("//ul[1]/li[2]/fdx-main-nav-item//p[1]");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'P'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 32. Click 'menuMdbStudies'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#menuMdbStudies");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'menuMdbStudies'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 33. Click 'fdxMdbContainerListItem0MenuToggle'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#fdxMdbContainerListItem0MenuToggle");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'fdxMdbContainerListItem0MenuToggle'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 34. Click 'View'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#fdxMdbContainerListItem0View");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'View'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 35. Click 'Data acquisition'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#dataAcquisitionName");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'Data acquisition'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 36. Click 'FORMTypeView'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#FORMTypeView");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'FORMTypeView'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 37. Click 'MFDDB'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.XPath("//span[. = 'MFDDB']");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'MFDDB'", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 38. Does 'Medical History2' contain 'Medical History'?
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.XPath("//div/div[1]/div/div/div[1]/span/span[. = 'Medical History']");
			boolResult = driver.TP().ContainsText(by, "Medical History");
			report.Step("Does 'Medical History2' contain 'Medical History'?", boolResult, TakeScreenshotConditionType.Failure);
			
			 // 39. Click 'Edit form'
			// set timeout for driver actions (similar to step timeout)
			driver.Timeout = 25000;
			// Add step sleep time (Before)
			Thread.Sleep(1000);
			by = By.XPath("//span[. = 'Edit form']");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'Edit form'", boolResult, TakeScreenshotConditionType.Failure);
			// set timeout for driver actions (similar to step timeout)
			driver.Timeout = 15000;
			
			 // 40. Click 'Remove'
			// set timeout for driver actions (similar to step timeout)
			driver.Timeout = 25000;
			// Add step sleep time (Before)
			Thread.Sleep(1000);
			by = By.CssSelector("#localeRemovedescriptionfr");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'Remove'", boolResult, TakeScreenshotConditionType.Failure);
			// set timeout for driver actions (similar to step timeout)
			driver.Timeout = 15000;
			
			 // 41. Click 'Validate & Update'
			// Add step sleep time (Before)
			Thread.Sleep(500);
			by = By.CssSelector("#saveAsset");
			boolResult = driver.TP().Click(by);
			report.Step("Click 'Validate & Update'", boolResult, TakeScreenshotConditionType.Failure);
			
			return ExecutionResult.Passed;
		}
	}
}