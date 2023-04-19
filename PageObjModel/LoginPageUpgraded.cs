using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PlaywrightDemo.PageObjModel
{
    public class LoginPageUpgraded
    {
        private static IPage _page;

        public LoginPageUpgraded(IPage page) => _page = page;

        private ILocator _lnkLogin => _page.Locator(selector: "text=Login");
        private ILocator _txtUserName => _page.Locator(selector: "#UserName");
        private ILocator _txtPassword => _page.Locator(selector: "#Password");
        private ILocator _btnLogin => _page.Locator(selector: "text=Log in");

        private ILocator _lnkEmployeeDetails => _page.Locator(selector: "text=Employee Details");

        //public async Task ClickLogin() => await _lnkLogin.ClickAsync();

        public async Task ClickLogin()
        {
            await _lnkLogin.ClickAsync();
            await _page.WaitForURLAsync("**/Login");
        }

        public async Task Login(String userName, String password)
        {
            await _txtUserName.FillAsync(userName);
            await _txtPassword.FillAsync(password);
        }

        public async Task ClickEnter() => await _btnLogin.ClickAsync();

        public async Task<bool> IsEmployeeDetailsExists() => await _lnkEmployeeDetails.IsVisibleAsync();
    }
}
