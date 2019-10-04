using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Top_kontrol : MonoBehaviour
{
    Rigidbody fizik;            //içerisindeki force fonksiyonunu kullanabilmek için oluşturuldu. Heryerde ulaşmak için dışarıda oluşturuldu.

    public int hiz;             //default değerlerle çok yavaş hareket ettiği için oluşturuldu.

    int puan = 0;               //oyunda topladığımız puan değişkeni.

    int toplanicak_nesne_sayisi = 8;     //oyunun kaç nesne toplandıktan sonra biteceği.

    public Text puan_text;      //UI ekranında topladığımız puanı yazdıracak yazı.
    public Text bitis_text;     //UI ekranında oyun bittiğinde yazılacak yazı.

    void Start()
    {
        fizik = GetComponent<Rigidbody>();          //içerisindeki force fonksiyonunu kullanabilmek için oluşturuldu.

    }


    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");       //nesnenin yatay eksenine erişmek için kullanılır.
        float dikey = Input.GetAxisRaw("Vertical");         //nesnenin dikey eksenine ulaşmak için kullanılır.

        Vector3 hareket = new Vector3(yatay, 0, dikey);     //nesneyi hareket ettirmek için oluşturulan nesne.

        fizik.AddForce(hareket * hiz);     //hareket için gerekli gücü sağlar. parametre olarak vector3 alır. o yüzden vector3 ten hareket nesnesi oluşturduk.

    }

    void OnTriggerEnter(Collider other)     //is trigger özelliği açık nesneler için kullanılır. il temasta çalışır.
    {
        if (other.gameObject.tag == "engel")    //diğer nesnelerden ayırmak için "engel" diye tag ekledik ve bunu kontrol ediyoruz.
        {
//            Destroy(other.gameObject);      //çarpışılan nesneyi yok etmek için kullanılan fonksiyon
            other.gameObject.SetActive(false);  //çarpışılan nesneyi kapatan fonksiyon

            puan += 10;     //her çarpışmadan sonra 10 puan eklenicek.

            puan_text.text = "PUAN = " + puan;      //UI de puan yerine yazılacak yazı.
        }

        if (toplanicak_nesne_sayisi == (puan / 10))     //oyunun bitmesi için kaç nesnenin toplandığının kontrolü.
        {
            bitis_text.text = "OYUN BITTI";     //oyun bitince UI ekranında yazacak olan yazı.
        }
    }


}
