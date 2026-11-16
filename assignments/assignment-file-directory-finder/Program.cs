namespace AssignmentFIleDirectoryFInder;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("IMAGE SEARCH APPLICATION");
        
        
        //Get all avaailable drives

        DriveInfo[] drives = DriveInfo.GetDrives();

        foreach (DriveInfo drive in drives)
        {
            try
            {
                if (drive.IsReady)
                {
                    Console.WriteLine("\nSearching Drive" + drive.Name);

                    DirectoryInfo directory = new DirectoryInfo(drive.Name);

                    SearchImages(directory);

                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Connot access drives: "+ex.Message);
            }
        }
        
        Console.WriteLine("\nSearch completed!");
    }
    
    
    //Recursive Methods to Search Directories

    public static void SearchImages(DirectoryInfo directory)
    {
        try
        {
            //Get all files in the current directory
            FileInfo[] files = directory.GetFiles();

            foreach (FileInfo file in files)
            {
                string extension = file.Extension;

                if (extension.Equals(".jpg",
                        StringComparison.OrdinalIgnoreCase) ||

                    extension.Equals(".jpeg",
                        StringComparison.OrdinalIgnoreCase) ||

                    extension.Equals(".png",
                        StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(file.FullName);
                }
            }
        }
        catch (UnauthorizedAccessException)
        {
            //Skip folder without permission
        }
        catch (IOException ex)
        {
            // Skip folders that cannot be accessed
        }

        try
        {
            //Get all Subdirectories

            DirectoryInfo[] subDirectories = directory.GetDirectories();
            
            foreach (DirectoryInfo subDirectory in subDirectories)
            {
                // Avoid symbolic links and directory loops
                if ((subDirectory.Attributes &
                     FileAttributes.ReparsePoint) != 0)
                {
                    continue;
                }

                // Recursive call
                SearchImages(subDirectory);
            }
            
        }
        catch (UnauthorizedAccessException)
        {
            // Skip restricted directories
        }
        catch (IOException)
        {
            // Skip inaccessible directories
        }
    }
}