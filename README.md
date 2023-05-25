# CS-Text-RPG-2021
A simple, unfinished text-based RPG. One of the first programs I've ever written while learning how to code C# in 2021.
You'll need .NET to actually play the game, if you have it then it should work by just running the run.bat file.

I initially used this program as a sort of sandbox to play around with while learning C# (my first coding language). 
It is pretty unmodular and relies too heavily on if-else statements, but I'm still pretty proud of it as my first go at really trying to make a large-scale functioning program.
Working on it made me come up with clever solutions to problems (even if almost all of those solutions are sub-optimal ones) and gave me a chance to explore tools I had never used prior such as functions and classes.
I used very little outside help for the design of the program, so pretty much every solution or method used to make it work were ones that I came to on my own, for better or for worse.

Despite being unfinished, the game is entirely playable.
I finished pretty much all of the mechanics and systems I wanted for the game, everything that it needs to work and to be expanded upon.
I just became disinterested with the project once I finished all of what I considered the 'interesting stuff', being those mechanics and systems.
This means that the 'unfinished' part is pretty much all of the actual content of the game, such as more enemies, areas, encounter types, gear, and items.
It wouldn't be very hard or time consuming to add those things, as my program does still have a decent amount of modularity thanks to classes and functions, 
but I don't have any interest in doing so as I'm currently working on an improved take on this style of text RPG in Python as of writing this.

As for how the game actually plays:
It's controlled entirely by entering responses to prompts where you use command words to decide what to do or what actions to take.
The main gameplay revolves around the 'Explore' command, where you encounter a random enemy or scenario where you then choose what to do from there.
By defeating enemies while exploring, you gain XP and gold that you can use to increase your stats and purchase better equipment and items that will make you more effective in future encounters.
The game was intended to have many different 'areas' you could travel to which would have their own different pools of enemies and scenarios you could encounter when you explore in them,
however because I didn't do much work on it beyond the base mechanics and systems, there's only 2 areas to the game, the base starting one and a slightly higher level one that's guarded by a boss encounter you must defeat to access it.
The game does feature a save/load system that took me a very long time to develop, even though the way it works is about as simplistic as you can get.
When you use the 'save' command it just prints out a number string where each digit contains information on all the various stats of your save, that you must copy and save somewhere else to then be pasted back in when you use the 'load' command.

The last revision to it was made on August 25th, 2021.
