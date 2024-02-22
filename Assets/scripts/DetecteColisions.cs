using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetecteColisions : MonoBehaviour
{
    private UIManager uiManageScript;

    private void Start()
    {
        uiManageScript = FindObjectOfType<UIManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

        Destroy(other.gameObject);

        uiManageScript.updateScore();
    }
}
