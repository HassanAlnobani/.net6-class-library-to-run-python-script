

namespace StringLibrary;
public class Class1
{
    public string Run(string cmd, string args)
    {
        System.Diagnostics.ProcessStartInfo start = new System.Diagnostics.ProcessStartInfo();
        start.FileName = "python";
        start.Arguments = string.Format("\"{0}\" \"{1}\"", cmd, args);
        start.UseShellExecute = false;
        start.CreateNoWindow = true; 
        start.RedirectStandardOutput = true;
        start.RedirectStandardError = true; 
        using (System.Diagnostics.Process process = System.Diagnostics.Process.Start(start))
        {
            using (StreamReader reader = process.StandardOutput)
            {
                string stderr = process.StandardError.ReadToEnd(); 
                string result = reader.ReadToEnd(); 
                return result;
            }
        }
    }

          public static void Main(string[] args)
            {
                var res = new Class1().Run("Face Mask Detection.ipynb","params");
                    Console.WriteLine(res);
            }

}

