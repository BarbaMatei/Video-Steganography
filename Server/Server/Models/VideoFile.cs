using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class VideoFile
    {
        public VideoFile()
        {

        }

        public string Path { get; set; }
        public int ByteSize { get; set; }
        public List<byte> VideoByteList { get; set; }
    }
}
