# Hospital-Management-System
Semester Project 
The task was to create hospital management system using  WinForms, that can predict diseases. We create C# WinForms application for hospital management  system. 
User can enter their diseases and our app will predict it using naïve byes algorithm which is trained on random diseases. Though I have to remove naive byes for now
because it was generating error but I will update it as soon as I can.

This project is developed using C# winforms and built in Sql database in visual studio. The app basically first allows you to sign in and sign up as doctor or patient.
then on patient credentials you have to enter your diseases and possible systems. If the naive byes is working properly you will see an immediate cause to your symtoms.

Make sure to modify the connection string in properties>settings.settings before you use it. 
First go to the server explorer which is most probably present on the left side of your visual studio. 
then inside Data connections you will see a database name like Database1.mdf right click on it and then select properties. 
on the right bottom side of visual studio you will see the properties of the Database1.mdf. 
Copy the connection string and then go to the properties>settings.settings remove the last value and paste the connection string instead.
