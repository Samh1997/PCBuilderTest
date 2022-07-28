using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PcCreator;
using PcCreator.Pages;
using PcCreator.Shared;
using PcCreator.Services;
using PcCreator.Services.PCItemService;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<IPCitemService, PCItemService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();

//List<PCItem> AllItems = new List<PCItem>();
PCItem gtx3070 = new GPU(1, "GTX 3070", 8, 16, 8, "Geforce", 3.4);
PCItem gtx3080 = new GPU(1, "GTX 3070", 10, 24, 10, "Geforce", 3.9);
PCItem gtx3090 = new GPU(1, "GTX 3070", 16, 32, 24, "Geforce", 5);
//AllItems.Add(newpcpart);


AllItems aItem = new AllItems();

aItem.pcItems.Add(gtx3070);
aItem.pcItems.Add(gtx3080);
aItem.pcItems.Add(gtx3090);









