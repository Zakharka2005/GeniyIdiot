namespace GeniyIdiotClassLibrary
{
    public class FileProvider()
    {
        public static void Append(string path, string value, string fileName)
        {
            StreamWriter writer = new StreamWriter($"{path}/{fileName}", true, System.Text.Encoding.Default);
            writer.WriteLine(value);
            writer.Close();
        }
        public static void Replace(string path, string value, string fileName)
        {
            StreamWriter writer = new StreamWriter($"{path}/{fileName}", false, System.Text.Encoding.Default);
            writer.WriteLine(value);
            writer.Close();
        }

        public static string Get(string path, string fileName)
        {
            StreamReader record = new StreamReader($"{path}/{fileName}");
            string value = record.ReadToEnd();
            record.Close();
            return value;
        }
        public static bool Exists(string path, string fileName)
        {
            return File.Exists($"{path}/{fileName}");
        }

        public static void Delete(string path, string fileName)
        {
            File.Delete($"{path}/{fileName}");
        }
        public static void CreateDirectory(string path)
        {
            DirectoryInfo dirInfo = new DirectoryInfo($@"{path}");
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
        }
    }
}

