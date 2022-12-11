// See https://aka.ms/new-console-template for more information
//This is not an web API. It is a console application for developing the Video-Steganography algorithm.
//It will be later migrated to Web
using Server.Services;

string path = @"D:\Research Project\Application\Server\Server\Files\AVI File.avi";
var videoReadingService = new VideoReadingService(path);
var videoFile = videoReadingService.ReadVideoFile();

Console.WriteLine(string.Format("Video Path: {0}", videoFile.Path));
Console.WriteLine(string.Format("Video Byte Size: {0}", videoFile.ByteSize));

foreach(var videoByte in videoFile.VideoByteList)
{
    string binaryCode = Convert.ToString(videoByte, 2);
    binaryCode = new string('0', 8 - binaryCode.Length) + binaryCode ;
    Console.Write(binaryCode + " ");
    Thread.Sleep(500);
}
