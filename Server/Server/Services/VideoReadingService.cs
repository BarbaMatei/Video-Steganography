using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Services
{
    public class VideoReadingService
    {
        private readonly string _videoPath;

        public VideoReadingService(string videoPath)
        {
            _videoPath = videoPath;
        }

        public VideoFile ReadVideoFile()
        {
            var videoFile = new VideoFile();
            using (FileStream fileStream = File.OpenRead(_videoPath))
            {
                byte[] videoByteList = new byte[fileStream.Length];
                fileStream.Read(videoByteList, 0, videoByteList.Length);

                videoFile.Path = _videoPath;
                videoFile.VideoByteList = new List<byte>();
                foreach(byte videoByte in videoByteList)
                {
                    videoFile.VideoByteList.Add(videoByte);
                }
                videoFile.ByteSize = videoFile.VideoByteList.Count;
            }
            return videoFile;
        }
    }
}
