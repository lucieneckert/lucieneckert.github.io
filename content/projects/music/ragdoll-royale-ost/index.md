+++
title = "Ragdoll Royale Soundtrack"
date = 2022-05-01

[extra]
era = "May 2022"
thumbnail = "album.bmp"
tags = ["Ableton"]
+++

This is the soundtrack for Ragdoll Royale. Each background track comes in a "quiet" and "chaotic" variant -- each playing during either the drawing or simulating phase of a player's turn in the game. As one central theme of our game is the contrast between the careful drawing and planning of one phase versus the more intense and vaguely-predictable shenanigans of the other, the music was designed to reflect this. I also tried to incorporate the same motif (mostly subtly) into each of the tracks and emphasized a theremin-esque leading instrument to keep things cohesive and "spooooky."

{% soundtrack(cover_path="album.bmp") %}
{{ audio(src="menutheme.ogg", label="Menu Theme") }}
{{ audio(src="battletheme1-quiet.ogg", label="Indoor Battle Theme (Quiet)") }}
{{ audio(src="battletheme1.ogg", label="Indoor Battle Theme (Chaotic)") }}
{{ audio(src="battletheme2-quiet.ogg", label="Caves Battle Theme (Quiet)") }}
{{ audio(src="battletheme2.ogg", label="Caves Battle Theme (Chaotic)") }}
{{ audio(src="battletheme3-quiet.ogg", label="Rooftop Battle Theme (Quiet)") }}
{{ audio(src="battletheme3.ogg", label="Rooftop Battle Theme (Chaotic)") }}
{% end %}
