# Animation Serializer

this program can be used to create & serialize AnimationSet objects into JSON strings. These strings can then be stored in a database field for later use. 

## Quick Start Guide

1. Once program is opened, select desired animation radio button in the top left.
2. Enter animation images in frames 0 through 3.
3. Select `Save Entry` to store entered frames as selected animation. Progress bars next to each animation option will update to display status of entered animations.
4. For remaining animations, repeat steps 1 though 3, selecting the appropriate radio button for each animation. Note that only 3rd tier monsters will have a dance 
animation, for all others `Dance` can be left blank. 
5. Once all desired animations have been saved & their status is complete (progress bars should be full for all entered animations), select `Serialize Animation` to
serialize saved data to a JSON string. Output string will be displayed in a textbox at the bottom of the window.
6. Select `Copy to Clipboard` to copy output string to clipboard for easy use.
