using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class jump : MonoBehaviour
{
    private int nbSauts;
    [SerializeField]
    private int maxSauts;
    [SerializeField]
    Rigidbody rb;
    [SerializeField]
    private int jumpForce;
    [SerializeField]
    private int layer;


    private void Start()
    {
        if(rb == null)
        {
            Debug.LogError("Aucun rigidbody");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(layer == collision.gameObject.layer) //Pour détecter le layer du sol et valider la condition
        {
            nbSauts = 0;
        }
    }
    private void Update()
    {
        if (Input.GetButtonDown("Jump") && nbSauts < maxSauts) //Récupère l'input du saut et vérifie le nombre de sauts restants
        {
            rb.AddForce(transform.up * jumpForce); //Ajoute de la force au rigibody
            nbSauts = nbSauts + 1;
        }
    }
}