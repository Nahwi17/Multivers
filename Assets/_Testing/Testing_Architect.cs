using System.Reflection;
using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TESTING
{

public class Testing_Architect : MonoBehaviour
{
    DialogueSystem ds;
    TextArchitect architect;

    string[] lines = new string[5]
    {
        "halo nama gw wahiu arata umur 35 ",
        "gw lagi nyembuhin sakit orang orang dari virus tapi gw dibuat meninggoy ",
        "sama animator gk ngotak ini ya gkpp sih .",
        "untungnya gw masih di idupin lgi ke isekai gw pen farming waifu aja ",
        "mao buat harem sendiri .",
    };
    // Start is called before the first frame update
    void Start()
    {
        ds = DialogueSystem.instance;
        architect = new TextArchitect(ds.dialogueContainer.dialogueText);
        architect.buildMethod = TextArchitect.BuildMethod.typewriter;
        architect.speed = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        string longLine = "hamduh dudul.... hari hari makan nasi campur cabai pinggir jalan di tambah bacem rasa ban truk bekas tambang tai ikan mujaer.. mengcapek";
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (architect.isBuilding)
            {
                if (!architect.hurryUp)
                    architect.hurryUp = true;
                else 
                    architect.ForceComplete();
            }
            else
                architect.Build(longLine);
                // architect.Build(lines[Random.Range(0, lines.Length)]);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            architect.Append(longLine);
            // architect.Append(lines[Random.Range(0, lines.Length)]);
        }
        
    }
}
}