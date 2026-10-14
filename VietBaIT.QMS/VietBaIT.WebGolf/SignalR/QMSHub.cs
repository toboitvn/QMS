using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace VietBaIT.WebGolf.SignalR
{
    public class QMSHub : Hub
    {
        public async Task SendDanhSachChoKham(object data)
        {
            await Clients.All.SendAsync("ReceiveDanhSachChoKham", data);
        }
    }
}
