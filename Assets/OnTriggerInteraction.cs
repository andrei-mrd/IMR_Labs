using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearAttackByName : MonoBehaviour
{
    [SerializeField] private Animator bearAnimator;
    [SerializeField] private string slimeName = "TurtleShellPBR";
    [SerializeField] private float attackDistance = 0.25f;

    Transform slime;

    void Start()
    {
        var go = GameObject.Find(slimeName);
        if (go != null) slime = go.transform;
    }

    void Update()
    {
        if (slime == null) return;
        if (!slime.gameObject.activeInHierarchy) { bearAnimator.SetBool("IsInteracting", false); return; }
        float d = Vector3.Distance(transform.position, slime.position);
        bearAnimator.SetBool("IsInteracting", d < attackDistance);
    }
}
