using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FireTrap : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    private bool daRoi = false;
    public Transform diemKhoiPhuc;
    public GameObject explosion;
    public int lifes;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")&&!daRoi)
        {
            rb.isKinematic = false;
            daRoi = true;
            Invoke("KhoiPhuc", 2f);
        }    
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            
            Destroy(collision.gameObject);
            lifes--;
            if (lifes <= 0)
            {
                Destroy(gameObject);
                Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 1.2f);
            }
        }
    }
    IEnumerator DelayedEvents(System.Action ev, float time)
    {
        yield return new WaitForSeconds(time);
        ev();
    }
    private void KhoiPhuc()
    {
        rb.isKinematic=true;
        rb.velocity = Vector2.zero;
        rb.angularDrag = 0;
        transform.position = diemKhoiPhuc.position;
        daRoi=false;
    }
}
