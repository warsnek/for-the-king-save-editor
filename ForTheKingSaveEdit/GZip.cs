using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ForTheKingSaveEdit
{
  public class GZip
  {
    [DllImport("libzipw")]
    internal static extern int zipUnGzip(IntPtr source, int sourceLen, IntPtr outBuffer, int outLen, bool hasHeader, bool hasFooter);

    [DllImport("libzipw")]
    internal static extern int zipGzip(IntPtr source, int sourceLen, IntPtr outBuffer, int levelOfCompression, bool addHeader, bool addFooter);

    public static int gzipUncompressedSize(byte[] source)
    {
      int num = source.Length;
      return (source[num - 4] & 0xFF) | ((source[num - 3] & 0xFF) << 8) | ((source[num - 2] & 0xFF) << 16) | ((source[num - 1] & 0xFF) << 24);
    }

    private static int UnGzip(byte[] source, byte[] outBuffer, bool hasHeader = true, bool hasFooter = true)
    {
      GCHandle sourceHandle = GCHandle.Alloc(source, GCHandleType.Pinned);
      GCHandle outBufferHandle = GCHandle.Alloc(outBuffer, GCHandleType.Pinned);
      int result = zipUnGzip(sourceHandle.AddrOfPinnedObject(), source.Length, outBufferHandle.AddrOfPinnedObject(), outBuffer.Length, hasHeader, hasFooter);
      sourceHandle.Free();
      outBufferHandle.Free();
      return result;
    }

    private static int Gzip(byte[] source, byte[] outBuffer, int level, bool addHeader = true, bool addFooter = true)
    {
      GCHandle gCHandle = GCHandle.Alloc(source, GCHandleType.Pinned);
      GCHandle gCHandle2 = GCHandle.Alloc(outBuffer, GCHandleType.Pinned);
      int num = zipGzip(gCHandle.AddrOfPinnedObject(), source.Length, gCHandle2.AddrOfPinnedObject(), level, addHeader, addFooter);
      gCHandle.Free();
      gCHandle2.Free();
      int num2 = 0;
      if(addHeader)
      {
        num2 += 10;
      }
      if (addFooter)
      {
        num2 += 8;
      }
      return num + num2;
    }

    public static string Decompress(byte[] data)
    {
      byte[] array = new byte[gzipUncompressedSize(data)];
      var gzres = UnGzip(data, array);
      if (gzres > 0)
      {
        return Encoding.Unicode.GetString(array);
      }
      return string.Empty;
    }

    public static byte[] Compress(string value)
    {
      byte[] bytes = Encoding.Unicode.GetBytes(value);
      byte[] buffer = new byte[bytes.Length + 18];
      int num = Gzip(bytes, buffer, 1);
      if (num > 0)
      {
        byte[] array2 = new byte[num];
        Buffer.BlockCopy(buffer, 0, array2, 0, num);
        return array2;
      }
      return null;
    }
  }
}
