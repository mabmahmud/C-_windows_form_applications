                  ****Simple MDI text Editor****
Complete and Submit:
Write an MDI application to simulate a simple text editor.  Allowing the user to create/open multiple documents, each in a separate child Form within the MDI Parent window.  For the text editor child form, use one big TextBox control with its Multiline property set to true or a RichTextBox control.  You will require a SaveDialogue and OpenDialogue component in order to create/open a text file.
The main startup form (MDI Parent) should have a MenuStrip with Open and New menu items. Open will open previously saved txt files in a childMDI form. New should just open a blank childMDI form. The child forms should have a MenuStrip with a Save menu item to save their text to a file.  Use the file handling that you previously learned about and display the name of the file in the form's title bar.
Validate your text box in order to assure that text has been entered before attempting to save to a file.
Add a toolbar and status bar to the application forms, and code toolbar icons for Close, Save, Open appropriately.
Add a calendar DateTimePickerControl to your MDI Child form ToolBar menu selection. This will allow you to pick a date to concatenate to your written text.  Your written text should be followed with the following:  
Date Written:   ..date from D_T_Picker..
Assignment Screen Sample

Extra Comments are as follows:

When creating an MDI application (this will allow forms inside forms):
Form1 (Main Form) needs the property 'IsMdiContainer' set too TRUE.
Form2 (File/Text Editor Form) for rich textbox set 'Dock' to fill and 'Multiline' to TRUE.

***When calling Form2 you must set Form1 as the MdiParent to have it open inside Form1, as we did in class.

‘Status Bar’ useful for displaying current date and time

Solution Approach:

Solution is provided based on traditional windows form application. 
Two forms are created named parent and child form for MDI text editor.
Parent form has MenuStrips (File) that includes Open and New options to open file and create file. And also has a openFileDialogue component.
And the child form has a RichTextBox control that includes a SaveDialogue and OpenDialogue component in order to create/open a text file
The child form has a MenuStrip with a Save menu item to save their text to a file. 
Validation methods are created to ensure that text has been entered before attempting to save to a file.
And Added a toolbar and status bar to the application forms, and code toolbar icons for Close, Save, Open appropriately.
Then added a calendar DateTimePickerControl to the MDI Child form ToolBar menu selection to pick a date to concatenate to the written text.
From the main form 'IsMdiContainer' property is set too TRUE
