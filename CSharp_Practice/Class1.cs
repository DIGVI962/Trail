using System;
using System.IO;

class Class1
{
    public void Main()
    {
        try
        {
            string[] dirs = Directory.GetDirectories(@"c:\", ".*", SearchOption.TopDirectoryOnly);
            Console.WriteLine("The number of directories starting with p is {0}.", dirs.Length);
            foreach (string dir in dirs)
            {
                Console.WriteLine(dir);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        }
    }
}
