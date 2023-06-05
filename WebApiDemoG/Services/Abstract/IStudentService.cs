using WebApiDemoG.Entities;
using WebApiDemoG.Services.Asbtract;

namespace WebApiDemoG.Services.Abstract
{
    public interface IStudentService:IService<Student>
    {
         bool StudentExists(string username, string password);
    }
}
