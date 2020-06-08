# Zelda_V2

CSE 3902 : Group4

Authors: Barry Birschbach, Terryl Rumph, Isabel Smith, Logan Sauer, Longfei Yu


Known Bugs/Issues:

Controls:  Link doesn't always draw correctly when multiple input commands are received.

Constant Class:  Constant class needs to be cleaned up, so that only constant values are held in that file.  Additional class(es) should be created for organizing single point of control, i.e. AnimationSpeedSettings.cs,
                 DisplaySettings.cs, etc.

Sprite Classes:  Currently there are two possible methods of displaying Sprites:  The Item, Projectile, Block, and Enemy Sprites graphics consist of formatted texture atlases that allow them to be displayed with
                the SpriteSingleAnimation or SpriteContinuousAnimation class.  However, the link sprites all come from a single spriteSheet which requires Link sprites to be drawn with their own class utilizing
                source and destination rectangles.

Scaling:  This needs to be adjusted so that we can work with dynamic screen sizes.

Timing Control:  We could take more control of animation speeds, movement speeds, etc.  by implementing a timer based on milliseconds and applying it to game objects rather than using the tick system currently
                 in place.

