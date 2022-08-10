using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemsController : MonoBehaviour
{
    public static ItemsController Instance;

    public GameObject hac;
    public int flashlight_batteries = 2;
    public ArrayList keys = new ArrayList();
    public Text key_count, battery_count;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        keys.Add("OturmaOdası");
        keys.Add("Mutfak");
        keys.Add("YemekOdası");
    }


    void FixedUpdate()
    {
        if (keys.Contains("OturmaOdasıYan") && !JumpScareController.Instance.scaryActive)
        {
            JumpScareController.Instance.jumpScareTrigger.SetActive(true);
        }

        if (keys.Contains("hac"))
        {
            Destroy(hac);
        }

        key_count.text = (keys.Count - 3).ToString();
        battery_count.text = flashlight_batteries.ToString();
    }

    public bool CanOpenDoor(string doorName) => keys.Contains(doorName);
}
