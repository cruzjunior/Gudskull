using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCreator : MonoBehaviour
{
    public FlexibleColorPicker fcp;
    public FlexibleColorPicker fcpEyes;
    public GameObject fcpObjectEyes;
    public FlexibleColorPicker fcpSkin;
    public GameObject fcpObjectSkin;
    //public GameObject hairColour;
    public GameObject fcpObject;

    public Sprite[] heads = new Sprite[2];
    public Sprite[] bodies = new Sprite[2];
    public Sprite[] eyes_sprite = new Sprite[2];

    public Sprite[] hairs_0 = new Sprite[3];
    public Sprite[] tops_0 = new Sprite[2];
    public Sprite[] bottoms_0 = new Sprite[2];
    public Sprite[] facialHairs_0 = new Sprite[3];
    public Sprite[] shoes_0 = new Sprite[2];

    public Sprite[] hairs_1 = new Sprite[2];
    public Sprite[] tops_1 = new Sprite[2];
    public Sprite[] bottoms_1 = new Sprite[2];
    public Sprite[] facialHairs_1 = new Sprite[2];
    public Sprite[] shoes_1 = new Sprite[2];

    int loc_head;
    int loc_body;
    int loc_hair;
    int loc_top;
    int loc_bottom;
    int loc_facialHair;
    int loc_shoe;
    int loc_eyeColour;

    public GameObject head;
    public GameObject eyes;
    public GameObject body;
    public GameObject hair;
    public GameObject facialHair;
    public GameObject top;
    public GameObject bottom;
    public GameObject shoes;

    ColorBlock cb;

    // Start is called before the first frame update
    void Start()
    {
        //cb = hairColour.GetComponent<Button>().colors;
        //cb.normalColor = fcp.color;

        loc_head = 0;
        loc_body = 0;
        loc_hair = 0;
        loc_top = 0;
        loc_bottom = 0;
        loc_facialHair = 0;
        loc_shoe = 0;
    }

    public void SaveCharacter()
    {
        PlayerPrefs.SetInt("head", loc_head);
        PlayerPrefs.SetInt("body", loc_body);
        PlayerPrefs.SetInt("hair", loc_hair);
        PlayerPrefs.SetInt("top", loc_top);
        PlayerPrefs.SetInt("bottom", loc_bottom);
        PlayerPrefs.SetInt("facialHair", loc_facialHair);
        PlayerPrefs.SetInt("shoe", loc_shoe);
        PlayerPrefs.SetString("skin", fcp.GetComponent<FlexibleColorPicker>().hexInput.text);
        PlayerPrefs.SetString("eyeColour", fcpEyes.GetComponent<FlexibleColorPicker>().hexInput.text);
        PlayerPrefs.SetString("hairColour", fcpSkin.GetComponent<FlexibleColorPicker>().hexInput.text);
    }

    public void SpawnPlayer()
    {
        loc_head = PlayerPrefs.GetInt("head");
        loc_body = PlayerPrefs.GetInt("body");
        loc_hair = PlayerPrefs.GetInt("hair");
        loc_top = PlayerPrefs.GetInt("top");
        loc_bottom = PlayerPrefs.GetInt("bottom");
        loc_facialHair = PlayerPrefs.GetInt("facialHair");
        loc_shoe = PlayerPrefs.GetInt("shoe");

        fcp.GetComponent<FlexibleColorPicker>().hexInput.text = PlayerPrefs.GetString("skin");
        fcpEyes.GetComponent<FlexibleColorPicker>().hexInput.text = PlayerPrefs.GetString("eyeColour");
        fcpSkin.GetComponent<FlexibleColorPicker>().hexInput.text = PlayerPrefs.GetString("hairColour");



        switch (loc_body)
        {
            case 0:
                top.GetComponent<Image>().sprite = tops_0[loc_top];
                bottom.GetComponent<Image>().sprite = bottoms_0[loc_bottom];
                shoes.GetComponent<Image>().sprite = shoes_0[loc_shoe];
                break;
            case 1:
                top.GetComponent<Image>().sprite = tops_1[loc_top];
                bottom.GetComponent<Image>().sprite = bottoms_1[loc_bottom];
                shoes.GetComponent<Image>().sprite = shoes_1[loc_shoe];
                break;
        }

        switch (loc_head)
        {
            case 0:
                facialHair.GetComponent<Image>().sprite = facialHairs_0[loc_facialHair];
                hair.GetComponent<Image>().sprite = hairs_0[loc_hair];
                eyes.GetComponent<Image>().sprite = eyes_sprite[loc_head];
                break;
            case 1:
                facialHair.GetComponent<Image>().sprite = facialHairs_1[loc_facialHair];
                hair.GetComponent<Image>().sprite = hairs_1[loc_hair];
                eyes.GetComponent<Image>().sprite = eyes_sprite[loc_head];
                break;
        }
    }

    public void open_hair_colour()
    {
        fcpObject.SetActive(true);
    }

    public void close_hair_color()
    {
        fcpObject.SetActive(false);
    }

    public void eye_colour_open()
    {
        fcpObjectEyes.SetActive(true);
    }

    public void eye_colour_close()
    {
        fcpObjectEyes.SetActive(false);
    }

    public void open_skin()
    {
        fcpObjectSkin.SetActive(true);
    }

    public void close_skin()
    {
        fcpObjectSkin.SetActive(false);
    }

    public void head_shape_forward()
    {
        if(loc_head == heads.Length - 1)
        {
            loc_head = 0;
        }
        else
        {
            loc_head++;
        }
        head.GetComponent<Image>().sprite = heads[loc_head];
        change_head_components();
    }

    public void head_shape_back()
    {
        if (loc_head == 0)
        {
            loc_head = heads.Length - 1;
        }
        else
        {
            loc_head--;
        }
        head.GetComponent<Image>().sprite = heads[loc_head];
        change_head_components();
    }

    public void body_forward()
    {
        if (loc_body == bodies.Length - 1)
        {
            loc_body = 0;
        }
        else
        {
            loc_body++;
        }
        body.GetComponent<Image>().sprite = bodies[loc_body];
        change_body_components();
    }

    public void body_back()
    {
        if (loc_body == 0)
        {
            loc_body = bodies.Length - 1;
        }
        else
        {
            loc_body--;
        }
        body.GetComponent<Image>().sprite = bodies[loc_body];
        change_body_components();
    }

    public void hair_forward()
    {
        if (loc_hair == 2)
        {
            loc_hair = 0;
        }
        else
        {
            loc_hair++;
        }

        if (loc_hair == 2)
        {
            hair.GetComponent<Image>().enabled = false;
        }

        else
        {
            hair.GetComponent<Image>().enabled = true;
            switch (loc_head)
            {
                case 0:
                    hair.GetComponent<Image>().sprite = hairs_0[loc_hair];
                    break;
                case 1:
                    hair.GetComponent<Image>().sprite = hairs_1[loc_hair];
                    break;
            }
        }

    }

    public void hair_back()
    {
        if (loc_hair == 0)
        {
            loc_hair = 2;
        }
        else
        {
            loc_hair--;
        }

        if (loc_hair == 2)
        {
            hair.GetComponent<Image>().enabled = false;
        }

        else
        {
            hair.GetComponent<Image>().enabled = true;
            switch (loc_head)
            {
                case 0:
                    hair.GetComponent<Image>().sprite = hairs_0[loc_hair];
                    break;
                case 1:
                    hair.GetComponent<Image>().sprite = hairs_1[loc_hair];
                    break;
            }
        }
    }

    public void facial_forward()
    {
        if (loc_facialHair == 2)
        {
            loc_facialHair = 0;
        }
        else
        {
            loc_facialHair++;
        }

        if(loc_facialHair == 2)
        {
            facialHair.GetComponent<Image>().enabled = false;
        }

        else
        {
            facialHair.GetComponent<Image>().enabled = true;
            switch (loc_head)
            {
                case 0:
                    facialHair.GetComponent<Image>().sprite = facialHairs_0[loc_facialHair];
                    break;
                case 1:
                    facialHair.GetComponent<Image>().sprite = facialHairs_1[loc_facialHair];
                    break;
            }
        }
        

    }

    public void facial_back()
    {
        if (loc_facialHair == 0)
        {
            loc_facialHair = 2;
        }
        else
        {
            loc_facialHair--;
        }

        if (loc_facialHair == 2)
        {
            facialHair.GetComponent<Image>().enabled = false;
        }

        else
        {
            facialHair.GetComponent<Image>().enabled = true;
            switch (loc_head)
            {
                case 0:
                    facialHair.GetComponent<Image>().sprite = facialHairs_0[loc_facialHair];
                    break;
                case 1:
                    facialHair.GetComponent<Image>().sprite = facialHairs_1[loc_facialHair];
                    break;
            }
        }

    }

    public void top_forward()
    {
        if (loc_top == heads.Length - 1)
        {
            loc_top = 0;
        }
        else
        {
            loc_top++;
        }

        switch (loc_body)
        {
            case 0:
                top.GetComponent<Image>().sprite = tops_0[loc_top];
                break;
            case 1:
                top.GetComponent<Image>().sprite = tops_1[loc_top];
                break;
        }

    }

    public void top_back()
    {
        if (loc_top == 0)
        {
            loc_top = heads.Length - 1;
        }
        else
        {
            loc_top--;
        }

        switch (loc_body)
        {
            case 0:
                top.GetComponent<Image>().sprite = tops_0[loc_top];
                break;
            case 1:
                top.GetComponent<Image>().sprite = tops_1[loc_top];
                break;
        }

    }

    public void bottom_forward()
    {
        if (loc_bottom == heads.Length - 1)
        {
            loc_bottom = 0;
        }
        else
        {
            loc_bottom++;
        }

        switch (loc_body)
        {
            case 0:
                bottom.GetComponent<Image>().sprite = bottoms_0[loc_bottom];
                break;
            case 1:
                bottom.GetComponent<Image>().sprite = bottoms_1[loc_bottom];
                break;
        }

    }

    public void bottom_back()
    {
        if (loc_bottom == 0)
        {
            loc_bottom = heads.Length - 1;
        }
        else
        {
            loc_bottom--;
        }

        switch (loc_body)
        {
            case 0:
                bottom.GetComponent<Image>().sprite = bottoms_0[loc_bottom];
                break;
            case 1:
                bottom.GetComponent<Image>().sprite = bottoms_1[loc_bottom];
                break;
        }

    }

    public void shoes_forward()
    {
        if (loc_shoe == heads.Length - 1)
        {
            loc_shoe = 0;
        }
        else
        {
            loc_shoe++;
        }

        switch (loc_body)
        {
            case 0:
                shoes.GetComponent<Image>().sprite = shoes_0[loc_shoe];
                break;
            case 1:
                shoes.GetComponent<Image>().sprite = shoes_1[loc_shoe];
                break;
        }

    }

    public void shoes_back()
    {
        if (loc_shoe == 0)
        {
            loc_shoe = heads.Length - 1;
        }
        else
        {
            loc_shoe--;
        }

        switch (loc_body)
        {
            case 0:
                shoes.GetComponent<Image>().sprite = shoes_0[loc_shoe];
                break;
            case 1:
                shoes.GetComponent<Image>().sprite = shoes_1[loc_shoe];
                break;
        }

    }

    void change_head_components()
    {
        switch(loc_head)
        {
            case 0:
                facialHair.GetComponent<Image>().sprite = facialHairs_0[loc_facialHair];
                hair.GetComponent<Image>().sprite = hairs_0[loc_hair];
                eyes.GetComponent<Image>().sprite = eyes_sprite[loc_head];
                break;
            case 1:
                facialHair.GetComponent<Image>().sprite = facialHairs_1[loc_facialHair];
                hair.GetComponent<Image>().sprite = hairs_1[loc_hair];
                eyes.GetComponent<Image>().sprite = eyes_sprite[loc_head];
                break;
        }
    }

    void change_body_components()
    {
        switch (loc_body)
        {
            case 0:
                top.GetComponent<Image>().sprite = tops_0[loc_top];
                bottom.GetComponent<Image>().sprite = bottoms_0[loc_bottom];
                shoes.GetComponent<Image>().sprite = shoes_0[loc_shoe];
                break;
            case 1:
                top.GetComponent<Image>().sprite = tops_1[loc_top];
                bottom.GetComponent<Image>().sprite = bottoms_1[loc_bottom];
                shoes.GetComponent<Image>().sprite = shoes_1[loc_shoe];
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        hair.GetComponent<Image>().color = fcp.color;
        facialHair.GetComponent<Image>().color = fcp.color;
        cb.normalColor = fcp.color;

        eyes.GetComponent<Image>().color = fcpEyes.color;
        body.GetComponent<Image>().color = fcpSkin.color;
        head.GetComponent<Image>().color = fcpSkin.color;
    }
}
