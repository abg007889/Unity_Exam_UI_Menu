using UnityEngine;
using UnityEngine.Audio; // using Audio API(功能)
//using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public AudioMixer mixer;
    /*public void SetVBGM(float value)
    {
        mixer.SetFloat("VBGM", value);
    }*/
    public void SetVSFX(float value)
    {
        mixer.SetFloat("VSFX", value);
    }
}
