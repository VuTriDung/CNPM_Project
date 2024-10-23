using KoiPool_Project.Models;
using KoiPool_Project.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace KoiPool_Project.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUserModel> _userManager;
        private readonly SignInManager<AppUserModel> _signInManager;
        private readonly DataContext _context;

        public AccountController(
            UserManager<AppUserModel> userManager,
            SignInManager<AppUserModel> signInManager,
            DataContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        // Phương thức GET cho Login
        public IActionResult Login(string returnUrl )
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel LoginVM)
        {
            // Kiểm tra tính hợp lệ của model
            if (!ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(LoginVM.Username,LoginVM.Password,false, false);

                if (result.Succeeded)
                {
                    // Điều hướng về trang chủ khi đăng nhập thành công
                    return RedirectToAction("Index", "Home");

                }
                ModelState.AddModelError(string.Empty, "Tên đăng nhập và mật khẩu không tồn tại.");

            }
            return View(LoginVM);
        }




        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserModel user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Kiểm tra xem email đã tồn tại chưa
                    var existingUser = await _userManager.FindByEmailAsync(user.Email);
                    if (existingUser != null)
                    {
                        ModelState.AddModelError(string.Empty, "Email này đã được sử dụng");
                        return View(user);
                    }

                    // Kiểm tra tên đăng nhập đã tồn tại chưa
                    var existingUsername = await _userManager.FindByNameAsync(user.Username);
                    if (existingUsername != null)
                    {
                        ModelState.AddModelError(string.Empty, "Tên đăng nhập này đã được sử dụng");
                        return View(user);
                    }

                    var newUser = new AppUserModel
                    {
                        UserName = user.Username,
                        Email = user.Email,
                        Occupation = "User" // Giá trị mặc định
                    };

                    var result = await _userManager.CreateAsync(newUser, user.Password);

                    if (result.Succeeded)
                    {
                        // Đăng nhập người dùng sau khi đăng ký thành công
                        await _signInManager.SignInAsync(newUser, isPersistent: false);
                        return RedirectToAction("Login", "Account");
                    }

                    // Chỉ thêm thông báo lỗi đầu tiên vào ModelState
                    var error = result.Errors.FirstOrDefault();
                    if (error != null)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
                catch (Exception ex)
                {
                    // Log lỗi
                    ModelState.AddModelError(string.Empty, "Đã xảy ra lỗi trong quá trình đăng ký: " + ex.Message);
                }
            }

            // Trả về view với các lỗi nếu có
            return View(user);
        }
        public async Task<IActionResult> Logout(string returnUrl = "/")
        {
            await _signInManager.SignOutAsync();
            return Redirect(returnUrl);
        }
        // Phương thức kiểm tra kết nối database
        public IActionResult TestDbConnection()
        {
            try
            {
                var canConnect = _context.Database.CanConnect();
                return Json(new { success = canConnect });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}
