using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawing : MonoBehaviour
{
    public GameObject linePrefab;
    public GameObject currentLine;

    public GameObject parent;

    public LineRenderer lineRenderer;
    public List<Vector2> fingerPositions;

    public List<GameObject> lines = new List<GameObject>();
    int last = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetP(GameObject p)
    {
        parent = p;
    }

    void CreateLine()
    {
        currentLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity);
        currentLine.transform.SetParent(parent.transform);
        last++;
        lines.Add(currentLine);       
        lineRenderer = currentLine.GetComponent<LineRenderer>();
        //edgeCollider = currentLine.GetComponent<EdgeCollider2D>();
        fingerPositions.Clear();
        fingerPositions.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        fingerPositions.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        lineRenderer.SetPosition(0, fingerPositions[0]);
        lineRenderer.SetPosition(1, fingerPositions[1]);
       // edgeCollider.points = fingerPositions.ToArray();
    }

    public void Undo()
    {
        if(lines.Count>0)
        {
            Destroy(lines[lines.Count - 1]);
            lines.Remove(lines[lines.Count - 1]);
            last--;
        }        
    }

    void UpdateLine(Vector2 newFingerPos)
    {
        fingerPositions.Add(newFingerPos);
        lineRenderer.positionCount++;
        lineRenderer.SetPosition(lineRenderer.positionCount - 1, newFingerPos);
        //edgeCollider.points = fingerPositions.ToArray();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CreateLine();
        }

        if (Input.GetMouseButton(0))
        {
            Vector2 tempFingerPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if(Vector2.Distance(tempFingerPos, fingerPositions[fingerPositions.Count - 1]) > 0.1f)
            {
                UpdateLine(tempFingerPos);
            }
        }
    }
}
