using System.Collections.Generic;

namespace SixCC.Sdk.Commons
{
    public class CompressWriter
    {
        public byte[] Compress(byte[] bytes)
        {
            var writer = new BinWriter();

            writer.Write(bytes.Length);

            var zero = true;
            var zeroCount = 0;
            var nonZero= new List<byte>();

            foreach (var value in bytes)
            {
                if (zero)
                {
                    if (value == 0)
                    {
                        zeroCount += 1;
                    }
                    else
                    {
                        writer.Write(zeroCount);
                        zeroCount = 0;
                        zero = false;
                        nonZero.Add(value);
                    }
                }
                else
                {
                    if (value != 0)
                    {
                        nonZero.Add(value);
                    }
                    else
                    {
                        writer.Write(nonZero.Count);
                        foreach (var nz in nonZero)
                        {
                            writer.WriteByte(nz);
                        }
                        nonZero.Clear();
                        zero = true;
                        zeroCount = 1;
                    }
                }
            }
            if (zero)
            {
                writer.Write(zeroCount);
            }
            else
            {
                writer.Write(nonZero.Count);
                foreach (var nz in nonZero)
                {
                    writer.Write(nz);
                }
            }

            return writer.ToArray();
        }
    }
}
