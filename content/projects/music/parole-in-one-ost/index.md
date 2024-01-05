+++
title = "Parole in One Soundtrack"
date = 2020-05-01

[extra]
era = "May 2020"
thumbnail = "album.bmp"
tags = ["LMMS"]
+++

This is the soundtrack I designed for the [INFO 3152: Introduction to Computer Game Design](http://www.cs.cornell.edu/courses/cs3152/2021sp/) course at Cornell. The central feature of the soundtrack was the ability to switch between "stealth" and "chase" themes seamlessly when a player is either evading detection or being spotted or chased. The soundtrack was produced with LMMS, using recorded samples and the built-in zynaddsubfx plugin.

{% soundtrack(cover_path="album.bmp") %}
{{ audio(src="pio_03.ogg", label="Menu BGM") }}
{{ audio(src="pio_01.ogg", label="Panopticon Par-ade (Stealth)") }}
{{ audio(src="pio_02.ogg", label="Panopticon Par-ade (Chase)") }}
{{ audio(src="pio_07.ogg", label="Putt by Putt (Stealth)") }}
{{ audio(src="pio_06.ogg", label="Putt by Putt (Chase)") }}
{{ audio(src="pio_05.ogg", label="Downswing Detainment (Stealth)") }}
{{ audio(src="pio_04.ogg", label="Downswing Detainment (Chase)") }}
{{ audio(src="pio_08.ogg", label="Panopticon De-par-ture (Stealth)") }}
{{ audio(src="pio_09.ogg", label="Panopticon De-par-ture (Chase)") }}
{% end %}
