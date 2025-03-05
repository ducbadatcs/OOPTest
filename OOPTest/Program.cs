using Microsoft.VisualBasic;

namespace OOPTest
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int[] A = new int[] {2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            int[] B = new int[] { A[1], A[4], A[5], A[2] };
            
            FileSystem fileSystem = new FileSystem();

            string id = "105541452";
            // add b[0] files
            for (int i = 0; i < B[0]; i++)
            {
                fileSystem.AddThing(new File($"{id}-{i}", "txt"));
            }

            // make a folder with B[1] files, then add it
            Folder folder = new Folder("Folder1");
            for (int i = B[0]; i < B[0] + B[1]; i++)
            {
                folder.Add(new File($"{id}-{i}", "txt"));
            }
            fileSystem.AddThing(folder);

            // add a folder with a folder with B[2] files
            folder = new Folder("Folder");
            Folder subfolder = new Folder("Subfolder");
            for (int i = B[0] + B[1]; i < B[0] + B[1] + B[2]; i++)
            {
                subfolder.Add(new File($"{id}-{i}", "txt"));
            }
            folder.Add(subfolder);
            fileSystem.AddThing(folder);

            // add B[3] folders
            for (int i = B[0] + B[1] + B[2]; i < B[0] + B[1] + B[2] + B[3]; i++)
            {
                fileSystem.AddThing(new Folder($"{id}-{i}"));
            }
            fileSystem.PrintContents();
        }
    }
}
