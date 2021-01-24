# BadgerHacks 2021: Battle Hamsters

## Read about the project here: https://devpost.com/software/battle-hamsters

## Demo video: https://www.youtube.com/watch?v=vrfyQ8oMwuw

## Installation:
1. Download or clone the Git project
2. Run BattleHamsters.exe (Windows) or BattleHamsters.app (MacOS)

## Group Members:
- Cameron P.
- Joey L.
- Sam J.
- Patrick P.

## Inspiration:
I had a hamster when I was in elementary school. I loved him very much, but he died before he could live his dream of being in space. Today, I help his likeness fulfill that dream.

## What it does:
The objective of Battle Hamsters is to collect as many points as possible in 90 seconds. Players gain points by collecting pellets of food scattered throughout the map. The game has both single-player and multiplayer (local split screen) game modes, allowing two people to compete against each other in the same level. The game can be played using a keyboard (WASD or arrow keys) and/or an Xbox controller.

## How we built it:

### Game:
We created Battle Hamsters using the Unity game engine. Behind the scenes, the game logic and physics is implemented in C#. 

### Sprites: 
We used GIMP and Pixelmator to create most of the sprites. The background was modified from [Dynamic Space Background Lite](https://dinvstudio.itch.io/dynamic-space-background-lite-free) which is freely available online.

### Music: 
Logic Pro X to create the music and sound effects. Joey L. composed the music used for the game and menu screen.

### Tools:
In order to collaborate remotely, our group used GitHub for version control and Discord to communicate.

### Development Process:
- January 21: On Thursday, we created the project and setup the GitHub repository. Some basic work was done on creating movement and physics for our hamsters. Some basic environmental sprites were created for the level, as well as the main menu's design.
- January 22: On Friday, the sprites for our hamsters, environment, and parallax background were finished. We experimented with different level designs and obstacles, and introduced the idea of keeping track of how much time a player has spent in a level. Initial work was done on split-screen multiplayer. Input via Xbox controllers was also implemented. Finally, the main menu and settings menus were finalized.
- January 23: On Saturday, we finished two songs for the game - a Main Menu theme and a Level theme. We liked the idea of collecting pellets to increase a score, and re-worked the core gameplay to give players only 90 seconds to play a level. The finalized idea for our game was to grant players a limited amount of time to achieve the highest score possible. This gameplay loop lends itself well to split-screen multiplayer, which we finalized and play-tested. Code related to input had to be reworked for multiplayer, allowing one user to play on keyboard via WASD, and another player to use an Xbox controller. Finally, a quasi-"Game Over" screen was added after time runs out, telling players their final scores and allowing them to return to the main menu. We also made improvements to the level design and player jump physics used in the game.

## Challenges we ran into:
Most of our group was either new or very inexperienced with Unity. We relied heavily on Unity's documentation as well as tutorials we found online. We also faced challenges with properly merging Unity project file changes using Git. This was eventually resolved by reorganizing our Unity project.

## Accomplishments that we're proud of:

- Cameron: I'm proud of the background parallax effect and improvements made to the player jump physics.
- Joey: I'm proud of how polished the overall gameplay and presentation of our project is. We did a good job allocating time for creating decent artwork, menus, and sounds. I'm also proud of the music I made for the game.
- Patrick: Designing the game sprites and collaborating on a hackathon project.
- Sam: I'm proud of cleaning up the menu system and having a fairly cohesive project overall.

## What we learned:
We learned a lot about how to use Unity for game development and how to properly structure projects in Unity. For Patrick, it was his first hackathon and first time working on a group programming project.

## What's next for Battle Hamsters:
Although we completed a lot in the three days of BadgerHacks 2021, there are still a number of features we'd like to add. Here's our list!

- More levels and complex map design
- LAN multiplayer
- Configurable time limit
- Customizable hamster and hamster ball
- Improved game physics, especially related to player movement
- Other game modes (Timed two player race, CTF, King of the Hill)
- Obstacles and hazards added to the map
- Port the Unity project to other platforms such as mobile and web
- Controls customization in settings

## Credits:
Game background: [Dynamic Space Background Lite](https://dinvstudio.itch.io/dynamic-space-background-lite-free)
