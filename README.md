# TheTower
ASP.NET MVC website for gaming with DnD


# About the Project
## Purpose
This project was created during the Covid lockdown to help my friends and I keep busy with games of Dungeons and Dragons.  
We ended playing playing alot games of to keep occupied, but our problem was we didn't have time to create new content every day (there's alot of prep time!).
So, I decided to create an app that would help generate random fights for us to play.
This also helped us to test out some different characters and classes. 

## Story
The role playing really depends on the DM here, we havent done too much of a story.
The idea is, the characters start at the bottom of a, what seems like, neverending tower. 
They enter an elevator and jump to a random floor in the tower.
Each room has a different biome and an event happens each time you enter (depending on the event).
Each room also features a randomly generated Monster.  

## How it Works
To Win, the characters must reach level 20 (top) of the tower and defeat the Final Boss Monster.  
If the characters reach level -20 (bottom), they have to face a ridiculously difficult Monster. (We have been using Pit Fiend)

Everything that is randomly generated in the tower includes:
* Levels - The party must roll a D12 to determine which direction and number of the floors the elevator will travel. 
* Biomes - The party must roll a D12 to determine which type of biome the level will contain. 
* Events - The party must roll a D8 to determine the event that happens before/when they enter the room.
* Monster CR (Challenge Rating) - D20 to determine the Challenge rating of the Monster(s).
* Monster - The Party must roll D4(s) depending on how many Monsters the DM wants for the give level. 

We used one map for all fights. Dungeons & Dragons Tactical Maps Reincarnated (D&D Accessory)

## Use

You must create a list of monsters that you will be using. 
I used 4 Monsters for every CR level and about 7/8 CR Levels.


# Setup
Migrate the DB from the classes. This should create the Database and seed some data into it. (Biomes, Level-Rolls and Events)  



# Technologies 
### Front End 
The base language used for design is HTML and CSS.
I used Bootstrap to organise the layout of the page and contents.
There is also some javascript and jQuery used for functionality on the front end.

### Back End
The back end is written in a C# ASP.NET MVC Application. I have just been running it on my localhost to play but could be set up on IIS for all players to access if needed. 
Data is saved in a SQL Database running on the local machine. (Can be migrated from the classes)



