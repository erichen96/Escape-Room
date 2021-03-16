# Escape-Room

First Person Movement
- WASD Key Movement
- 1st Person Camera Based on Mouse Movement
- Contains GroundCheck Object to determine if collision of player on ground. Used for Jumping.
- Destination used to grab objects with mouseClick. 

Environment
- Contains all objects that contains Layer: Ground. Used to determine if player is Grounded and can jump.

Interactable Objects
- Objects with Collider & Rigidbody + PickUp script. Allows for player pick up via mouseClick/Release && KeyPress(E).

Gun
- Currently uses Right Mouse Click to Fire.
- Scripts used: Gun - Contains fireRate, Audio, Particle System, damage/range, impactForce(works on all objects), 
		Target - Can be attached to objects that can be destructible. (Default is 50f, 5 hits) 


Notes
- Issues with grabbing with KeyPress(E), TODO look for raycasting to replace
- Adjust gravity according to movement.
- PickUpPressureCube.cs is the same as PickUp.cs but contains boxId used for puzzle.
- Add animation on button press, ie OnTrigger also moves button into -y direction.
