class Program
{
    static void Main(string[] args)
    {
        //Get File name from user
        Console.WriteLine("Enter file Path:");
        string inputFile = Console.ReadLine();
        //Returns count of words ending with t or e
        int wordCount = endsWithCount(fileToList(inputFile));
        Console.WriteLine("There are " + wordCount.ToString() + " words that end in t or e.");
    }

    //This method will create a list with the lines of the file.
    //Used list instead of array as File lines may differ
    static List<string> fileToList(string inputFile)
    {
        List<string> fileLinesList = new List<string>();
        StreamReader streamReader = File.OpenText(inputFile);
        //Loops until end of file
        while( !streamReader.EndOfStream )
        {
            //Adds each line in file to the list at index
            fileLinesList.Add(streamReader.ReadLine());
        }
        streamReader.Close();
        return fileLinesList;
    }
    //This method will go through the list of lines and split then into words.
    //It will then count the words that end with e or t and return that count
    static int endsWithCount(List<string> lineList)
    {
        int count = 0;
        foreach(string line in lineList)
        {
            //Splits lines into wordss
            string[] words = line.Split(' ');
            foreach(string word in words)
            {
                if( word.EndsWith('e') || word.EndsWith('t') || word.EndsWith("E") || word.EndsWith("T"))
                {
                    count++;
                }
            }
        }
        return count;
    }


}

