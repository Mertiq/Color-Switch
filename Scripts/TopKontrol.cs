using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour
{
    public string renk;
    float ziplamaKuvveti = 7f;
    public Color turkuaz;
    public Color pembe;
    public Color sari;
    public Color mor;
    public Text skoryazisi;
    public static int skor = 0;
    public GameObject cember;
    public GameObject renkTekeri;

    // Start is called before the first frame update
    void Start()
    {
        rastgeleRenk();
        skor = 0;
        skoryazisi.text = skor.ToString();
        GetComponent<Rigidbody2D>().gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().gravityScale = 2;
            GetComponent<Rigidbody2D>().velocity = Vector2.up * ziplamaKuvveti;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "skorArttir")
        {
            skor += 1;
            skoryazisi.text = skor.ToString();
            Instantiate(cember, new Vector3(transform.position.x, transform.position.y + 10f, transform.position.z), transform.rotation);
            Destroy(collision.gameObject);
        }
        if (collision.tag == "RenkTekeri")
        {
            rastgeleRenk();
            Destroy(collision.gameObject);
            Instantiate(renkTekeri, new Vector3(transform.position.x, transform.position.y + 10f, transform.position.z), transform.rotation);
            return;
        }
        if (collision.tag != renk && collision.tag != "skorArttir" || collision.tag == "engel")
        {
            SceneManager.LoadScene(1);
            
        }
        
        
    }

    void rastgeleRenk()
    {
        int rastgeleSayi = Random.Range(0, 4);

        switch (rastgeleSayi)
        {
            case 0:
                renk = "Turkuaz";
                GetComponent<SpriteRenderer>().color = turkuaz;
                break;
            case 1:
                renk = "Sari";
                GetComponent<SpriteRenderer>().color = sari;
                break;
            case 2:
                renk = "Pembe";
                GetComponent<SpriteRenderer>().color = pembe;
                break;
            case 3:
                renk = "Mor";
                GetComponent<SpriteRenderer>().color = mor;   
                break;

        }
    }
}
