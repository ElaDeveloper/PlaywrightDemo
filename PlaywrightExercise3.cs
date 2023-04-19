using Microsoft.Playwright;
using PlaywrightDemo.PageObjModel;

namespace PlaywrightDemo;

public class Test3
{
    [SetUp]
    public void Setup()
    {
    }

    //[Test]
    public async Task TestExample()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false
        });
        var page = await browser.NewPageAsync();
        await page.GotoAsync("http://eaapp.somee.com/");
        LoginPageUpgraded loginPage = new LoginPageUpgraded(page);
        await loginPage.ClickLogin();
        await loginPage.Login("admin", "password");
        await loginPage.ClickEnter();
        var isExist = await loginPage.IsEmployeeDetailsExists();
        Assert.IsTrue(isExist);
    }
}