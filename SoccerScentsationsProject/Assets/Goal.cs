using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{

    // audio
    public AudioSource source;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Ball"))
        {
            // delaying by two seconds
            source.PlayOneShot(clip);
            Invoke("SceneChanger", 3.0f);
            
        }
    }

    void SceneChanger()
    {
        SceneManager.LoadScene("WinScene");
    }
}
