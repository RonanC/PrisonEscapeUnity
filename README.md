# Prison Escape
###### A tower defense themed Unity game.
**by Ronan Connolly**  

![Game Menu](https://github.com/RonanC/PrisonEscapeUnity/blob/master/Misc/Menu.png "Game Menu")

Contents:
---------
1. About
2. Structure
3. Tools & Environment used
4. Installation
5. Future Features
6. References
7. Team
  
1 - About
---
The aim of this project is to create a tower defense game in Unity.

The main topics I focused on were:
* animation
* tower defense game structure
* 8 bit art
  
The project is for Damien Costello, Windows App Development, fourth year software development, GMIT.    
  
The game is an 8 Bit Unity Tower Defense Game for Windows Phone/Desktop, Android, iOS and Web.

![Prisoner](https://github.com/RonanC/PrisonEscapeUnity/blob/master/Misc/GamePlay.png "Prisoner")

I created all the art assets myself.
All authors for audio assets are listed in the references section.

The Web Service (for the score board) is located here:  
http://prisonbreakws.herokuapp.com/
  
The game is hosted here (altough the server is low power and takes some time to load):  
https://prisonescapehost.herokuapp.com/

The Windows app once accepted will be located here:  
https://www.microsoft.com/store/apps/9nblggh59xq4

![Prisoner](https://github.com/RonanC/PrisonEscapeUnity/blob/master/Misc/Prisoner.png "Prisoner")


2 - Structure 
---
###Singleton
I used a singleton pattern for a global game object that is used throughout different scenes (for the username).  
I also used the singleton pattern for the background music so that only one instance is activated at any one time.  
These two singletons never get destroyed.  

###Web Service
I created a RESTful web-service in node/express and deployed it to heroku (https://prisonbreakws.herokuapp.com/prisonEscape/scores).
This is used to store the top 10 scores.
These scores can be requested and updated.
Each new score is posted and a calculation is done, and also perhaps some sorting if you achieved a high-score.
This web service is very easy to extend to other features I may want to add.

  
3 - Tools & Environment used
---
 - Sprite Sheet Creator (https://draeton.github.io/stitches/)
 - Photoshop for created all the image assets
 - MonoDevelop for the programming
 - Unity 5.3
 - Game is hosted on Heroku (https://prisonescapehost.herokuapp.com/)
 - Web Service is hosted on Heroku (https://prisonescapehost.herokuapp.com/)
  
4 - Installation
---
###Steps
1. Download git repository folder
2. Open Unity
3. Select option in Unity to "open project"
4. Select downloaded git folder
5. The project will create local data files and get the environment ready
6. Select the main menu scene
7. Press play

###Dependencies  
- I created the project in Unity 5.3 on OSX Yosemite.
- I tested the project on Unity 5.3 on Windows 10 64 bit (works fine).


5 - Future Features
---
- More Levels
- More Guards
- More Enemies
- Better game balance
- Upgrade the background art


6 - References
---
##Tutorials
- Animation (http://www.raywenderlich.com/61532/unity-2d-tutorial-getting-started)
- Tower Defense (http://www.raywenderlich.com/107525/create-tower-defense-game-unity-part-1)
- Pixel Art 1 (http://www.raywenderlich.com/14865/introduction-to-pixel-art-for-games)
- Pixel Art 2 (http://blog.learntoprogram.tv/pixel-art-with-photoshop-part-1/)

##Audio Assets
- Pain (http://soundbible.com/1454-Pain.html)
- Sound Bible (http://soundbible.com/)
- Free SFX (http://www.freesfx.co.uk/)
- Ben Sound (http://www.bensound.com/)

7 - Team
---
This project was created by Ronan Connolly.
Software Development student in fourth year, term 1, GMIT  
for the Windows App Development module.

<a href="https://github.com/RonanC"><img src="https://github.com/RonanC/DodgySpike/blob/master/PromoImages/Ronan.png" width="100px" height="100px" title="Ronan" alt="Ronan Image"/></a> 
