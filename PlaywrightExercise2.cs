using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using Microsoft.Playwright.Transport.Protocol;
using NUnit.Framework;
using System.Threading.Tasks;

namespace PlaywrightDemo;

public class Test2 : PageTest
{
    //[SetUp]
    public async Task Setup()
    {
        await Page.GotoAsync(url: "http://eaapp.somee.com/");
    }

    public async Task TestExecuteBkp()
    {
        Page.SetDefaultTimeout(1);
        await Page.ClickAsync(selector: "text=Login");
        await Page.FillAsync(selector: "#UserName", "admin");
        await Page.FillAsync(selector: "#Password", "password");
        await Page.ClickAsync(selector: "text=Log in");
        //await Expect(Page.Locator(selector: "text=Employee Details")).ToBeVisibleAsync();
    }

    //[Test]
    public async Task TestExecute()
    {
        var lnkLogin = Page.Locator(selector: "text=Login");
        await lnkLogin.ClickAsync();
        await Page.FillAsync(selector: "#UserName", "admin");
        await Page.FillAsync(selector: "#Password", "password");
        var btnLogin = Page.Locator(selector: "input", new PageLocatorOptions { HasTextString = "Log in" });
        await btnLogin.ClickAsync();
        await Expect(Page.Locator(selector: "text=Employee Details")).ToBeVisibleAsync();
    }
}