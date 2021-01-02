FacePixeler
===========

A simple tool written in C# that can take a batch of images, scan them for faces, and then pixelate out the faces. Powered by [OpenCV](http://www.opencv.org) and [EmguCV](http://www.emgu.com)!

## License

This code is licensed under [LGPL v3](https://www.gnu.org/licenses/lgpl.html).

EmguCV is licensed under [GPL v3](https://www.gnu.org/licenses/gpl.html). A commercial version is available.

Also includes code licensed under the Intel OpenCV License Agreement. Check the ["IntelLicenseAgreement.txt" file](FacePixeler/IntelLicenseAgreement.txt) in this repository.

## How to build this program

After you clone this repository on your computer, there's one more step you have to take: this code is missing the EmguCV files needed to run the program. The files were too big to fit into this repository, so here's what to do.

1. Download the .zip file [from my OneDrive](https://1drv.ms/u/s!AnYp1YFqE6kPgYNpMe9oBZl8f1QfhA?e=xl1bEa).
2. Extract the EmguCV folder somewhere (such as your desktop). This folder contains all of the EmguCV DLLs.
3. Go into the [FacePixeler project folder](FacePixeler) (the one that has the .csproj file and all the code files, not the other one) and move the EmguCV folder there.
   - Your end result should look something like [this image](http://imgur.com/keyVDk6).

*Now you're ready to go!* Open the solution up in Visual Studio and get going!

**Do note** that when you first compile the code for either x64 or x86, it'll take Visual Studio a bit of a while because a build event is running that will copy the EmguCV DLLs to their proper place in the output directory. Once Visual Studio does this once, it shouldn't have to happen again!

## How to use the compiled program - a 4-step guide

1. Click on "Add Images" and select the images you wish for it to process.
2. Type a path to an output folder in the "Set Output Directory" box, *or* click the "Browse" button to find one.
3. Type or select a strength (the higher the number, the more pixel-y an image gets)
4. Press the "Start" button!
   - For the Pixelate effect, it'll go through each image pretty quickly.
   - It'll mark a checkbox next to each image as it finishes it.

## Other things to note

1. The "Blur" effect isn't quite working. At best, it blurs a portion of a face. At worst, it does nothing. Don't really know why; don't really know what I'll do about it. I marked it as "broken" in the UI. Either way, it runs pretty slow, and the higher the strength, the slower it gets too.
2. You can't cancel the image-blurring/pixelating process once you start it. Unless you're using the "Blur" option though, it should go by pretty fast. Keep monitoring those check-boxes to see how far its progressed.
3. As it goes along, it will tell you how many faces it found in each image; it will pixelate each face it finds. This process is not perfect. For the best results, the face should be looking towards the camera, and with a neutral expression. I offer no warranties on it picking up faces accurately. If you're really concerned about privacy, you'll have better luck with other tools.

## About me

I am Jacob R. Huempfner. I am a C#, Visual Basic, and Java developer, and I'm continuing to learn more and more! You can find me on Twitter as [@JaykeBird](http://twitter.com/JaykeBird).
