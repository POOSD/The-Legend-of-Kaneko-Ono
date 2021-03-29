
# Player Spawn (UID 001):
| No. | Steps to Reproduce | Expected Behavior |
|-----|--------------------|-------------------|
| 001 | Launch the game.  | Game window pops up/game starts up in Unity. Start game screen shows up. |
| 002 | Press "play".  | Gameplay screen starts up. Player object is spawned and is visible on the screen.|


# Player Movement (UID 009):
| No. | Steps to Reproduce | Expected Behavior |
|-----|--------------------|-------------------|
| 001 | Launch the game.  | Game window pops up/game starts up in Unity. Start game screen shows up. |
| 002 | Press "play".  | Gameplay screen starts up. Player object is spawned and is visible on the screen. |
| 003 | Press the "W" key on the keyboard.  | Player object moves upwards. |
| 004 | Press the "A" key on the keyboard.  | Player object moves leftwards.|
| 005 | Press the "S" key on the keyboard.  | Player object moves downwards. |
| 006 | Press the "D" key on the keyboard.  | Player object moves rightwards. |


# Consistent Game(UID 015):
| No. | Steps to Reproduce | Expected Behavior |
|-----|--------------------|-------------------|
| 001 | Launch the game.  | Game window pops up/game starts up in Unity. Start game screen shows up. |
| 002 | Press "play".  | Gameplay screen starts up. Player object is spawned and is visible on the screen. |
| 003 | Pause the game instance.  | Gameplay should pause. |
| 004 | Examine the game object that is tracking all the game data. | The game's difficulty, score, number of allied ship objects (including the player), number of enemy objects, and player health should all be visible and correctly reported. |

# Enemy Spawn (UID 012):
| No. | Steps to Reproduce | Expected Behavior |
|-----|--------------------|-------------------|
| 001 | Launch the game.  | Game window pops up/game starts up in Unity. Start game screen shows up. |
| 002 | Press "play".  | Gameplay screen starts up. Player object is spawned and is visible on the screen. |
| 003 | Wait a few seconds.  | The player ship should not move, an an enemy ship should also spawn, on the right side of the screen. |

# New Player Asset, Background (UID 010):
| No. | Steps to Reproduce | Expected Behavior |
|-----|--------------------|-------------------|
| 001 | Launch the game.  | Game window pops up/game starts up in Unity. Start game screen shows up. |
| 002 | Press "play".  | Gameplay screen starts up. New player object is spawned and is visible on the screen, the new background is behind the player. |
| 003 | Press the "W" key on the keyboard.  | New player object moves upwards. |
| 004 | Press the "A" key on the keyboard.  | New player object moves leftwards.|
| 005 | Press the "S" key on the keyboard.  | New player object moves downwards. |
| 006 | Press the "D" key on the keyboard.  | New player object moves rightwards. |

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

# Drones (UID 024):
| No. | Steps to Reproduce | Expected Behavior |
|-----|--------------------|-------------------|
| 001 | Launch the game.   | Game opens on main menu screen. |
| 002 | Click Play button. | Screen changes to gameplay screen. Ally and Enemy drones objects are spawned randomly onto the screen on opposing sides.|

# Parallax Background (UID 019):
| No. | Steps to Reproduce | Expected Behavior |
|-----|--------------------|-------------------|
| 001 | Launch the game.  | Game opens on main menu screen. |
| 002 | Press "play".     | Gameplay screen starts up. Player object is spawned and is visible on the screen. |
| 003 | Press "d"         | The player moves to the right, and the backgrounf scrolls infinitely, with each layer moving at independent speeds |

# Damage (against player) (UID 029):
| No. | Steps to Reproduce | Expected Behavior |
|-----|--------------------|-------------------|
| 001 | Launch the game.  | Game opens on main menu screen. |
| 002 | Press "play".     | Gameplay screen starts up. Player object is spawned and is visible on the screen. |
| 003 | Move to nearest enemy drone | The health bar size decreases, and the current health decreases. |

