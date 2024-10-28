## Pseudocodi:
---
```
Program Super4:
    int numChar;
    int evilness;
    string name;
    int power;
    numChar = function Bucle(1,4);
    name = function ChoseName();
    evilness = function Bucle(1000,50000);
    power = function Spell(evilness);
endProgram

Function Bucle(int min, int max):
    int num;
    do:
        Write("Write a number between "min" and "max);
        num = Read();
    while(num > max || num < min);
    return num;
endFunction

Function ChoseName():
    string name;
    do:
        name = function LenghtName(2,25);
    while(function EspecialChar(name));
    return name;
endFunction

Function LenghtName(int min,int max):
    string name;
    do:
        Write("Write a name:");
        name = Read();
    while(name.Lenght < 2 || name.Lenght > 25);
    return name;
endFunction

Function EspecialChar(string name):
    char[] bannedChar = {"@","#","-","/","_"};
    bool repeat = false;
    for each i in name do:
        for each j in bannedChar do:
            if (i == j) then
                repeat = true;
            endif
        endfor
    endfor
    return repeat;
endFunction

Function GetVocals(string name):
    char[] vocals = {"a","e","i","o","u"};
    bool success = false;
    int vocalCounter = 0;
    for each i in name do:
        for each j in vocals do:
            if (i == j) then
                vocalCounter = vocalCounter + 1;
            endif
        endfor
    endfor
    if (vocalCouif (function GetVocals(name)) then
        power = evilness/4;
        evilness = evilness%4;
    else
        power = evilness/20/4;
    endifnter >= 2) then
        success = true;
    endif
    return success;
endFunction

Function Spell(int evilness):
    int power;
    if (function GetVocals(name)) then
        power = evilness/4;
        evilness = evilness%4;
    else
        power = evilness/20/4;
    endif
    return power;
endFunction
```