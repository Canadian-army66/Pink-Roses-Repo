using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Import TextMeshPro namespace

public class npc2 : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText; // Use TextMeshProUGUI for UI text
    public string[] dialogue;
    private int index;
    private int brainDamage;
    public string batteryText;

    public float worldSpeed;
    public bool playerIsClose;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose && brainDamage < 20)
        {
            if (dialoguePanel.activeInHierarchy)
            {
                zeroText();
            }
            else
            {
                dialoguePanel.SetActive(true);
                StartCoroutine(Typing());
            }

            brainDamage++;
        }
        if (brainDamage >= 20 && playerIsClose)
        {
            StopAllCoroutines();
            dialogueText.text = batteryText;
            dialoguePanel.SetActive(true);
        }
        if (playerIsClose == false)
        {
            dialoguePanel.SetActive(false);
        }
    }

    public void zeroText()
    {
        dialogueText.text = "";
        index = 0;
        dialoguePanel.SetActive(false);
    }

    IEnumerator Typing()
    {
        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(worldSpeed);
        }
        yield return new WaitForSeconds(2);
        NextLine();
    }

    public void NextLine()
    {
        if (index < dialogue.Length - 1)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            zeroText();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
            zeroText();
        }
        else
        {
            playerIsClose = false;
        }
    }
}