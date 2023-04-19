using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightDemo.PageObjModel
{
    public class LoginPage
    {
        private static IPage? _page;
        private readonly ILocator _lnklogin;
        private readonly ILocator _txtUserName;
        private readonly ILocator _txtPassword;
        private readonly ILocator _btnLogin;
        private readonly ILocator _lnkEmployeeDetails;

        public LoginPage(IPage page)
        {
            _page = page;
            _lnklogin = _page.Locator(selector: "text=Login");
            _txtUserName = _page.Locator(selector: "#UserName");
            _txtPassword = _page.Locator(selector: "#Password");
            _btnLogin = _page.Locator(selector: "text=Log in");
            _lnkEmployeeDetails = _page.Locator(selector: "text=Employee Details");
        }

        public async Task ClickLogin() => await _lnklogin.ClickAsync();

        public async Task login(String userName, String password)
        {
            await _txtUserName.FillAsync(userName);
            await _txtPassword.FillAsync(userName);
            await _btnLogin.ClickAsync();
        }

        public async Task<bool> IsEmployeeDetailsExists() => await _lnkEmployeeDetails.IsVisibleAsync();
    }
}
