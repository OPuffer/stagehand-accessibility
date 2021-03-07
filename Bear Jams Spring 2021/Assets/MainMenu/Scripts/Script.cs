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
                "Article 7 section 3 allows for a citizen filibuster. If I stand here and refuse to [verb], you are prohibited from voting on the bill. Let the filibustering begin!",
                "Herewith is my proposal for the plot of the next [film] movie.",
                "Pan down, and we are now [adjective] to the mouth of the [name] pit.",
                "After a beat, the [adjective] [body part] grabs onto the sand, and pulls himself from the maw of the sandbeast.",
                "And we realize he survived…(fade to black)…(fade back in)…Now we cut down to [location], where [character] is now consulting with [character] and it looks like they are just having a conversation about [plural nouns 1].",
                "I will not finish my speaking about [plural noun 1].",
                "But then suddenly when everyone else leaves, they [verb] into each other’s [plural body parts]."
            },
            new List<string>()
            {
                "[First name1] [last name]'s been [past tense verb] everything on a silver platter. His cushy job at his dad's [noun] company, handed to him.",
                "His 60-foot boat, [first name1]'s boat?, [past tense verb] to him when he was [number].",
                "[First name 2] [Last name 2] is running for city council too, and she's earned everything she's ever gotten. She has.",
                "[First name 1] [Last name 1] wants you to just [verb] him this election. Don't."
            },
            new List<string>()
            {
                "To be fair, you have to have a very high IQ to understand [Name1] and [Name2].", 
                "The humor is extremely [adjective], and without a solid grasp of theoretical [field of study] most of the jokes will go over a typical viewer's [body part].", 
                "There's also [Name 2]'s nihilistic outlook, which is [adverb] woven into his characterisation.",
                "The fans understand this stuff; they have the intellectual capacity to truly [verb] the depths of these [plural noun], to realize that they're not just [adjective]- they say something deep about LIFE.",
                "As a consequence, people who dislike [name1] and [name2] truly ARE [plural noun]."
            }
        },
            
        // Two puppet scripts
        new List<List<string>>
        {
            new List<string>
            {
                "Morning, [First name 1].",
                "Who are you?",
                "Who am I? I’m [First name 2]. We’ve been working together for twelve years. Ha, Weird joke, [First name 1].",
                "You’re not [First name 2]. [First name 2]’s not Asian",
                "You seriously never noticed? Hey, [clothing article] off to you for not seeing race.",
                "Alright then [First name 2]. Ahhh, why don’t you tell me about that [noun] that you [past tense verb] yesterday?",
                "Uh, [proper noun]? [Past tense verb] them [number] cases of [noun]. Or, were you talking about [proper noun]? Because I didn’t close that one yet, but I’m hoping I’ve got a voicemail waiting for me."
            },
            new List<string>()
            {
                "Puppet 1 wants puppet 2 to give her a [noun 1] and formally accept her [noun 2] into the [noun 2] club.",
                "Come on, Give me the [Noun 1]. Give it to me.",
                "Not so fast",
                "pu-put it on.",
                "We received a tip that you, [Firstname] “born and raised” [Lastname] were not born in [Location 1].",
                "What?",
                "GOTCHA! and because you [past tense verb] about it, we cannot make this a [noun 2] club selection.",
                "I was born in [Location 1], I’d stake my reputation on it. I have to tell you this feels like gotcha journalism.",
                "In what way?",
                "That way, you put “GOTCHA” on my face."
            },
        },
    };
    
    
}
