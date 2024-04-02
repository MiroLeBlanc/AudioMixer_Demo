using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GestionnaireAudio : MonoBehaviour
{
    [SerializeField]
    private AudioMixer audioMixer;
    // Start is called before the first frame update
    void Start()
    {
        //audioMixer.SetFloat("VolumeMusique", -30f);
    }

    public void AjusteVolumeMusique(float volume){
        audioMixer.SetFloat("VolumeMusique", ConvertTologarithmique(volume) );
    }

    public void AjusteVolumeEffets(float volume){
        audioMixer.SetFloat("VolumeEffets", ConvertTologarithmique(volume) );
    }



    private float ConvertTologarithmique(float volume){
        return Mathf.Log10(volume) * 20;
    }
}
