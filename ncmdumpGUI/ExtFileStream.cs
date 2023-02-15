using System;
using System.IO;

namespace ncmdumpGUI
{
    public static class ExtFileStream
    {
        public static uint ReadUInt32(this FileStream fs)
        {
            byte[] raw = new byte[4];
            int ret = fs.Read(raw, 0, raw.Length);

            if (ret != raw.Length)
            {
                throw new IOException("out of stream");
            }

            return BitConverter.ToUInt32(raw, 0);
        }
    }
}
