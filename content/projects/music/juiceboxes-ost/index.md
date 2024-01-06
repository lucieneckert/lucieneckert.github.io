+++
title = "A Small Game About Juiceboxes Soundtrack"
date = 2020-09-01

[extra]
era = "September 2020"
thumbnail = "album.bmp"
tags = ["LMMS"]
+++

This is the soundtrack for the first full game I worked on completely solo. Due to the fact the game was mostly meant as an experiment in honing game feel, I tried to make the music primarily an arcade-y sounding accompaniment to gameplay -- with enough variation that it didn't get old too quick. To accomplish this, I experimented with a variety of different plugins in LMMS and worked to create an upbeat yet otherwordly vibe, to encourage the player but also reflect the strangeness of the sort of non-setting the game takes place in. In composing the background music for the progressively more difficult sets of levels within the game, I tried to increase the "intensity" of the music through added sound effects, a faster pace, and fuller chords -- especially for the final level theme. For the multiplayer mode background music, I tried to add a more driving, competitive feeling with heavier drums and chords.

{% soundtrack(cover_path="album.bmp") %}
{{ audio(src="jb_01.ogg", label="Early Levels BGM") }}
{{ audio(src="jb_02.ogg", label="Midgame Levels BGM") }}
{{ audio(src="jb_03.ogg", label="Lategame Levels BGM") }}
{{ audio(src="jb_04.ogg", label="Final Level BGM") }}
{{ audio(src="jb_05.ogg", label="Multiplayer Mode BGM") }}
{{ audio(src="jb_06.ogg", label="Menu BGM") }}
{% end %}
