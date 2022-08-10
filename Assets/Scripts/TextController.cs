using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextController : MonoBehaviour
{
    public static TextController Instance;


    public GameObject text;

    string[] texts = {
        //Dışardaki ışığın altındaki metin
        "Yabancı - Bu ormanda garip şeyler dönüyor. Etrafta bazen bebek sesleri ve bir kadının ağlama sesleri geliyor. Çok korkuyorum. Bir an önce burayı terk etmem lazım.",
        //OturmaOdasındaki metin
        "Aldis karnımdaki çocuğu hiç istemiyor gibi. Onu en son yatak odamızın yanındaki odada dua ederken gördüm. Çocuk hakkında bir şeyler söylüyordu.",
        //AyinOdasıKiler metin
        "Bebeğim Maira doğduktan sonra Aldis iyice dua ettiği odaya kapandı ve odadan hiç çıkmıyordu. Maira'nın lanetli olduğunu düşünüyor ve ona yaklaşmıyordu. Maira'ya zarar vermesinden korkuyorum...", 
        //OturmaOdasıYan metin
        "Aldis'in bu son yaptıklarından sonra onu asla affetmeyeceğim. İçimden sürekli olarak ona nefret beslemekten başka bir şey gelmiyor. Maira'ya yaptıklarından sonra hızlıca bodrum katına doğru koştu... ",
        //Bodrum metin
        "Lanet olsun! Aldis kendisini öldürmüş. Elinde bir not var. 'Maira'ya yaptıklarım için çok pişmanım. Onu bacaklarındaki kemiksizlikten dolayı lanetlenmiş sandım. İçimdeki bir ses bu lanetin bize musallat olacağını ve hayatımızı berbat edeceği fikrini aklıma kazıdı ve bir anlık kararla bunu yaptım. Kendimi affetmeyeceğim...'. Daha sonra kendimi bu aptal mesaj karşısında kendimi kaybettim ve o dua ettiği odaya doğru çıktım...",
        //Ayin odası metin
        "Aldis'in bu odada neden bu kadar uzun dua ettiğini biraz anladım. Odada kötü bir aura vardı. Dua ettiği masanın çekmecesine yaklaştıkça kötü his giderek artıyordu. Çekmeceyi açtığımda ise değişik bir nesne karşıma çıktı. Onu yok etmem için bodruma gidecektim fakat bir anda ...",
        };    

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && text.activeSelf)
        {
            text.gameObject.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            MouseLook.Instance.enabled = true;
            PlayerMove.Instance.enabled = true;
        }
    }

    public void showText(GameObject gameObject)
    {
        text.GetComponentInChildren<TextMeshProUGUI>().text = texts[int.Parse(gameObject.name.Substring(9))];
        text.gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        MouseLook.Instance.enabled = false;
        PlayerMove.Instance.enabled = false;
    }
}
