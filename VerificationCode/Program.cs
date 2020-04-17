using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace VerificationCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\实践\一起帮作业+提交github\LuckStack\VerificationCode\obj\Debug";
            int width = 300;
            int height = 150;
            Bitmap image = new Bitmap(width,height);
            Graphics s = Graphics.FromImage(image);
            Random random = new Random();
            Color colorrandom = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            s.Clear(Color.White);
            s.DrawString(RandomString(), new Font("宋体", random.Next(50,70)),
                new SolidBrush(colorrandom), 
                new Point(random.Next(25,75),
                random.Next(15,35)));
            Random XPoint = new Random(new Random().Next(50));
            Random YPoint = new Random(new Random().Next(23));
            for (int j = 0; j < random.Next(5,10); j++)
            {
                s.DrawLine(new  Pen(new SolidBrush(Color.FromArgb(random.Next(255),
                    random.Next(255), random.Next(255)))), 
                    new Point(XPoint.Next(width), YPoint.Next(height)), new Point(XPoint.Next(width), YPoint.Next(height))) ;
            }
         
            for (int k = 0; k < random.Next(30,50); k++)
            {
                Color Pixelcolorrandom=new Color();
                for (int i = 0; i < k; i++)
                {
                    Pixelcolorrandom = Color.FromArgb(random.Next(new Random().Next(255)),
                        random.Next(new Random().Next(255)), random.Next(new Random().Next(255)));
                }
                image.SetPixel(XPoint.Next(width), YPoint.Next(height),
                    Pixelcolorrandom);
            }
                image.Save(path + "验证码.JPG", ImageFormat.Jpeg);
        }
        static string RandomString()
        {
            int stringlength = new Random().Next(4, 6);
            string WhiteList = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ ";
            Random random = new Random();
            string stringrandom=null;
            for (int i = 0; i < stringlength; i++)
            {
                int intrandom = random.Next(WhiteList.Length);
                char charrandom = WhiteList[intrandom];
                stringrandom +=charrandom;
            }
            return stringrandom;
        }
    }
}
