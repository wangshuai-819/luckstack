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
            Bitmap image = new Bitmap(300,100);
            Graphics s = Graphics.FromImage(image);
            //Color RandomColor = new Color() {Name=new Random()};
            s.Clear(Color.White);
            Random random = new Random();
            string  WhiteList =   "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ " ;

            image.Save(path+"验证码.JPG",ImageFormat.Jpeg);
        }
    }
}
