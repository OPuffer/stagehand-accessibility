using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script 
{
    
    public static  List<List<List<string>>> scripts = new List<List<List<string>>>
    {
        // One puppet scripts
        new List<List<string>>
        {
            new List<string>
            {
                "Hi I am puppet one. [noun] [-ed verb] a [adjective] [noun].",
                "This is the second line. I like [plural noun]."
            },
            new List<string>()
            {
                "This is another script for puppet one. [noun] [-ed verb] a [adjective] [noun].",
                "This is the alternate second line. I eat [food]."
            },
        },
            
        // Two puppet scripts
        new List<List<string>>
        {
            new List<string>
            {
                "Hi I am puppet one. [noun].",
                "This line should be said by the other puppet. [word].",
                "Nice this is puppet one again!"
            },
            new List<string>()
            {
                "Second two-puppet script. [noun]",
                "ehlo again [verb]",
            },
        },
    };
    
    
}
