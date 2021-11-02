using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "audioList", menuName = "AudioLibrary")]
public class AudioBiblioteca : ScriptableObject
{
    public AudioClip[] audioList;
    public AudioClip backgroundMusic;
}
