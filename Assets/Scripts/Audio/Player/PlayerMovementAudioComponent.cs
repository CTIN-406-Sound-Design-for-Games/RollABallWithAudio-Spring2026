using UnityEngine;

/** Component that handles player movement audio **/
public class PlayerMovementAudioComponent : MonoBehaviour
{
    [SerializeField]
    AK.Wwise.Event footstepAudioEvent; // Audio event for footsteps

    // Play footstep audio
    public void PlayFootstepAudio()
    {
        footstepAudioEvent.Post(this.gameObject);
    }
}
