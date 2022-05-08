# Scriptable Object Mediators
Package with the tools for dynamic referencing objects between scenes (Mediators)
# Getting started
## How to subscribe a GameObject as a Mediator
First of all, go to the Project window and create a new GameObjectReference (Assets > Create > References > GameObject) and name it to fit the GameObject in question.
![Unity_nAIv3axY2W](https://user-images.githubusercontent.com/68963406/167307322-ed758af8-38d4-4e25-8aaf-5b312a8b811a.png)

Go to the GameObject at the scene(s) you want to assign as a mediator subscriber. Add the component "MediatorSubscriber" to your GameObject and set the GameObjectReference ScriptableObject you've just created, and in "InitialObjectToSubscribe" the object to be served as a subscriber. 

![image](https://user-images.githubusercontent.com/68963406/167307357-1b4567d3-4d36-4839-ac15-49e760853431.png)

You can initialize this process in Awake or by script (by calling the public method `Subscribe()`), as long as it is initialized before any script that accesses the GameObjectReference. 
## Testing
Using the component "MediatorCinemachineIntegration", you can dynamically assign a GameObject to be followed by the Virtual camera by setting its reference. This is an example of many integrations that can be made from this system.
![image](https://user-images.githubusercontent.com/68963406/167307368-a0564407-0d09-4eb5-88dd-ec52fce8fbd2.png)

