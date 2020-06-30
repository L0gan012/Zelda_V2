# Zelda_V2

CSE 3902 : Group4

Authors: Barry Birschbach, Terryl Rumph, Logan Sauer, Isabel Smith, Longfei Yu

User manual:

Arrow Keys/WASD - move link;
Q - Quit;
R - Reset;
E - deal link 1 damage;
U - cycle backwards through rooms;
I - cycle forwards through rooms;
Z/N - Attack;
1 - use bomb;
2 - use fire;
3 - use ladder;
4 - use wooden boomerang;
5 - use magic boomerang;
6 - use wooden arrows;
7 - use silver arrows;

Known Bugs/Issues:

Controls:  
Link doesn't always draw correctly when multiple input commands are received. Short animations are cancelled by quick key releases. 
If you switch between classes and control link at the same time, the game will crash. That will be fixed. 
Precise input allows Link to get stuck in between blocks.=
When hit with items, enemies do not disappear.


Constant Class:  
Additional class(es) should be created for organizing single point of control, i.e. AnimationSpeedSettings.cs, DisplaySettings.cs, etc.

Sprite Classes:  
Currently there are two possible methods of displaying Sprites:  The Item, Projectile, Block, and Enemy Sprites graphics consist of formatted texture atlases that allow them to be displayed with the SpriteSingleAnimation or SpriteContinuousAnimation class.  However, the link sprites all come from a single spriteSheet which requires Link sprites to be drawn with their own class utilizing source and destination rectangles.

Scaling:  
This needs to be adjusted so that we can work with dynamic screen sizes.

Timing Control:  
We could take more control of animation speeds, movement speeds, etc.  by implementing a timer based on milliseconds and applying it to game objects rather than using the tick system currently in place.

Enemy/NPC Classes:
A number of Enemy Classes need movement implemented. Some NPC's caused the damage animation for link. That will be fixed.

Code Analysis:

245 warnings. Many to do with unrecognized spelling, so we ignored/suppressed them. Many errors complained that we used a Spritebatch without checking that it was null, but the way we implement the code means that it will never be null. Errors that complained about unused fields were mostly ignored, with the intention of using them in later iterations of the project.



