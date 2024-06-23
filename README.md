Tips:
The games uses "NovaUI Framework" to display the interface
The game has only one fixed scene, and the screens are actually prefabs that is displayed and mounted at runtime (best way that i find to avoid the annoying lag that unity haves when loads a new scene)
The main pc game and the android app are actually the same project
It uses unity netcode for gameobjects to share data between the phone app and the main game
For obvious reasons, the scoring dll was deleted from github (but is not hard to find it on launched game files). It needs to be placed on "Assets/Plugins" folder
