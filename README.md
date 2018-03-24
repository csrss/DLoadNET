# DLoad .NET [ Driver Loader ]
Application for loading windows kernel mode drivers. Written in 2009. Not supported any longer.

Note:
DLoad uses external dll for injection mode, because it is not possible to
do injection from managed code into native. External dll gets unpacked when 
"Injection" mode check box is checked, unpacked into C:\Windows. Or any 
other partition where you have windows OS installed.

Full app description:
https://www.codeproject.com/Articles/43461/Driver-Loader-DLoad-from-Scratch
