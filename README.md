# Zelda_V2

CSE 3902 : Group4

Authors: Barry Birschbach, Terryl Rumph, Logan Sauer, Isabel Smith, Longfei Yu

User manual:

Arrow Keys/WASD - move link;
Q - Quit;
R - Reset Game;
X/N - Attack;
Z - Use Item;
Enter - Pause Game;
C - cycle through item selector when paused;
Other controls are written in in-game prompts.
Controls can be changed in Preferences, and Instructions page gives a detailed description of functionality.


Known Bugs/Issues:

Controls:  
Volume up, down and mute does not work and crashes the game. Reset command has unexpected behavior.

Items:
Boomerang cannot be used more than once. Link shoots a sword even with full health. Sword shoots from incorrect place when link is in damaged state. 

Constant Classes:  

Sprite Classes:  
Currently there are two possible methods of displaying Sprites:  The Item, Projectile, Block, and Enemy Sprites graphics consist of formatted texture atlases that allow them to be displayed with the SpriteSingleAnimation or SpriteContinuousAnimation class.  However, the link sprites all come from a single spriteSheet which requires Link sprites to be drawn with their own class utilizing source and destination rectangles.

Timing Control:  
We could take more control of animation speeds, movement speeds, etc.  by implementing a timer based on milliseconds and applying it to game objects rather than using the tick system currently in place.

Enemy/NPC Classes:
Boomerang remains in room after Goriya die.

Saving Dungeon Rooms:

Second Dungeon:
A second dungeon exists that has enemies and correct rooms, it does not work as of now due to problems with the room loader.

General/Misc:
Many files exist that are not used, but do work. If we had more time, we would have included them in the game. Some comments are included to help clarify unclear design choices.

Code Analysis:

518 warnings. Many to do with unrecognized spelling, so we ignored/suppressed them. Many errors complained that we used a Spritebatch without checking that it was null, but the way we implement the code means that it will never be null. Errors that complained about unused fields were mostly ignored, with the intention of using them in later iterations of the project.  Including some refactoring for collision handling, and some sounds were created and set up, but haven't yet been connected to their events.'

Reflection:

This sprint was challenging. In the first week, we assigned tasks to each member to implement new functionality regarding a settings menu. Logan was to do Screen Resolution; Izzy, controls and key binding; Terryl, music; Longfei, score; and Barry, the settings data structure. Miscommunication resulted in Terryl doing the settings skeleton, which Izzy refactored to be more flexible, cohesive, and to factor out common code. Barry, instead, focused on fixing the Save states, sprite effects, bombs, and link's sword, as they had bugs left over from previous sprints. That week went well, as we all worked on our respective tasks. However, we ran into many issues with previously-implemented aspects that were no longer functional or compatible with new changes. As the second week progressed, we started fixing various issues that had not yet been resolved, as well as adding more functionality. Logan focused on trying to implement a second dungeon, Izzy started implementing the key binding options, after finishing the Settings Page data structure, and Barry fixed locked and sealed doors. As the deadline approached we tried to fix as much about the functionality as we could, although there are still issues (as described above). We understand that there is more we can do to improve our game, but time constraints have left us unable to implement them all. 
