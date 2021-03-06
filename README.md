# Escape-Room

First Person Movement
- WASD Key Movement
- 1st Person Camera Based on Mouse Movement
- Contains GroundCheck Object to determine if collision of player on ground. Used for Jumping.
- Destination used to grab objects with mouseClick. 

Environment
- Contains all objects that contains Layer: Ground. Used to determine if player is Grounded and can jump.

Interactable Objects
- Objects with Collider & Rigidbody + PickUp script. Allows for player pick up via mouseClick/Release.

Notes
- Adjust gravity according to movement.