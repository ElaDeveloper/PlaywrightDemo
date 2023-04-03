using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System.Threading.Tasks;

namespace PlaywrightDemo;

public class Test2 : PageTest
{
    [SetUp]
    public async Task Setup()
    {
        await Page.GotoAsync(url:"http://eaapp.somee.com/");
    }

    [Test]
    public async Task TestExecute()
    {
        await Page.ClickAsync(selector: "text=Login");
        await Page.FillAsync(selector: "#UserName", "admin");
        await Page.FillAsync(selector: "#Password", "admin");
        await Page.ClickAsync(selector: "text=Log in");
        //await Expect(Page.Locator(selector: "text=Employee Details")).ToBeVisibleAsync();
    }
}