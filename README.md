softwareENGhw1
# ColorPicker
## Installation
* [Download] First step is to download the project from GitHub
* [Pick your Device] If your using an Android phone, now is the time to plug it into your computer. Be sure that developer options 
are turned on and you have your settings set up so taht you can view your devices files in your local File explorer.(You can google how to do this, it can vary for each device)
** If you are using an emulator be sure that it is pulled up on the screen somewhere.
* [APK] Find the [colorPicker.apk] in the project folder.
* [Drag and Drop] the file into your device internal storage drive(be sure it is in your main drive). If your using an emulator, you can just drag and drop 
the APK into the home screen of the emulated device. Your emulator should install the app for you at this point.
* [Go Find the File] in your device's file viewer. Click on it and accept the Install.
### ALL DONE!

## Purpose
This app is apart of my introduction to computer engineering course at Wright State University. My objective was to create a 2 part app; 
part 1 is some type of random color generator, that would create a different color at the touch of a button. Part 2 consists of 
a drawing app, that allowed a user to pick any color and draw on the screen. My app allows you to achieve both tasks and has the capacity to switch 
between the 2 utilities with the touch of a button.

## Design 
I decided to go with an andorid build over IOS due to the fact that i was able to test my builds with my own Google Pixel. 
I have some experience building apps in Andorid Studio and Unity, but my expereince with Android Studio was terrible, and i knew unity could build
cross platform if i needed to, So i decided to use the Unity Engine.
I have 2 main classes, one for each page. 
```
changeColor.cs
```
changeColor is used for the random color generator. The Large center button, when tapped, generates 3 random float values and 
creates a new color using the RGB scale of 0-255. This Color is attatched to a text within the button and updates the RGB values and prints out
its hexadecimal equivalent.
```
DrawLine.cs
```
Drawline is the main class used for the drawing application. This class uses a library in unity called linerenderer, which takes all the points
it is given and connects them with the given image. in order to succefully create multiple lines, an array was needed to create each line object.
This app is limited to its number of lines it can draw, which it's main drawback(pun intended). This class uses the RGB values given by the 
sliders in order to determine what color each line is.

## How to Use ColorPicker
After the unity splash screen, the app will load you into the random color picker. Tap the big color button at the center to change the color. you can also tap
text at the top if you want to change what it says. at the very bottom is the button to change to the drawline portion of the app.

From there you can immediatly begin to draw on the white canvas in the center. If you wish to change the color, drag the sliders and the colorblock on the top left will show you the color you have chosen.
coninue to draw or press the clear button on the top right to reset your canvas. Again, at the very bottom is the button to change back to the random color generator.
