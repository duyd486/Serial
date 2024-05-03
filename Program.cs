internal class Program
{
    private static void Main(string[] args)
    {
        string name = "Nguyen";
        StoreString(name);
        Console.WriteLine(ReadString);
    }
    static void StoreString(string linkvalue) {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/" + "Link.txt";
        FileStream fs = new FileStream(path, FileMode.Create);
        StreamWriter streamWriter= new StreamWriter(fs, System.Text.Encoding.UTF8);
        streamWriter.Write(linkvalue);
        streamWriter.Flush();
        fs.Close();

    }
    static String ReadString() {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/" + "Link.txt";
        FileStream fs = new FileStream(path, FileMode.Open);
        StreamReader sr = new StreamReader(fs, System.Text.Encoding.UTF8);
        string giatri = sr.ReadToEnd();
        sr.Close();
        return giatri;
    }
}