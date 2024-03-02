namespace melogen
{
    internal class Utils
    {
        public static bool pathExists(string type, string path)
        {
            if ((type.Equals("dir")) && (path != null))
                return Directory.Exists(path);
            if ((type.Equals("file")) && (path != null))
                return File.Exists(path);

            return false;
        }

        public static void writeFile(string filename, List<string> content)
        {
            if (!File.Exists(filename))
                File.Create(filename).Close();
            
            var fileStream = new FileStream(filename, FileMode.Open);
            var stream = new StreamWriter(fileStream);

            foreach (string line in content)
                stream.WriteLine(line);

            stream.Close();
            fileStream.Close();
        }
    }
}
