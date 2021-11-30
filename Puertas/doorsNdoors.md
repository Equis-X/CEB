Door: Open, Closed, Locked, Unlocked
	Open -> Closed
	Closed -> Open
	Unlocked -> Locked
	Locked -> Unlocked
	
	Open -> Open : error
	Closed -> Closed : error
	...
	
--------------------------------------------
Door.OpenAndUnlocked(key: guid)
Door.OpenAndLocked(key: guid)
Door.ClosedAndUnlocked(key: guid)
Door.ClosedAndLocked(key: guid)

val door = Door.xyz

door.Open() //when Locked error 
door.Close()
door.Lock()
door.Unlock(key)

door.IsOpen, IsClosed, IsLocked, IsUnlocked -> boolean


Room 1: OOP, Imperative, Mutable
	val doorA = Door.OpenAndLocked(someKey); // Open + Locked
	doorA.Close(); // Closed + Locked
	
Room 2: OOP, Functional (no mutation)
	val doorA = Door.OpenAndLocked(someKey); // Open + Locked
	val doorB = doorA.Close(); // Closed + Locked
