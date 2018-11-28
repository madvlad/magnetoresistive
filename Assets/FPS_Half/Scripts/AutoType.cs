using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AutoType : MonoBehaviour
{

    public float letterPause = 0.2f;
    public AudioClip sound;
    public AudioClip sound2;

    string message;

    // Use this for initialization
    void Start()
    {
        message = GetComponent<Text>().text;
        GetComponent<Text>().text = "";
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        foreach (char letter in message.ToCharArray())
        { 
            GetComponent<Text>().text += letter;
            if (sound && sound2)
            {
                int random = Random.Range(0, 1);
                if (random == 1)
                {
                    GetComponent<AudioSource>().PlayOneShot(sound);
                }
                else
                {
                    GetComponent<AudioSource>().PlayOneShot(sound2);
                }

            }
            yield return 0;
            yield return new WaitForSeconds(letterPause);
        }
    }
}