# Program Organization

You should have your context, container, and component (c4model.com) diagrams in this section, along with a description and explanation of each diagram and a table that relates each block to one or more user stories.

Context Diagram:
![UML Diagram - System_Context_Diagram](https://user-images.githubusercontent.com/47250709/107869455-3d559e80-6e5c-11eb-85dd-c8a0899b2417.png)

This game is just intended to be a singleplayer experience, so there's not a lot of complexity required on this level; just the player interacting with the game, while it's running on a computer.

Container Diagram:
![UML Diagram - Container_Diagram](https://user-images.githubusercontent.com/47250709/107869458-50686e80-6e5c-11eb-8d77-fa1bd3005b58.png)

This is a more expanded view of how the game itself is working at runtime, including the use of the Unity engine and the UI we'll be using.

Component Diagram:


# Code Design

You should have your UML Class diagram and any other useful UML diagrams in this section. Each diagram should be accompanied by a brief description explaining what the elements are and why they are in the diagram. For your class diagram, you must also include a table that relates each class to one or more user stories.

UML Class Diagram:
![UML Diagram - UML_Class_Diagram_Example (1)](https://user-images.githubusercontent.com/47250709/107869440-126b4a80-6e5c-11eb-8e3c-3dfd453481f1.png)

As this is a bullet hell game with a cyberpunk theme, most of the moving parts of this game are ships, with the exception of drones with more specified purposes.

We're not *exactly* sure how the allies and more basic enemies will move and interact with each other and the enemy, so they're less fleshed out for now; hence, the Character is the most developed because they're crucial to development, and are essentially a "must-have".


# Data Design

We are not using a database, as you can see in the context diagram.

# Business Rules

As an outright requirement, we'll be working to make all visual components visually distinct from each other, giving allies and enemies separate design schemes, and keep the background and foreground separate from the environment the player actually interacts with, for the sake of visual clarity.
We're also sticking to principles like SOLID and DRY, of course.

# User Interface Design

UML UI Diagram:
![UML Diagram - UI_Diagram (3)](https://user-images.githubusercontent.com/47250709/108124577-5d13df00-7075-11eb-83d7-2820e19fa8fe.png)

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
