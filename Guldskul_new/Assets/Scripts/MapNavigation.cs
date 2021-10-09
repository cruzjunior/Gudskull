using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MapNavigation : MonoBehaviour
{
    public GameObject character;
    public List <GameObject> questions;
    public GameObject[] options;
    public Animator anim;
    private int pos = 0;
    public GameObject continueB;
    public GameObject backButton;

    private GameObject[] visited = new GameObject[20];
    int last = 0;
    private AnimationClip back;
    private AnimationClip[] animStack = new AnimationClip[20];
    private int animLast = -1;

    // Start is called before the first frame update
    void Start()
    {
        OptionsAvailable();
        visited[0] = questions[0];
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void moveBack()
    {
        anim.Play(animStack[animLast].name);
        animLast--;
        if (questions.Contains(visited[last]))
        {
            pos--;
        }
        character.gameObject.GetComponent<RectTransform>().anchoredPosition = visited[last-1].gameObject.GetComponent<RectTransform>().anchoredPosition;
        last--;
        OptionsAvailable();
    }

    public void next(GameObject next, AnimationClip ani, AnimationClip backAnim)
    {
        character.gameObject.GetComponent<RectTransform>().anchoredPosition = next.gameObject.GetComponent<RectTransform>().anchoredPosition;
        addToStack(next);
        if(ani != null)
        {
            anim.Play(ani.name);
            animLast++;
            animStack[animLast] = backAnim;
            
        }
        if (questions.Contains(next))
        {
            pos++;
        }
        OptionsAvailable();

        if(next.name == "Outcome1" || next.name == "Outcome1" || next.name == "5a_input" || next.name == "5b_input")
        {
            for (int i = 0; i < options.Length; i++)
            {
                options[i].GetComponent<Button>().enabled = false;
            }
        }
    }

    public void continueOn()
    {
        character.gameObject.GetComponent<RectTransform>().anchoredPosition = visited[last].GetComponent<ChoiceOutcome>().next.gameObject.GetComponent<RectTransform>().anchoredPosition;
        

        anim.Play(visited[last].GetComponent<ChoiceOutcome>().anim.name);
        animLast++;
        animStack[animLast] = visited[last].GetComponent<ChoiceOutcome>().backAnim;
        

        if (questions.Contains(visited[last].GetComponent<ChoiceOutcome>().next))
        {
            pos++;
        }

        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Button>().enabled = false;
        }

        if (visited[last].name == "5_input")
        {
            options[10].GetComponent<Button>().enabled = true;
            options[11].GetComponent<Button>().enabled = true;
        }

        addToStack(visited[last].GetComponent<ChoiceOutcome>().next);
        
    }

    void addToStack(GameObject cur)
    {
        last++;
        visited[last] = cur;
    }

    void OptionsAvailable()
    {
        for(int i = 0; i < options.Length; i++)
        {
            if(i == pos * 2 || (i == pos * 2 + 1 && pos * 2 + 1 != options.Length))
            {
                options[i].GetComponent<Button>().enabled = true;

            }
            else
            {
                options[i].GetComponent<Button>().enabled = false;
            }         
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(visited[last].name == questions[0].name)
        {
            backButton.SetActive(false);
        }
        else
        {
            backButton.SetActive(true);
        }

        if(visited[last].name == "5_input" || visited[last].name == "5a_input" || visited[last].name == "5b_input")
        {
            continueB.SetActive(true);
        }
        else
        {
            continueB.SetActive(false);
        }
    }
}
