+++
title = "The Wriggling Path"
description = "Ludum Dare 56 Jam Entry"
date = 2024-10-01

[extra]
era = "October 2024"
thumbnail = "thumbnail.bmp"
tags = ["Godot Engine", "Paint.NET", "Ableton"]
play_at = "https://lucien-eckert.itch.io/the-wriggling-path"
+++

This game was a submission for Ludum Dare 56, which had the theme "Tiny Creatures." The idea here was to stick to a simple single-level platformer gameplay style, but make the world thematically and physically feel like it was composed of a bunch of small creatures. Small creatures such as:

* A root vegetable with a face that springs upwards when anything makes contact with its top side.
* A bat that suspends itself in the air until something touches it, then falls.
* A bird that becomes a bomb when it falls from any height.
* A small worm that binds two other creatures together, and can re-attach if a creature is removed.
* Flies that move in random paths, but can be herded to create small platforms.
* Just a little green worm guy that walks around randomly, for the vibes.

These creatures were designed to have one trait that interacts with the player and/or other creatures. Every "thing" in the game would have to be operationalized as a tiny creature in some way, shape, or form. Then, the bulk of the design work was to plug those tiny creatures together in interesting ways to create levels.

Most of the creatures' traits, and thus inter-creature interactions, were mediated by the Godot physics engine, rather than obeying stricter and more discrete rules. Especially under the time constraints of a game jam, this caused a *lot* of jank. The whims of the physics engine could create new paths towards success (or railroad the player towards undeserved failure), and often, the structure of the level would give way to an explosion of wriggling creatures. Which was a cool effect, if not entirely intentional or fully controllable. 

Sanctioning the abuse of the poor physics engine here was certainly a tradeoff. It allowed faster iteration on creature types, creating the sense of maximalism I wanted for the world to feel entirely composed of little dudes. It also meant that some cool organic interactions, borne from jank, were able to occur in ways that more controlled design wouldn't allow. However, the effect that the same action could have different consequences, and general tendency for the level to devolve into chaos at any time risked making the experience extremely frustrating, to say the least. To mitigate this, I devoted more time than I usually do towards playtesting, since the player experience could be so varied. I ran a few sessions out of my apartment in the hours before the deadline. Even though some frustrating situations slipped through (there's one in particular that I should've caught, but got too attached to), those sessions were vital in reducing that count down from quite a large amount.

For a game jam game especially, the best "solution" I found to the nondeterministic jank was to allow the player to reset the level state if they ever felt softlocked or disadvantaged by these interactions, quickly and with no penalty (they would return to a nearby checkpoint). This mechanic, alongside carefully-placed checkpoints, allowed for more "risky" level design that prioritized cool moments and interactions between creatures that were tricky to execute, since the player could always reset the state and try again. Given more time, I think it would have been a good idea to incorporate that reset mechanic itself into some puzzle designs. As for what could persist between resets to allow for that, I'm not sure. Perhaps a fail or soft-lock state could reveal information to the player about how the world works, that they wouldn't otherwise be expected to figure out?

As an aside, something I've been trying to work on specifically is my tolerance for ambiguity in systems. I didn't plan it at the time, but this game baked in a high proportion of ambiguity to any given player's experience of the game. The reset mechanic, checkpoint spacing, difficulty level and pacing of puzzle scenarios, etc. all had to be implemented to deal with that ambiguity.
