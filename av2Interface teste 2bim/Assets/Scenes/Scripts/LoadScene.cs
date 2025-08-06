using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UI;

public partial class ControleDeAudio : MonoBehaviour
{
    public int Volume;
    public int VolumeSFX;
    public bool musica;

    public Slider volumeslider;
    public Slider volumeSFXSlider;
    public Toggle toggleMusica;

    void Start()
    {
        musica= toggleMusica.isOn;
        volume = volumeSFXSlider.value;
    }

    void Update()
    {
        
    }
    
}