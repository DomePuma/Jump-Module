using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    [SerializeField] int maxSauts;
    [SerializeField] int jumpForce;
    [SerializeField] int layer;

    [SerializeField] Rigidbody rb;

    private int nbSauts;

    private void Start()
    {
        if (rb != null) return;
        Debug.LogError("Aucun rigidbody !");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (layer != collision.gameObject.layer) return; //Pour détecter le layer du sol et valider la condition
        nbSauts = 0;
    }
    public void Jump()
    {
        if(nbSauts < maxSauts)
        {
            rb.AddForce(transform.up * jumpForce); //Ajoute de la force au rigibody
            nbSauts++;
        }  
    }
}
