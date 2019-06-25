using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateFilesTest1
{
    public static class FilesRespository
    {
        public static TemplateFile[] GetFiles()
        {
            return new TemplateFile[] {
                new TemplateFile() { FileName = "file1.cs", FileContent = "contaent111" },
                new TemplateFile() { FileName = "file2.cs", FileContent = "content222" }
            };
        }
    }
}
