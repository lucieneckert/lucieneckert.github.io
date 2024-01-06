+++
title = "Parole in One Soundtrack"
date = 2020-05-01

[extra]
era = "May 2020"
thumbnail = "album.bmp"
tags = ["LMMS"]
+++

This is the soundtrack I designed for the [INFO/CS 3152: Introduction to Computer Game Design](http://www.cs.cornell.edu/courses/cs3152/2021sp/) course at Cornell. The central feature of the soundtrack was the ability to switch between "stealth" and "chase" themes seamlessly, depending on if a player is stealthily evading detection or being chased down. The soundtrack was produced with LMMS, using recorded samples and the built-in zynaddsubfx plugin. The tracks vary a bit on the degree to which they feel "whimsical," a metric we focused a lot on fine-tuning throughout the design of the game as a whole. Regardless, for something put together during the more tumultuous half of 2020, I'm happy with how it came out.

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
