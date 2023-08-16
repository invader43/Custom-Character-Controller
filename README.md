# Unity Primitive Shapes Game Character

This repository contains a Unity project showcasing a game character created using primitive shapes. All the components are written from scratch and requires no additional packages except for rendering text (TMPro) and Unity 2022.3.4f1.

## Introduction
This Unity project showcases a game character that is visually built using primitive shapes available within Unity's framework. 

## Scripts
The character's functionality is achieved through a set of attached scripts that collectively enable smooth user interaction, lifelike animations, and responsive motion. The primary scripts include:

### [Input Manager](Assets/Scripts/InputManager.cs)

The Input Manager script is responsible for capturing user inputs through the Input Action Asset. Input Action Asset can be initialized as a C# Object and referenced in any other Script.

![Input Action Map for working with multiple controls ](https://github.com/invader43/Custom-Character-Controller/assets/85817312/0483b88b-844b-4e27-87e0-0170848dafb5)



### [Player Locomotion](Assets/PlayerLocomotion.cs)

The Player Locomotion script converts user inputs into Rigidbody-based motion for the character. By translating user actions into physical movement, this script ensures a seamless connection between player input and in-game behavior.


### [Animation Manager](Assets/AnimationManager.cs)

The Animation Manager scripts are crucial for handling the character's animations. They manage the character's animation states and transitions, providing visual feedback that matches the character's actions and interactions with the environment.

Animations used are also extremely rudimentary , infact the simple character model used is also made from cubes and cylinders inside Unity itself.

## [Camera Manager](Assets/CameraManager.cs)

The Camera Manager is a GameObject present in the ExampleScene. The Camera Manager facilitates character tracking, ensuring that the camera follows the character's movements smoothly. Additionally, it supports a pivot-based free look, allowing players to explore their surroundings from different angles.

[Working Controls](https://github.com/invader43/Custom-Character-Controller/assets/85817312/8a48cb54-ed09-469b-a391-ae76b4c42501)


## Usage

To use and explore the Unity Primitive Shapes Game Character project:

1. Clone this repository to your local machine.
2. Open the Unity project using Unity Hub or your preferred Unity version.
3. Navigate to the `ExampleScene` to see the character and its functionality in action.

Optionally , a '.asset' file is also available for download which you can import directly into any existing Project.








