# Zelda_V2

CSE 3902 : Group4

Authors: Barry Birschbach, Terryl Rumph, Logan Sauer, Isabel Smith, Longfei Yu

User manual:

Arrow Keys/WASD - move link;
Q - Quit;
R - Reset link's position;
E - deal link 1 damage;
U - cycle backwards through rooms;
I - cycle forwards through rooms;
Z/N - Attack;
X - Use Item
Enter - Pause Game
C - cycle through item selector when paused
Other controls are written in in-game prompts.


Known Bugs/Issues:

Controls:  
Link can walk away from his sword while it is drawing.

Items:
Boomerang cannot be used more than once.

Constant Class:  
Additional class(es) should be created for organizing single point of control, i.e. AnimationSpeedSettings.cs, DisplaySettings.cs, etc.

Sprite Classes:  
Currently there are two possible methods of displaying Sprites:  The Item, Projectile, Block, and Enemy Sprites graphics consist of formatted texture atlases that allow them to be displayed with the SpriteSingleAnimation or SpriteContinuousAnimation class.  However, the link sprites all come from a single spriteSheet which requires Link sprites to be drawn with their own class utilizing source and destination rectangles.

Timing Control:  
We could take more control of animation speeds, movement speeds, etc.  by implementing a timer based on milliseconds and applying it to game objects rather than using the tick system currently in place.

Enemy/NPC Classes:
Aquamentus fireballs do not follow the player. Enemy movement is sometimes janky.

Code Analysis:

245 warnings. Many to do with unrecognized spelling, so we ignored/suppressed them. Many errors complained that we used a Spritebatch without checking that it was null, but the way we implement the code means that it will never be null. Errors that complained about unused fields were mostly ignored, with the intention of using them in later iterations of the project.



