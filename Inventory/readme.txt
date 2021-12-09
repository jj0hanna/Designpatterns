Johanna Johansson
I made a simple Inventory
Playe the game in full HD(1920x1080)

1- I implemented a singelton in the Playerscript2 script since i only want to have one player.
And to be able to get global access to the players instance. T.e.x Playerscript2.GetInstance.getHP()

2- If im not mistaken then i used Composite pattern for my class "ItemObject" since i can create different objects like
HealthPotion,Weapon, Coins etc

3- i Made a factory pattern in my "PotionFactory" class. If i bump into the "cubefactory" in the middle with my player then it spawn
a new potion. In this factory i could also add different potions etc if i wanted to.

4-I used observer pattern between the playerscript2 and the UI manager. So when i add HP to the player 
then the UI updates.


5- I used component pattern for my player with a "playerController" that controlls the playerinput and player movment
