# TabbedMenuExample
Basically, you need one groupbox/container control and button for every tab. You then arrange so it's something like:

<- top                                       bottom ->

btn_Tab1  btn_Tab2  btn_Tab3  gbx_Tab1  gbx_Tab2  gbx_Tab3

In the designer view, the groupboxes should be separated, with at least one in the correct position. In the Form_load() function, you set the location of all the groupboxes to the correct one (or some other specified position).

From there, when a button is clicked, all the buttons need to be re-arranged then the button and corresponding groupbox needs to be raised to the top with .BringToFront().
