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
        if (layer != collision.gameObject.layer) return; //Pour d�tecter le layer du sol et valider la condition
            nbSauts = 0;
    }
    private void Update()
    {
        if (Input.GetButtonDown("Jump") && nbSauts < maxSauts) //R�cup�re l'input du saut et v�rifie le nombre de sauts restants
        {
            rb.AddForce(transform.up * jumpForce); //Ajoute de la force au rigibody
            nbSauts++;
        }
    }
}