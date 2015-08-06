using System;
using System.Drawing;

namespace FacePixeler
{
    public static class ImageProcessor
    {
        public static Bitmap Pixelate(Bitmap image, int blurSize)
        {
            return ImageProcessor.Pixelate(image, new Rectangle(0, 0, image.Width, image.Height), blurSize);
        }

        public static Bitmap Pixelate(Bitmap image, Rectangle rectangle, int pixelateSize)
        {
            Bitmap bitmap = new Bitmap(image.Width, image.Height);
            using (Graphics graphics = Graphics.FromImage((Image) bitmap))
                graphics.DrawImage((Image) image, new Rectangle(0, 0, image.Width, image.Height), new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
            int x1 = rectangle.X;
            while (x1 < rectangle.X + rectangle.Width && x1 < image.Width)
            {
                int y1 = rectangle.Y;
                while (y1 < rectangle.Y + rectangle.Height && y1 < image.Height)
                {
                    int num1 = pixelateSize / 2;
                    int num2 = pixelateSize / 2;
                    while (x1 + num1 >= image.Width)
                        --num1;
                    while (y1 + num2 >= image.Height)
                        --num2;
                    Color pixel = bitmap.GetPixel(x1 + num1, y1 + num2);
                    for (int x2 = x1; x2 < x1 + pixelateSize && x2 < image.Width; ++x2)
                    {
                        for (int y2 = y1; y2 < y1 + pixelateSize && y2 < image.Height; ++y2)
                            bitmap.SetPixel(x2, y2, pixel);
                    }
                    y1 += pixelateSize;
                }
                x1 += pixelateSize;
            }
            return bitmap;
        }

        public static Bitmap Blur(Bitmap image, int blurSize)
        {
            return ImageProcessor.Blur(image, new Rectangle(0, 0, image.Width, image.Height), blurSize);
        }

        public static Bitmap Blur(Bitmap image, Rectangle rectangle, int blurSize)
        {
            Bitmap blurred = new Bitmap(image.Width, image.Height);

            // make an exact copy of the bitmap provided
            using (Graphics graphics = Graphics.FromImage(blurred))
                graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height),
                    new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);

            // look at every pixel in the blur rectangle
            for (Int32 xx = rectangle.X; xx < rectangle.X + rectangle.Width; xx++)
            {
                for (Int32 yy = rectangle.Y; yy < rectangle.Y + rectangle.Height; yy++)
                {
                    Int32 avgR = 0, avgG = 0, avgB = 0;
                    Int32 blurPixelCount = 0;

                    // average the color of the red, green and blue for each pixel in the
                    // blur size while making sure you don't go outside the image bounds
                    for (Int32 x = xx; (x < xx + blurSize && x < image.Width); x++)
                    {
                        for (Int32 y = yy; (y < yy + blurSize && y < image.Height); y++)
                        {
                            Color pixel = blurred.GetPixel(x, y);

                            avgR += pixel.R;
                            avgG += pixel.G;
                            avgB += pixel.B;

                            blurPixelCount++;
                        }
                    }

                    avgR = avgR / blurPixelCount;
                    avgG = avgG / blurPixelCount;
                    avgB = avgB / blurPixelCount;

                    // now that we know the average for the blur size, set each pixel to that color
                    for (Int32 x = xx; x < xx + blurSize && x < image.Width && x < rectangle.Width; x++)
                        for (Int32 y = yy; y < yy + blurSize && y < image.Height && y < rectangle.Height; y++)
                            blurred.SetPixel(x, y, Color.FromArgb(avgR, avgG, avgB));
                }
            }

            return blurred;
        }

    }
}
