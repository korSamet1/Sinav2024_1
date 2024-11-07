using System;
using TMPro;
using UnityEngine;

public class KarakterKontrol : MonoBehaviour
{
   

     public TMP_Text metin;
    private Rigidbody2D karakterRb;

    public float hiz = 5f;
    public float ziplamaGucu = 5f;

    public int skor = 0;

    void Start()
    {
        karakterRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        HareketEt();
        Zipla();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Engel"))
        {
            metin.text = "Oyun Bitti!";
        }
        if (other.gameObject.CompareTag("Puan"))
        {
            skor++;
            metin.text = "Skor: " + skor;
        }
    }

    void HareketEt()
    {
        if (Input.GetKey(KeyCode.A))
        {
            karakterRb.AddForce(Vector2.left * (hiz * Time.deltaTime));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            karakterRb.AddForce(Vector2.right * (hiz * Time.deltaTime));
        }
    }

    void Zipla()
    {
      
        if (Input.GetKeyDown(KeyCode.Space))
        {
            karakterRb.AddForce(Vector2.up * (ziplamaGucu / 2), ForceMode2D.Impulse);
 }
}
