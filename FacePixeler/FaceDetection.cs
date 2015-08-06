using Emgu.CV;
using Emgu.CV.Structure;
using System.Collections.Generic;
using System.Drawing;

namespace FacePixeler
{
    internal class FaceDetection
    {
        public static List<Rectangle> Detect(Image<Bgr, byte> image, string faceFileName)
        {
            List<Rectangle> list = new List<Rectangle>();
            using (CascadeClassifier cascadeClassifier = new CascadeClassifier(faceFileName))
            {
                using (Image<Gray, byte> image1 = image.Convert<Gray, byte>())
                {
                    image1._EqualizeHist();
                    Rectangle[] rectangleArray = cascadeClassifier.DetectMultiScale(image1, 1.1, 10, new Size(20, 20), Size.Empty);
                    list.AddRange((IEnumerable<Rectangle>) rectangleArray);
                }
            }
            return list;
        }
    }
}