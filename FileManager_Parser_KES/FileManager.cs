using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManager_Parser_KES
{
    public interface IFileManager
    {
        bool isExist(string path);
        string GetContent(string filePath);
        string GetContent(string filePath, Encoding encoding);
        int GetSymbolCount(string content);
    }
    public class FileManager : IFileManager
    {
        public Encoding _defaultEncoding = Encoding.GetEncoding(1251);
        public string GetContent(string filePath)
        {
            return GetContent(filePath, _defaultEncoding);
        }

        public string GetContent(string filePath, Encoding encoding)
        {
            string content = File.ReadAllText(filePath);
            return content;
        }

        public int GetSymbolCount(string content)
        {
            return content.Length;
        }

        public bool isExist(string path)
        {
            return File.Exists(path);
        }
    }
}
