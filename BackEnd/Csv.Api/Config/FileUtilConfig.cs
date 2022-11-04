using Csv.Api.Utils;

namespace Csv.Api.Config
{
    public class FileUtilConfig
    {

        public static FileUtil InstanceFileUtil()
        {
            return new FileUtil();
        }

    }
}