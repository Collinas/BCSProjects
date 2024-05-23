using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float finishTime = 1.0f;
    [SerializeField] ParticleSystem finishEffect;
    [SerializeField] AudioClip audioclip;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Finish"))
        {
            finishEffect.Play();
            GetComponent<AudioClip>().(audioclip);
            Debug.Log("End of the course");
            Invoke("LoadNextScene", finishTime);
            
        }
    }

    void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            Debug.Log("Game is finished");
        }
    }
}