# Healing (UID 025):
| No. | Steps to Reproduce | Expected Behavior |
|-----|--------------------|-------------------|
| 001 | Launch the game.  | Game opens on main menu screen. |
| 002 | Press "play".     | Gameplay screen starts up. Player object is spawned and is visible on the screen. |
| 003 | Move to nearest enemy drone | The health bar size decreases, and the current health decreases. |
| 004 | Move to nearest ally drone  | The health bar size increases, and the current health increases. |

# Game End Status Screen (UID 014):
| No. | Steps to Reproduce | Expected Behavior |
|-----|--------------------|-------------------|
| 001 | Launch the game.   | Game opens on main menu screen. |
| 002 | Click Play button. | Screen changes to gameplay screen.|
| 003 | Play game poorly.  | Screen changes to reflect gameplay.|
| 004 | Lose game.  | Screen changes to "Game Over" screen.|
| 005 | Play game well.  | Screen changes to reflect gameplay.|
| 006 | Win game.  | Screen changes to "You Win!" screen.|

# Volume Toggle (UID 013):
| No. | Steps to Reproduce | Expected Behavior |
|-----|--------------------|-------------------|
| 001 | Launch the game.   | Game opens on main menu screen. Music starts playing as menu screen pops up.|
| 002 | Click Options Button. | Screen changes to options screen.|
| 003 | Click and drag the volume slider to the left. | Music volume goes down compared to earlier.|
| 004 | Click and drag the volume slider to the right. | Music volume goes up compared to earlier.|

# Putting it All Together (UID 025):
| No. | Steps to Reproduce | Expected Behavior |
|-----|--------------------|-------------------|
| 001 | Launch the game.   | Game opens on main menu screen. Music plays.|
| 002 | Click Options Button. | Screen changes to options screen.|
| 003 | Click and drag the volume slider to the left and right. | Music volume goes down/up respectively compared to earlier.|
| 004 | Click Back Button. | Screen changes back to to main menu screen.|
| 005 | Click Play button. | Screen changes to updated current demo gameplay screen with previous sprint's functionalities. |

# Enemy Spawning (UID 039):
| No. | Steps to Reproduce | Expected Behavior |
|-----|--------------------|-------------------|
| 001 | Launch the game.  | Game window pops up/game starts up in Unity. Start game menu screen shows up. |
| 002 | Press "play".  | The enemy drones and ships spawn infinitely across the screen (to the left of the player position offscreen).|

# Enemy Ship Movement (UID 008):
| No. | Steps to Reproduce | Expected Behavior |
|-----|--------------------|-------------------|
| 001 | Launch the game.  | Game window pops up/game starts up in Unity. Start game screen shows up. |
| 002 | Press "play".  | The enemy ships spawn and moves left infinitely.|

# Enemy Ship Shooting (UID 037):
| No. | Steps to Reproduce | Expected Behavior |
|-----|--------------------|-------------------|
| 001 | Launch the game.  | Game window pops up/game starts up in Unity. Start game screen shows up. |
| 002 | Press "play".  | The enemy ships spawn and moves left infinitely, shooting magenta bullet sprites every second.|
| 003 | The sprite hits the player | The player's health decreases, taking on damage.|

# Game end screens win and lose condition (UID 033):
| No. | Steps to Reproduce | Expected Behavior |
|-----|--------------------|-------------------|
| 001 | Launch the game.  | Game window pops up/game starts up in Unity. Start game menu screen shows up. |
| 002 | Press "play".  | Gameplay screen shows up. |
| 003 | Play game, defeat 15 enemies (use space bar/mouse to shoot at them and W/A/S/D to move). | Game won screen shows up. |
| 004 | Press "play again" button. | Gameplay screen shows up. |
| 005 | Play game (use space bar/mouse to shoot at them and W/A/S/D to move), get hit by bullets multiple times until 0 health. | Game over screen shows up. |

