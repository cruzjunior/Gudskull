using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;
using UnityEngine.UI;

public class TextFieldGathering : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TMP_InputField yearInput;
    public TMP_InputField reasonInput;
    public TMP_InputField userReasonInput;
    public TMP_InputField userNameInput;
    public TMP_InputField collectiveNameInput;

    public TMP_InputField outcomeOneIn;
    public TMP_InputField outcomeTwoIn;
    public TMP_InputField dosIn;
    public TMP_InputField dontsIn;
    public TMP_InputField percentageIn;
    public TMP_InputField dreamIn;

    string collName;
    string collYear;
    string collReason;
    string userReason;
    string userName;
    string collectivename;

    string outcomeOne;
    string outcomeTwo;
    string dos;
    string donts;
    string percentage;
    string dream;

    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSe_5OKzP_u1m6qSa3wJD5c10fyYSFj4XwhQ7_d1WfCvJPb74Q/formResponse";

    public void Send()
    {
        StartCoroutine(Post(userName, collName, collYear, collReason, userReason));
    }

    IEnumerator Post(string n, string cn, string cy, string yc, string yj)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.53033366", n);
        form.AddField("entry.774206249", cn);
        form.AddField("entry.1914226535", cy);
        form.AddField("entry.1729826946", yc);
        form.AddField("entry.933474958", yj);

        UnityWebRequest www = UnityWebRequest.Post(URL, form);

        yield return www.SendWebRequest();
    }

    public void save()
    {
        outcomeOne = outcomeOneIn.text;
        outcomeTwo = outcomeTwoIn.text;
        dos = dosIn.text;
        donts = dontsIn.text;
        percentage = percentageIn.text;
        dream = dreamIn.text;
    }
    
    public void saveInfo_one()
    {
        collName = nameInput.text;
        collYear = yearInput.text;
        collReason = reasonInput.text;

        Debug.Log(collName + " " + collReason + " " + collYear);
    }

    public void saveInfo_two()
    {
        userReason = userReasonInput.text;
    }

    public void name_collective()
    {
        userName = userNameInput.text;
        collectivename = collectiveNameInput.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
