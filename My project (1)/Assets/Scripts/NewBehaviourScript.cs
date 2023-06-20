using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        // Здесь вы можете выполнить любую логику перед запуском анимации,
        // если это необходимо.

        animator.SetTrigger("TriggerName");

    }
}


