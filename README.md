# RVAlpha

🎯 Project Objective
The project aims to test whether new forms of interaction, such as natural hand gestures, increase user immersivity compared to traditional methods like joysticks or touchscreens. It focuses on maintaining low computational cost and financial accessibility for the end user.

🎮 Gameplay Mechanics

The game features simple yet effective mechanics where the user must survive by interacting with the environment using only hand gestures.

Player Actions:

Shoot Projectiles: Triggered by a specific hand gesture (open hand).

Defend: Blocks enemy projectiles using a defense gesture (closed fist).


Enemies:

A1: Moves horizontally and shoots projectiles at the user.

A2: Moves rapidly toward the user for a direct attack.

A3 (Final Boss): Fires projectiles and spawns A2-type enemies.

🛠️ Technical Stack

The following software and libraries were used to develop this version of the game:


* Game Engine: Unity 2019.f1.


* 3D Modeling: Blender 2.8.


* VR SDK: Google Cardboard SDK v1.201.


* Gesture SDK: Manomotion SDK 1.3.

💻 Minimum System Requirements

* To run the system correctly, the smartphone must meet these specifications:

* CPU: Octa-core (Cortex-A57 & Cortex-A53).

* RAM: 3GB.

* Camera: Must support the RGB (Red, Green, Blue) standard.

* Sensors: Gyroscope sensor required for VR.

* Connectivity: Internet access.

⚙️ Recognition Workflow

The gesture command system follows a specific processing pipeline:

1- Image Acquisition: Captured via the smartphone's rear camera.

2- Hand Detection: Identifies the user's hand within the frame.

3- Preprocessing: Segments the hand from the image background.

4- Feature Extraction: Detects the specific characteristics of the manual gesture.

5- Recognition: Compares the results against a Gesture Dictionary (database) of predefined gestures.

6- Execution: Triggers the corresponding in-game function if a valid gesture is recognized.
