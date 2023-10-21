using CommonModel;
namespace API.MIddleware
{
    public interface IHelperHttpContext
    {
         InfoRequest GetInfoRequest(HttpContext request);
    }
}
