using UnityEngine;

public class MusicController : MonoBehaviour
{
    public static MusicController Instance;

    public GameObject dogSound;
    AudioSource audioSource, dogAudio;
    public AudioClip takeKeyClip, takeBatteryClip, openDoor, lockedDoor, walk,candlesMusic;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        dogAudio = dogSound.GetComponent<AudioSource>();
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void PlayWalkClip() => audioSource.PlayOneShot(walk);

    public void PlayDoorOpenClip() => audioSource.PlayOneShot(openDoor);

    public void PlayLockedDoorClip() => audioSource.PlayOneShot(lockedDoor);

    public void PlayTakeKeyClip() => audioSource.PlayOneShot(takeKeyClip);

    public void PlayTakeBatteryClip() => audioSource.PlayOneShot(takeBatteryClip);

    public void PlayDogBark() => dogAudio.PlayOneShot(dogAudio.clip);

    public void PlayCandlesMusic() => audioSource.PlayOneShot(candlesMusic);

}
