var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

// Sử dụng các middleware bảo mật như xác thực và phân quyền
app.UseAuthorization();

// Đảm bảo sử dụng tài nguyên tĩnh như hình ảnh, JavaScript và CSS
app.UseStaticFiles(); // Chú ý là .UseStaticFiles() thay vì .MapStaticAssets()

// Cấu hình các route cho các controller và các action tương ứng
app.MapControllerRoute(
    "default",
    "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    "admin",
    "admin/{action=Admin}/{id?}",
    new { controller = "Admin", action = "Admin" }
);


// Chạy ứng dụng
app.Run();