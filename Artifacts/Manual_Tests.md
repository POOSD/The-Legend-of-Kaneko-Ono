
# Player Spawn (UID 001):
| No. | Steps to Reproduce | Expected Behavior |
|-----|--------------------|-------------------|
| 001 | Launch the game.  | Game window pops up/game starts up in Unity. Start game screen shows up. |
| 002 | Press "start".  | Gameplay screen starts up. Player object is spawned and is visible on the screen.|


# Player Movement (UID 009):
| No. | Steps to Reproduce | Expected Behavior |
|-----|--------------------|-------------------|
| 001 | Launch the game.  | Game window pops up/game starts up in Unity. Start game screen shows up. |
| 002 | Press "start".  | Gameplay screen starts up. Player object is spawned and is visible on the screen. |
| 003 | Press the "W" key on the keyboard.  | Player object moves upwards. |
| 004 | Press the "A" key on the keyboard.  | Player object moves leftwards.|
| 005 | Press the "S" key on the keyboard.  | Player object moves downwards. |
| 006 | Press the "D" key on the keyboard.  | Player object moves rightwards. |


# Consistent Game(UID 015):
| No. | Steps to Reproduce | Expected Behavior |
|-----|--------------------|-------------------|
| 001 | Launch the game.  | Game window pops up/game starts up in Unity. Start game screen shows up. |
| 002 | Press "start".  | Gameplay screen starts up. Player object is spawned and is visible on the screen. |
| 003 | Pause the game instance.  | Gameplay should pause. |
| 004 | Examine the game object that is tracking all the game data. | The game's difficulty, score, number of allied ship objects (including the player), number of enemy objects, and player health should all be visible and correctly reported. |

# Enemy Spawn (UID 012):
| No. | Steps to Reproduce | Expected Behavior |
|-----|--------------------|-------------------|
| 001 | Launch the game.  | Game window pops up/game starts up in Unity. Start game screen shows up. |
| 002 | Press "start".  | Gameplay screen starts up. Player object is spawned and is visible on the screen. |
| 003 | Wait a few seconds.  | The player ship should not move, an an enemy ship should also spawn, on the right side of the screen. |

# Main Menu (UID 005):
| No. | Steps to Reproduce | Expected Behavior |
|-----|--------------------|-------------------|
| 001 | Launch the game.   | Demonstration level starts up in game engine. |
| 002 | Press primary action button. | Player ship fires weapon, weapon blast hits enemy, blast plays hit animation. |
| 003 | Press secondary action button. | Player ship fires weapon, weapon blast hits enemy, blast plays hit animation. |
| 004 | Press primary action button twice. | Player ship fires two blasts of weapon, weapon blasts hit enemy, blasts play hit animations, enemy death animation plays, enemy disappears from screen. |
| 005 | Press primary action button. | Player ship fires a single blast of weapon, weapon blast doesn't hit anything, hit animation doesn't play, blast continues off screen. |

# Main Menu (UID 011):
| No. | Steps to Reproduce | Expected Behavior |
|-----|--------------------|-------------------|
| 001 | Launch the game.   | Game opens on main menu screen. |
| 002 | Hover over options. | Each menu option animates on mouse hover. |
| 003 | Click Options button. | Screen changes to Options screen. |
| 004 | Drag volume slider. | Bar fills or depletes to reference selected volume. |
| 005 | Click Back button. | Screen changes to Main Menu. |
| 006 | Click Exit button. | Debug message denotes that exit command has been registered. |
| 007 | Click Play button. | Screen changes to intended level. |

