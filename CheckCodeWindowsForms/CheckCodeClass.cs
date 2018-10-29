using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckCodeWindowsForms
{
    class CheckCodeClass
    {
        string checkCode;
        public string CheckCode
        {
            get
            {
                return checkCode;
            }
            set
            {
                checkCode = value;
            }

        }
        private string CreateRandomCode(int n)
        {
            string allChar = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            string[] allCharArray = allChar.Split(',');
            string randomCode = "";
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                int t = rand.Next(35);
                randomCode += allCharArray[t];
            }
            return randomCode;
        }

        private Image CreateImage(string checkCode)
        {
            int iwidth = (int)(checkCode.Length * 20);
            using (Bitmap image = new Bitmap(iwidth, 40))
            {
                Graphics g = Graphics.FromImage(image);
                Font f = new Font("Arial", 18, FontStyle.Regular);
                Brush b = new SolidBrush(Color.Red);
                g.Clear(Color.Beige);
                DrawRandomLine(g, image);
                //DrawRandomLine(g, image);
                g.DrawString(checkCode, f, b, 1, 4);
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                    Image img = Image.FromStream(ms);

                    //img.Dispose();
                    return img;
                }
                
              
            }
            //g.Dispose();
            //image.Dispose();
        }

        private void DrawRandomLine(Graphics gfc, Bitmap img)
        {
            Random rand = new Random();
            Pen blackPen = new Pen(Color.Red, 1);
            for (int i = 0; i < 10; i++)
            {
                int y = rand.Next(img.Height);
                int y1 = rand.Next(img.Height);
                gfc.DrawLine(blackPen, 0, y, img.Width, y - y1);
            }
        }

        //public string CheckCode()
        //{
        //    string checkCode = CreateRandomCode(4);
        //    return checkCode;
        //}
        public Image CheckCodeImage()
        {
            string check = CreateRandomCode(4);
            CheckCodeClass checkCodeClass = this;
            checkCodeClass.CheckCode = check;
            //Session["CheckCode"] = checkCode;
            Image img = CreateImage(check);
            return img;
        }
    }
}
