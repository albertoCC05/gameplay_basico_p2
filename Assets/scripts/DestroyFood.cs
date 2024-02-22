using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFood : MonoBehaviour
{
    private UIManager uiManagerScript;
    [SerializeField] private float toopBound = 30f;
    [SerializeField] private float botoomBound = -10f;

    private void Start()
    {
        uiManagerScript = FindObjectOfType<UIManager>();
    }
    private void Update()
    {
        if (transform.position.z > toopBound) 
        {
            Destroy(gameObject);
        }

        if (transform.position.z < botoomBound) 
        {
            Destroy(gameObject);
            Debug.Log("GAME OVER");
            uiManagerScript.TotalScoreTextUpdate();
            uiManagerScript.ShowGameOverPanel();
           

            Time.timeScale = 0;
        }
    }
}
