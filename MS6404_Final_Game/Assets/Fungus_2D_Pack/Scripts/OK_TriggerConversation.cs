using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
//using UnityStandardAssets.Characters.FirstPerson;

public class OK_TriggerConversation : MonoBehaviour
{

    // Variables

    // These private variables are set within the start and are used to control the player character when they enter the trigger box.
    private GameObject GO_Player;
    public bool bl_Toggle;
    private Rigidbody2D rb_player;

    // This public variable is for setting the flowchart. You should be able to set the flowchart per trigger in the editor.
    public Flowchart fc_NPCDialog;
    public string st_MessageReciever;

    // Use this for initialization
    void Start()
    {
        // Game Objects and components are found so that we can reference them later in the script.
        GO_Player = GameObject.FindGameObjectWithTag("Player");
        rb_player = GO_Player.GetComponent<Rigidbody2D>();

        // We need to set the image and flowchart to false so that we can activate them when the player enters the trigger.

        fc_NPCDialog.gameObject.SetActive(false);

        bl_Toggle = false;


    }

    //This void 
    private void OnTriggerStay2D(Collider2D cl_trigger)
    {
        if (cl_trigger.gameObject.tag == "Player")
        {

            if (Input.GetKeyDown(KeyCode.E) && bl_Toggle == false)
            {
                fc_NPCDialog.gameObject.SetActive(true);
                fc_NPCDialog.SendFungusMessage(st_MessageReciever);
                rb_player.isKinematic = true;
                bl_Toggle = true;

            }
            else if (Input.GetKeyDown(KeyCode.E) && bl_Toggle == true)
            {
                rb_player.isKinematic = false;
                fc_NPCDialog.gameObject.SetActive(false);
                bl_Toggle = false;
            }
        }
    }

    public void RBEnable()
    {

        rb_player.isKinematic = false;
    }


}
