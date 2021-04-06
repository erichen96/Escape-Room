# Escape-Room

First Person Movement
- WASD Key Movement
- 1st Person Camera Based on Mouse Movement
- Contains GroundCheck Object to determine if collision of player on ground. Used for Jumping.
- Destination used to grab objects with mouseClick. 

Environment
- Contains all objects that contains Layer: Ground. Used to determine if player is Grounded and can jump.

Interactable Objects
- Objects tagged with PickUps can be picked up when player has tool1 [1] activated. 
Objects can be grabbed/drop with [E] and thrown with left mouse.
- Scripts used: GravityGun

Gun
- Select Weapon using [2] or mousewheel.
- Shoots using Fire1/ Left Mouse Click
- Scripts used: Gun - Contains fireRate, Audio, Particle System, damage/range, impactForce(works on all objects), 
		Target - Can be attached to objects that can be destructible. (Default is 50f, 5 hits) 


Notes
- Issues with grabbing with KeyPress(E), TODO look for raycasting to replace
- Adjust gravity according to movement.
- PickUpPressureCube.cs is the same as PickUp.cs but contains boxId used for puzzle.
- Add animation on button press, ie OnTrigger also moves button into -y direction.
