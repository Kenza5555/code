using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JUMPSCARE : MonoBehaviour
{
    public GameObject JumpScareUI;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            JumpScareUI.SetActive(true);
            Invoke("hide", 1);
        }
    }
    public void hide()
    {
        JumpScareUI.SetActive(false);
    }
    private void Start()
    {
        hide();
    }
}
