

//------------------- Tammrin 1.a & 1.b -------------------
string sourcePath = Directory.GetCurrentDirectory() + "\\Test.txt";
string destPath = Directory.GetCurrentDirectory() + "\\Archive\\Test_Copy.txt";
bool hasException = false;

try
{
    File.Copy(sourcePath, destPath);
}
catch (Exception ex)
{
    hasException = true;
    Console.WriteLine(ex.Message);
}

if (!hasException)
{
    Console.WriteLine("There was no exception. The file copied successfully");
}