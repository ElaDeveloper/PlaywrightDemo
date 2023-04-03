//using Microsoft.Playwright;

//namespace PlaywrightDemo;

//public class Test1
//{
//    [SetUp]
//    public void Setup()
//    {
//    }

//    [Test]
//    public async Task TestExample()
//    {
//        using var playwright = await Playwright.CreateAsync();
//        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
//        {
//            Headless = false
//        });
//        var page = await browser.NewPageAsync();
//        await page.GotoAsync("http://eaapp.somee.com/");
//        await page.ClickAsync(selector: "text=Login");
//        await page.FillAsync(selector: "#UserName", "admin");
//        await page.FillAsync(selector: "#Password", "admin");
//        await page.ClickAsync(selector: "text=Log in");
//        var isExist = await page.Locator(selector: "text=Employee Details").IsVisibleAsync();
//        Assert.IsTrue(isExist);
//    }
//}