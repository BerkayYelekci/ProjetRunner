using UnityEngine;

public class CollectFish : MonoBehaviour
{
    private Animator anim;
    private void Start()
    {
        anim = GetComponentInParent<Animator>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            PickupFish();
    }
    private void PickupFish()
    {
        anim?.SetTrigger("Pickup");
        GameStat.Instance.CollectFish();
    }

    public void OnShowChunk()
    {
        anim?.SetTrigger("Idle");
    }

}
