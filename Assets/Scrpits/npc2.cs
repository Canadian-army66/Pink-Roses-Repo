using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPC2 : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText;
    public string[] dialogue;
    public Sprite deathImg;
    private int index;
    private Animator mAnimator;
    private int brainDamage;

    public float worldSpeed;
    public bool playerIsClose;

    void Start()
    {
        mAnimator = GetComponent<Animator>();
        mAnimator.SetBool("isDead", false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose && brainDamage < 20)
        {
            if (dialoguePanel.activeInHierarchy)
            {
                ZeroText();
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
            dialoguePanel.SetActive(false);
            mAnimator.SetBool("isDead", true);
            transform.localScale = new Vector3(0.11f, 0.11f, 1f);
        }

        if (mAnimator != null)
        {
            if (dialoguePanel.activeInHierarchy)
            {
                mAnimator.SetBool("isTalking", true);
            }
            else
            {
                mAnimator.SetBool("isTalking", false);
            }
        }
    }

    public void ZeroText()
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
            ZeroText();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
            ZeroText();
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
            ZeroText();
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.forward * 500);
    }
}