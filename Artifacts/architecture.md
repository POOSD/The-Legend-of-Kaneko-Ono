# Program Organization

Context Diagram:
![UML Diagram - System_Context_Diagram](https://drive.google.com/uc?export=view&id=1emUW3mmPvc9NsXM-GZ8Idz3IlPOLv1yy)

| Block Name   | User Story |
|--------------|------------|
| Player       |     011    |
| Unity Game   |     003    |
| Host Machine |     011    |

As a single-player video game, the game only has one user per running process; a player, who'll either be altering configurations of the software via the UI, or just playing the game via the controls.

The game itself will be running on the Unity engine, and won't rely on multi-threading. It'll be a single instance of the game running on the user's machine.

Container Diagram:
![UML Diagram - Container_Diagram](https://drive.google.com/uc?export=view&id=1sZIVpyhWZdRLkIU7kmncsFDAnE_u4aDq)


| Block Name   | User Story |
|--------------|------------|
| Player       |     011    |
| UI Window    |     009    |
| Unity Engine |     003    |
| Game Code    |     011    |
| Host Machine |     011    |

This is a more expanded view of how the game itself is working at runtime, including the use of the Unity engine and the UI we'll be using.

The UI will include the Opening Screen, Sound Settings Screen, Gameplay Screen, Player Won Screen and Player Lost Screen; it's all run via the Unity engine processing the code base.

The directory storing settings and save data will likely be handled by the Unity engine itself.

Component Diagram:
![UML Diagram - UML Component Diagram](https://drive.google.com/uc?export=view&id=1Fm1CzJPQtP9jNXjcxQwDEZ-rgEJ55X74)


| Block Name   | User Story |
|--------------|------------|
| Game Management | 011 |
| Enemy AI Controller | 016 |
| Ally AI Controller | 017 |
| Environment Controller | 018 |
| Player Controller | 009 |

Our Component Diagram illustrates how the user interface window facilitates the player interacting with the game engine as well as all of the connected components. The user interface window displays the ongoings of the game and provides feedback to the player of the actions taken. The player controller user interface takes input from the player and manipulates the values of the locations that the player character assets are rendered on screen which is displayed by the user interface window. The player controller user interface accomplishes this by interfacing with the unity game engine as well as with the game management interface. The game management interface interacts and orchestrates most of the game code and subsequent interaction with other objects. The enemy ai controller determines the logic of the enemies and interfaces with the game management interface to collect information to complete this logic. The ally ai controller functions similarly to the enemy ai controller but contains different logic. The environment controller determines the behavior of the non character assets in the game, from purely astetic assets to player interactable assets. The environment controller interacts with the game management interface to determine how to act. The game management interface also interacts with the directory to retrive and store files or variables temporarily and to direct the game engine on what and how to save data for long term storage.


# Code Design

UML Class Diagram:
![UML Diagram - UML_Class_Diagram_Example (3)](https://github.com/POOSD/COP4331C-Group-5/blob/main/Artifacts/diagramAlt1.png)


| Class Name  | User Story |
|-------------|------------|
| Ship        |     000    |
| Drone       |     000    |
| NPC         |     002    |
| Player      |     011    |
| Character   |     005    |

As this is a bullet hell game with a cyberpunk theme, most of the moving parts of this game are ships, with the exception of drones with more specified purposes.

We're not *exactly* sure how the allies and more basic enemies will move and interact with each other and the enemy, so they're less fleshed out for now; hence, the Character is the most developed because they're crucial to development, and are essentially a "must-have".

In the meantime, the "Ship" class is meant to encompass nearly all the currently planned entities we'll have ingame, because it's a game centered around space-ships. We'll soon most-likely also have a "Bullet" class that'll be producible by the fire() function within the Ship class.

The Drone class is an alternative entity, less focused around being a typical ship and more around being a technological aide to whichever side it's aligned for.

The Ally/Enemy classes simply represent the different sides of the conflict, excluding the player themselves, which is why they're under NPC.

The "Character" class, of course, represents the playable character.


# Data Design

We are not using a database, as you can see in the context diagram.

# Business Rules

As an outright requirement, we'll be working to make all visual components visually distinct from each other, giving allies and enemies separate design schemes, and keep the background and foreground separate from the environment the player actually interacts with, for the sake of visual clarity.
We're also sticking to principles like SOLID and DRY, of course.

# User Interface Design

UML UI Diagram:
![UML Diagram - UI_Diagram (8)](https://user-images.githubusercontent.com/47250709/112773518-537e7f00-9004-11eb-9d5b-af6b27c5d91a.png)


| Screen Name | User Story |
|-------------|------------|
| Opening Screen | 011 |
| Sound Settings Screen | 013 |
| Gameplay Screen | 010 |
| Player Won Screen | 014 |
| Player Lost Screen | 014 |


# Resource Management

The maximum extent of the resources we'll manage will be the Unity project that should encompass this game as an executable, which even in the worst-case scenario shouldn't ever exceed 1 GB in size, the amount of RAM it'll take up at once, which *definitely* won't ever reach 1 GB or even close to it, and the specific play history file that'll be modified over time to track the player's progress.

# Security

None of us are security experts, and as a game our project won't be handling sensitive information. However, to avoid our code being used maliciously, we'll avoid simple bugs like buffer overflow to keep our data inputs sanitized.

# Performance

This game will most likely run at 60 fps on most computers that are intended for gameplay, solely because the game will be unlikely to reach a significant size due to the time constraints.

# Scalability

We're keeping everything as modular and encapsulated as possible to allow for each new feature or content component we have to be easily added without compromising earlier code.

# Interoperability
The system is not expected to share data or resources with other software or hardware.

# Internationalization/Localization

The story should say mostly implicit, avoiding an excess of actual story-related text outside of perhaps features written in the background or other such visual assets, and whether or not an entity is a friend or foe will be implemented via visual design instead of outright writing. Thus, if any text is left to be localized, it should be rather minimal and feasible.

For now we're avoiding localization as it's not a priority, but if we decide to continue the project beyond the scope of this class, it'll happen quite easily.

# Input/Output

I/O should only concern the storage of play history, and it might ultimately be handled by the engine instead of our own specified storage method... however, in the event that it is handled more specifically, I/O will mostly likely be:

check if file exists (-> if not, make it so) -> open file -> write history of current player's play history -> close file

# Error Processing

The strategy for now is to try and detect as many errors as possible, get the most possible information about them, and quit almost immediately while notifying the user of the error.

An error message will always convey which class & function it occurred in, and if possible, what object it was in.

To avoid complicating errors that wouldn't normally happen, like a file remaining somehow affected mid-shutdown in response to an error, it'll always trigger a built-in shutdown function that'll clean up things like extra open files & track all the information it can about the status of things at shutdown.

Each class'll be verifying its own data. There *might* ultimately be a set class to handle interpreting error codes, but nothing to check if data indicates an error in the first place.

We'll likely use Unity's methods for reporting errors to the user, but make ourselves the actual interpretation and error capturing code.

# Fault Tolerance

For now, the game won't tolerate faults at all. Further on in development we may write code that's more oriented at working around them, but for now the base game needs to be robust enough to avoid nearly all possible errors.

# Architectural Feasibility

The architecture is ultimately ridiculously simple, so it's definitely feasible.

# Overengineering

We're just not going to be considering overengineering until we have a solid codebase.

# Build-vs-Buy Decisions

The most 3rd-party technology we'll be using will be Unity. Beyond that, almost everything should be home-grown.

# Reuse

We may decide to use premade visual/auditory components if, for some reason, we cannot find the time to make our own. We'll almost certainly build off code from some Unity example projects.

# Change Strategy

Currently, the only possible changes in architecture are
- Adding, removing or changing components of the player ship
- Adding, removing or changing enemy types
- Adding UI features
- Adding or changing ally behavior

The first two, and ally behavior, should be easy to handle changing due to the modularity of the player ship itself, and the object-oriented design of the enemies. The UI isn't designed that modularly yet, so that simply requires more work.
