using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Helpers
{
    public static class Helper
    {
        
        public enum Roles
        {
            SuperAdmin,
            Admin,
            Member
        }
        public static bool CheckContent(string contenttype, string format)
        {
            if (contenttype.Contains(format))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async static Task<string> SaveImg(this IFormFile file, string root, string folder)
        {
            string path = Path.Combine(root, folder);
            string fileName = Guid.NewGuid().ToString() + file.FileName;
            string resultPath = Path.Combine(path, fileName);
            using (FileStream fileStream = new FileStream(resultPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return fileName;
        }
        public async static void SaveImg(string filename,string env,string folder,IFormFile file)
        {
            string path = Path.Combine(env, folder,filename);
            string fileName = Guid.NewGuid().ToString() + file.FileName;
            string resultPath = Path.Combine(path, fileName);
            using (FileStream fileStream = new FileStream(resultPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            
        }

    }
}
