\# Calculator Baze Numerice



A desktop number base converter built with C# and Windows Forms. The user types a number and switches between base 10, base 2 and base 16; the value on the display is converted on the spot, and the keypad changes to show only the digits that are valid in the selected base.



The project was meant as a practical exercise in event-driven GUI programming.



\## Preparation



\* Install Visual Studio (with the .NET desktop development workload)

\* Clone the repository and open the `.sln` file



\## Features (current)



\* Three number bases, selected with radio buttons: `baza 10`, `baza 2`, `baza 16`

\* Live conversion of the displayed value when the base changes

\* Dynamic keypad that only shows valid digits:

&#x20; \* Base 2: `0` and `1`

&#x20; \* Base 10: `0-9`

&#x20; \* Base 16: `0-9` and `A-F`

\* `Delete` (removes the last character) and `Clear` (resets the display to `0`)



\## How it works



The display (`ResultBox`) is a text box that holds the number currently being typed. The current base is stored in the static field `unit.baza\_curenta`.



1\. Each digit button appends its character to `ResultBox.Text`. If the display shows `"0"`, the digit replaces it, so numbers do not start with a leading zero.

2\. The buttons `2-9` and `A-F` are created in code, stored in the array `btn\[]` and added or removed with `Controls.Add()` / `Controls.Remove()` when the base changes.

3\. Each `RadioButton` has a `CheckedChanged` handler. It reads `unit.baza\_curenta` to know the source base, adapts the keypad, converts the value and then updates `unit.baza\_curenta`.



\## Requirements



\* Windows

\* Visual Studio 2022 (or any IDE that can build Windows Forms projects)

\* No external dependencies (only `System` and `System.Windows.Forms`)



\## Usage



1\. Open the solution in Visual Studio.

2\. Press Run.

3\. Type a number using the on-screen buttons.

4\. Select another base to see the value converted.



\## What I learned



\* Building a Windows Forms GUI and handling events (`Button.Click`, `RadioButton.CheckedChanged`)

\* Creating controls dynamically at runtime.

\* Implementing base conversions manually \* Debugging a GUI application in Visual Studio



\## What I would improve



\* A lot of duplicated code regarding handlers.

\* `unit.baza\_curenta` is never initialised to `10`, so the first base switch takes the wrong branch.

\* Deleting on a one-character or empty field throws an error.

\* Adding colour to the GUI.



\## License



Copyright (c) 2026 Arina Ralea



All rights reserved.



This code is provided for portfolio and educational demonstration purposes only. No permission is granted to use, copy, modify, distribute, or sell this code, in whole or in part, without explicit written permission from the author.

