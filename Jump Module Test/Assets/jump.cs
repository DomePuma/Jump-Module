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
    private void Update()
    {
        if (Input.GetButtonDown("Jump") && nbSauts < maxSauts) //Récupère l'input du saut et vérifie le nombre de sauts restants
        {
            rb.AddForce(transform.up * jumpForce); //Ajoute de la force au rigibody
            nbSauts++;
        }
    }
}