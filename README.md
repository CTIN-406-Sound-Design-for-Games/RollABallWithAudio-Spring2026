# Roll-A-Ball-With-Audio

Roll-A-Ball, now with sound! For USC course CTIN 406: Sound Design for Games.

Based on Unity's [Roll-A-Ball tutorial](https://learn.unity.com/project/roll-a-ball), adapting the [completed project files](https://assetstore.unity.com/packages/essentials/tutorial-projects/unity-learn-roll-a-ball-completed-project-files-urp-77198) and adding newly implemented audio.

## Week 8: Dynamically Driven Audio, Footsteps
1. [Download the `week8-dynamically-driven-audio-footsteps` version of the project](https://github.com/CTIN-406-Sound-Design-for-Games/RollABallWithAudio-Spring2026/archive/refs/heads/week8-dynamically-driven-audio-footsteps.zip)
2. The following may be helpful for **Project 2**:
	- Unity:
	    - Assets/Scripts/Audio/Player/PlayerMovementAudioComponent.cs
	    - Assets/Scripts/Audio/Player/FirstPersonFootstepAudioTrigger.cs
	    - Assets/Scenes/Week8_Footsteps_FirstPerson.unity
	    - Assets/Scenes/Week8_Footsteps_ThirdPerson.unity
	- Wwise:
		- \Containers\Default Work Unit\SFX\FLY\FLY_Footstep
		- \Switches\Default Work Unit\SWI_FootstepMaterial

## Week 4: Middleware, Ambiences
1. [Download the `week4-middleware-ambiences` version of the project](https://github.com/CTIN-406-Sound-Design-for-Games/RollABallWithAudio-Spring2026/archive/refs/heads/week4-middleware-ambiences.zip)
2. The following may be helpful for **Project 1**:
	- Unity:
		- Assets/Scenes/Week6_Part1_Middleware.unity
		- Assets/Scenes/Week6_Part2_Ambiences.unity
		- Assets/Scripts/Audio/DistanceBasedAmbienceZone.cs
		- Assets/Scripts/Audio/TriggerBasedAmbienceZone.cs
	- Wwise:
		- RollABallWithAudio-Spring2026_WwiseProject
			- \Containers\SFX\SFX\AMB

## Week 3: Implementation

### Etude 3: Unity Audio Replacement
1. [Download the `week3-audio-implementation` version of the project](https://github.com/CTIN-406-Sound-Design-for-Games/RollABallWithAudio-Spring2026/archive/refs/heads/week3-audio-implementation.zip)
2. **Replace all existing audio** with new sound assets that you create
3. (Optional) **Implement new audio** where there previously was none
	- Some ideas:
		- VO for each pickup that matches the current pickup count
		- Adding background music (BGM)
		- Playing different audio clips based on ball velocity
4. **Create a Windows build**, zip it, and upload the zip using the form provided in class
5. Come to class prepared to share and discuss with everyone!

## Dependencies
- [Unity 6.3 LTS (6000.3.5f2)](https://unity.com/download)
- [Wwise 2025.1.4](https://audiokinetic.com)
