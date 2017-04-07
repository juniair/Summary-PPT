using ImageMagick;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIFSplitConsoleApp
{


    class Program
    {

        //public static ImageInfo GetImageInfo(string path)
        //{
        //    ImageInfo info = new ImageInfo();

        //    using (System.Drawing.Image image = System.Drawing.Image.FromFile(path))
        //    {
        //        info.Height = image.Height;
        //        info.Width = image.Width;

        //        if (image.RawFormat.Equals(ImageFormat.Gif))
        //        {
        //            if (System.Drawing.ImageAnimator.CanAnimate(image))
        //            {

        //                Console.WriteLine(image.FrameDimensionsList[0]);
        //                FrameDimension frameDimension = new FrameDimension(image.FrameDimensionsList[0]);
        //                PropertyItem item = image.GetPropertyItem(0x5100);
                        
        //                foreach(byte b in item.Value)
        //                {
        //                    Console.WriteLine(b);
        //                }

        //                int frameCount = image.GetFrameCount(frameDimension);
        //                int delay = 0;
        //                int this_delay = 0;
        //                int index = 0;

        //                for (int f = 0; f < frameCount; f++)
        //                {
        //                    this_delay = BitConverter.ToInt32(item.Value, index) * 10;
        //                    delay += this_delay;  // Minimum delay is 100 ms
        //                    index += 4;
        //                }

        //                info.count = frameCount;
        //                info.AnimationLength = delay;
        //                info.IsAnimated = true;
        //                info.IsLooped = BitConverter.ToInt16(item.Value, 0) != 1;
        //            }
        //        }
        //    }

        //    return info;
        //}

        static void Main(string[] args)
        {
            System.Text.StringBuilder sb1 = new System.Text.StringBuilder();

            ImageInfo info1 = new ImageInfo(Image.FromFile("test.gif"));
            int delay = 0;


            Console.WriteLine("info : test.gif");
            for (int i = 0; i < info1.frameDelay.Length; i++)
            {
                Console.WriteLine("frame[{0}] : {1} ms", i, info1.frameDelay[i]);
                delay += info1.frameDelay[i];
            }

            sb1.AppendLine("Total Frame: " + info1.frameCount);
            sb1.AppendLine("Total Delay: " + delay + " ms");

            Console.WriteLine(sb1);


            System.Text.StringBuilder sb2 = new System.Text.StringBuilder();

            ImageInfo info2 = new ImageInfo(Image.FromFile("i14339856868.gif"));
            delay = 0;

            Console.WriteLine("info : i14339856868.gif");
            for(int i = 0; i < info2.frameDelay.Length; i++)
            {
                Console.WriteLine("frame[{0}] : {1} ms", i, info2.frameDelay[i]);
                delay += info2.frameDelay[i];
            }
            
            sb2.AppendLine("Total Frame: " + info2.frameCount);
            sb2.AppendLine("Total Delay: " + delay + " ms");
            Console.WriteLine(sb2);

            ImageInfo info3 = new ImageInfo(Image.FromFile("test.jpg"));
            delay = 0;

            Console.WriteLine("info : test.jpg");
            for (int i = 0; i < info3.frameDelay.Length; i++)
            {
                Console.WriteLine("frame[{0}] : {1} ms", i, info3.frameDelay[i]);
                delay += info3.frameDelay[i];
            }

            System.Text.StringBuilder sb3 = new System.Text.StringBuilder();
            sb3.AppendLine("Total Frame: " + info3.frameCount);
            sb3.AppendLine("Total Delay: " + delay + " ms");

            Console.WriteLine(sb3);

            Console.ReadKey();

        }

        private static ImageInfo GetImageInfo(string v)
        {
            throw new NotImplementedException();
        }
    }
}
