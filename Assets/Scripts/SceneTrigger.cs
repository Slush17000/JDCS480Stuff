using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour
{
    public UnityEvent onEnter;
    public UnityEvent onExit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // onEnter.Invoke();
            SceneManager.LoadScene("Scene2");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onExit.Invoke();
        }
    }
}
