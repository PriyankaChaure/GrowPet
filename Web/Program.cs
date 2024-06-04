using Entities;
using Microsoft.EntityFrameworkCore;
using Reposiratory.Admin;
using Reposiratory.Store1;
using Reposiratory.Users;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(
    opt =>
    {
        opt.IdleTimeout = TimeSpan.FromMinutes(15);
        opt.Cookie.HttpOnly= true;
        opt.Cookie.IsEssential= true;
    }
    );
builder.Services.AddDbContextPool<ContextClass>(opt => opt.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("scon")));
builder.Services.AddScoped<IAdmin, RepoAdmin>();
builder.Services.AddScoped<ICountry,RepoCountry>();
builder.Services.AddScoped<IState, RepoState>();
builder.Services.AddScoped<ICity, RepoCity>();
builder .Services.AddScoped<IStore,RepoStore>();
builder.Services.AddScoped<ITax,RepoTax>(); 
builder.Services.AddScoped<ICategory,RepoCategory>();   
builder.Services.AddScoped<IPetType,RepoPetType>();
builder.Services.AddScoped<IPetFamily,RepoPetFamily>(); 
builder.Services.AddScoped<IOffer,RepoOffer>();
builder.Services.AddScoped<IDispatchAgency, RepoDispatchAgency>();
builder.Services.AddScoped<IPet,RepoPet>();
builder.Services.AddScoped<IPetProduct,RepoPetProduct>();
builder.Services.AddScoped<IPetFood,RepoPetFood>();
builder.Services.AddScoped<IUser,RepoUser>();
builder.Services.AddScoped<ICart,RepoCart>();
builder.Services.AddScoped<IOrders,RepoOrders>();
builder.Services.AddScoped<IDispatchOrder, RepoDispatchOrder>();
builder.Services.AddScoped<IReview, RepoStoreReview>();
builder.Services.AddScoped<IComplaints,RepoComplaints>();
builder.Services.AddScoped<ISolution,RepoSolution>();
builder.Services.AddScoped<IReturn,RepoReturn>();
builder.Services.AddScoped<IRefund,RepoRefund>();

var app = builder.Build();
app.UseStaticFiles();
app.UseSession();
app.MapControllerRoute(
           name: "areas",
           pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
         );
app.MapDefaultControllerRoute();

app.Run();
